using System;

namespace Jb.Api.Repositories.Abstractions
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
