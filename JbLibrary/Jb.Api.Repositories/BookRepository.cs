using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Jb.Api.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Jb.Api.Repositories
{
    public class BookRepository : IBookRepository
    {
        protected LibraryDbContext Context { get; }

        public BookRepository(LibraryDbContext context)
        {
            Context = context;
        }
        public void GetBooks()
        {
            var books = Context.Books
                //.Include(a => a.AuthorsLink)
                //.ThenInclude(a => a.Author)
                //.Include(r => r.Reviews)
                //.Where(b => b.BookId == 1).ToList()
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    Reviews = b.Reviews.Select(r => r.Comment)
                })
                .Where(b => b.BookId == 1).ToList();
        }
    }
}
