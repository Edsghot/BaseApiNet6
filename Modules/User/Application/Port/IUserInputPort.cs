using BaseApiNet6.Model.Dtos.User;
using BaseApiNet6.Modules.User.Domain.Entity;

namespace BaseApiNet6.Modules.User.Application.Port;

public interface IUserInputPort
{
    Task GetAllUsersAsync();
}