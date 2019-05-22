using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
{
    public class Author
    {
        [Column("Id")]
        public Guid AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<BookAuthor> BooksLink { get; set; } 
    }
}
