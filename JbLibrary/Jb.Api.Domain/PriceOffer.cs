using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
{
    public class PriceOffer
    {
        [Column("Id")]
        public Guid PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; }

        //-----------------------------------------------
        //Relationships

        public Guid BookId { get; set; }            //#b
    }
}
