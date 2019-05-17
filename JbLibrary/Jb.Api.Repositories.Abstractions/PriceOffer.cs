using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jb.Api.Repositories.Abstractions
{
    public class PriceOffer
    {
        [Column("Id")]
        public int PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; }

        //-----------------------------------------------
        //Relationships

        public int BookId { get; set; }            //#b
    }
}
