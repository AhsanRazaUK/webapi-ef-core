using System.Collections.Generic;

namespace Library.WebApi.Resources
{
    public class BookResultResource
    {
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        public IEnumerable<BookResource> Books { get; set; }
    }
    public class BookResource
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Category { get; set; }
    }
}
