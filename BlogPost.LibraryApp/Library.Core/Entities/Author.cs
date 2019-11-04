using Library.Core.SharedKernal;
using System.Collections.Generic;

namespace Library.Core.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}