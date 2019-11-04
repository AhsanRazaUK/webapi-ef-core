using AutoMapper;
using Library.Core.Interfaces;
using Library.WebApi.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.WebApi.Controllers
{
    [Authorize]
    public class BooksController : BaseApiController
    {
        private readonly ILogger<BooksController> logger;
        private readonly IMapper mapper;
        private readonly IBookService service;

        public BooksController(ILogger<BooksController> logger,
            IMapper mapper,
            IBookService service)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(BookResultResource), 200)]
        public async Task<IActionResult> Get()
        {
            try
            {
                logger.LogInformation("In BooksController Get");

                var bookResource = new BookResultResource()
                {
                    UserFullName = GetUserInfo("name"),
                    UserName = GetUserInfo("preferred_username"),
                    Books =
                    mapper.Map<IEnumerable<BookResource>>(await service.GetAllBooksAsync())
                };

                return Ok(bookResource);
            }
            catch (Exception ex)
            {
                logger.LogError($"Error in BooksController: {ex.Message}");
                return BadRequest($"{BadRequest().StatusCode} : {ex.Message}");

            }
        }
    }
}
