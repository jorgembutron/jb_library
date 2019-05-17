using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Repositories.Abstractions
{
    public class Author
    {
        [Column("Id")]
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<BookAuthor> BooksLink { get; set; } 
    }
}
