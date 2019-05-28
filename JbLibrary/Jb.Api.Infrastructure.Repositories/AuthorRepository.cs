using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jb.Api.Domain;
using Jb.Api.Infrastructure.Abstractions;
using Jb.Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Jb.Api.Infrastructure
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryDbContext _libraryDbContext;

        public AuthorRepository(LibraryDbContext libraryDbContext)
        {
            _libraryDbContext = libraryDbContext;
        }

        public async Task<IReadOnlyCollection<Author>> GetAuthorsAsync() 
            => await _libraryDbContext.Authors.AsNoTracking()
                                                .ToListAsync().ConfigureAwait(false);

        public async Task<Author> GetAuthorAsync(Guid authorId) 
            => await _libraryDbContext.Authors.AsNoTracking()
                                                .FirstOrDefaultAsync(a => a.AuthorId == authorId);

        public async Task<Guid> AddAuthorAsync(Author author)
        {
           var x = await _libraryDbContext.Authors.AddAsync(author).ConfigureAwait(false);

            return  Guid.Empty;
        }

        public Task<bool> AuthorExistsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAsync() => 
            await _libraryDbContext.SaveChangesAsync().ConfigureAwait(false) >= 0;
    }
}
