using System.Linq;
using Jb.Api.Infrastructure.Repositories.Abstractions;
using Jb.Api.Infrastructure.Repositories.Context;

namespace Jb.Api.Infrastructure.Repositories
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
