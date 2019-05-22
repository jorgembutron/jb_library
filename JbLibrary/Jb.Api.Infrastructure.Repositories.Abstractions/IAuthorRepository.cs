using Jb.Api.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jb.Api.Infrastructure.Abstractions
{
    public interface IAuthorRepository : IRepository
    {
        Task<IReadOnlyCollection<Author>> GetAuthorsAsync();

        Task<Author> GetAuthorAsync(Guid id);

        Task<Guid> AddAuthorAsync(Author author);

        Task<bool> AuthorExistsAsync(Guid id);
    }
}
