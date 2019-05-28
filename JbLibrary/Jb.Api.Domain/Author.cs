using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
{
    public class Author
    {
        [Column("Id")]
        public Guid AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public ICollection<BookAuthor> Books { get; set; }  = new List<BookAuthor>();

        public Author(string name, DateTimeOffset dateOfBirth)
        {
            Name = name.ToLowerInvariant();
            DateOfBirth = dateOfBirth;
        }
    }
}
