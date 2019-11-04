using Library.Core.Entities;

namespace Library.Core.Specifications.Books
{
    public class BookWithAuthorAndCategorySpecification : BaseSpecification<Book>
    {
        public BookWithAuthorAndCategorySpecification() : base()
        {
            AddInclude(b => b.Author);
            AddInclude(b => b.Category);
        }
    }
}
