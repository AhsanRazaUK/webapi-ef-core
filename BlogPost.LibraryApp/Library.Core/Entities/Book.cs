using Library.Core.SharedKernal;
using System;

namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
