using AutoMapper;
using Library.Core.Entities;
using Library.WebApi.Resources;

namespace Library.WebApi.Mappings
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Book, BookResource>()
                .ForMember
                (destination => destination.BookId,
                opts => opts.MapFrom(source => source.Id))
                .ForMember(destination => destination.Title,
                opts => opts.MapFrom(source => source.BookName))
                .ForMember(destination => destination.AuthorName,
                opts => opts.MapFrom(source => $"{source.Author.FirstName} {source.Author.LastName}"))
                 .ForMember(destination => destination.Category,
                opts => opts.MapFrom(source => source.Category.CategoryName));
        }
    }
}
