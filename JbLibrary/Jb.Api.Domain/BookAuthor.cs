using System;

namespace Jb.Api.Domain
{
    public class BookAuthor
    {
        public Guid BookId { get; set; }        //#H
        public Guid AuthorId { get; set; }      //#H
        public byte Order { get; set; }        //#I

        //-----------------------------
        //Relationships

        public Book Book { get; set; }        //#J
        public Author Author { get; set; }    //#K
    }
}
