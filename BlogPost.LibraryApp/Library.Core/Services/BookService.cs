using Library.Core.Entities;
using Library.Core.Interfaces;
using Library.Core.Specifications.Books;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IGenericReadRepository repository;
        public BookService(IGenericReadRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            var spec = new BookWithAuthorAndCategorySpecification();
            return await repository.ListAsync(spec);
        }
    }
}
