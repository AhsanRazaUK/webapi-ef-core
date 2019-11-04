using Library.Core.SharedKernal;
using System.Collections.Generic;

namespace Library.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}