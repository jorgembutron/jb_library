using System.Threading.Tasks;

namespace Jb.Api.Infrastructure.Abstractions
{
    public interface IRepository
    {
        Task<bool> SaveAsync();
    }
}
