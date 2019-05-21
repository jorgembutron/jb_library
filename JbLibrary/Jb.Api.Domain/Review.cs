using System.ComponentModel.DataAnnotations.Schema;

namespace Jb.Api.Domain
{
    public class Review
    {
        [Column("Id")]
        public int ReviewId { get; set; }
        public string VoterName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }

        public int BookId { get; set; }
    }
}
