using BaseApiNet6.Configuration.Shared;
using BaseApiNet6.Model.Dtos.User;
using BaseApiNet6.Modules.User.Application.Port;
using BaseApiNet6.Model.Dtos.Response;

namespace BaseApiNet6.Modules.User.Infraestructure.Presenter;

public class UserPresenter : BasePresenter<object>, IUserOutPort
{
    public void GetAllUsersAsync(IEnumerable<UserDto> data)
    {
        Success(data, "Users successfully retrieved.");
    }

    public void NotFound(string message = "Data not found")
    {
        base.NotFound(message);
    }
}