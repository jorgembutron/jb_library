using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Jb.Api.Repositories.Abstractions
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
