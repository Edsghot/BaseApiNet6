using BaseApiNet6.Configuration.Shared;
using BaseApiNet6.Model.Dtos.User;

namespace BaseApiNet6.Modules.User.Application.Port;

public interface IUserOutPort : IBasePresenter<object>
{
    void GetAllUsersAsync(IEnumerable<UserDto> data);
}