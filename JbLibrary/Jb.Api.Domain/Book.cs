using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
{
    public class Book
    {
        [Column("Id")]
        public Guid BookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(256)]
        public string Description { get; set; }

        [Required]
        public DateTime PublishedOn { get; set; }

        [Required]
        [MaxLength(100)]
        public string Publisher { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public PriceOffer Promotion { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<BookAuthor> AuthorsLink { get; set; }

    }
}
