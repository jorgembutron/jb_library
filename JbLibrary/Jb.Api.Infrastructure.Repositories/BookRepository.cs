using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jb.Api.Domain;
using Jb.Api.Infrastructure.Abstractions;
using Jb.Api.Infrastructure.Context;

namespace Jb.Api.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        protected LibraryDbContext Context { get; }

        public BookRepository(LibraryDbContext context)
        {
            Context = context;
        }

        public Task<Book> GetBookFromAuthorAsync(Guid authorId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Book>> GetBooksFromAuthorAsync(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddBookForAuthorAsync(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
