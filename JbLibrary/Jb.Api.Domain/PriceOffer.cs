using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
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
