using BaseApiNet6.Configuration.Context.Repository;
using BaseApiNet6.Modules.User.Domain.Entity;

namespace BaseApiNet6.Modules.User.Domain.IRepository;

public interface IUserRepository : IBaseRepository
{
    Task<IEnumerable<UserEntity>> GetAllAsync();
}