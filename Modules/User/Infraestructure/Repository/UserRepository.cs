using BaseApiNet6.Configuration.Context.Repository;
using BaseApiNet6.Configuration.DataBase;
using BaseApiNet6.Modules.User.Domain.Entity;
using BaseApiNet6.Modules.User.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BaseApiNet6.Modules.User.Infraestructure.Repository;

public class UserRepository : BaseRepository<MySqlContext>, IUserRepository
{
    public UserRepository(MySqlContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<UserEntity>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
}