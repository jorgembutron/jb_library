using Jb.Api.Models;
using System;
using System.Threading.Tasks;

namespace Jb.Api.Services.Abstractions
{
    public interface IAuthorService
    {
        Task AddAuthorAsync();

        Task<AuthorCreationDto> GetAuthorsAsync();
    }
}
