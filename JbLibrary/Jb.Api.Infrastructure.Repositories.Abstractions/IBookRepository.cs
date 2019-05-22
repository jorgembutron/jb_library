
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jb.Api.Domain;

namespace Jb.Api.Infrastructure.Abstractions
{
    public interface IBookRepository : IRepository
    {
        Task<Book> GetBookFromAuthorAsync(Guid authorId, Guid bookId);

        Task<IReadOnlyCollection<Book>> GetBooksFromAuthorAsync(Guid authorId);

        Task<bool> AddBookForAuthorAsync(Guid authorId, Book book);
     }
}
