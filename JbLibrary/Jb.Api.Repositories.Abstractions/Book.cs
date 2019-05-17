﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jb.Api.Repositories.Abstractions
{
    public class Book
    {
        [Column("Id")]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public PriceOffer Promotion { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<BookAuthor> AuthorsLink { get; set; }

    }
}