// Environment2D Repository Interface
using Induvidueel_ProjectAPI.Models;

namespace Induvidueel_ProjectAPI.Repositories
{
    public interface IEnvironment2DRepository
    {
        Task<IEnumerable<Environment2D>> GetAllAsync();
        Task<Environment2D> GetByIdAsync(Guid id);
        Task<Guid> InsertAsync(Environment2D environment);
        Task<bool> UpdateAsync(Environment2D environment);
        Task<bool> DeleteAsync(Guid id);
    }
}