﻿using BaseApiNet6.Model.Dtos.User;
using BaseApiNet6.Modules.User.Application.Port;
using BaseApiNet6.Modules.User.Domain.Entity;
using BaseApiNet6.Modules.User.Domain.IRepository;

namespace BaseApiNet6.Modules.User.Application.Adapter;

public class UserAdapter: IUserInputPort
{
    private readonly IUserRepository _userRepository;
    private readonly IUserOutPort _userOutPort;

    public UserAdapter(IUserRepository repository,IUserOutPort userOutPort)
    {
        _userRepository = repository;
        _userOutPort = userOutPort;
    }
    
     public async Task GetAllUsersAsync()
     {
         var users = await _userRepository.GetAllAsync<UserEntity>();

         if (!users.Any())
         {
             _userOutPort.NotFound("No users found.");
             return;
         }

         var userDtos = users.Select(user => new UserDto
         {
             Id = user.Id,
             FirstName = user.FirstName,
             LastName = user.LastName,
             Email = user.Email,
             BirthDate = user.BirthDate
         });
         
         _userOutPort.GetAllUsersAsync(userDtos);

     }
}