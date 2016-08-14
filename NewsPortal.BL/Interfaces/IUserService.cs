using System;
using NewsPortal.BL.DTO;

namespace NewsPortal.BL.Interfaces
{
    public interface IUserService
    {
        UserDTO CreateUser(UserDTO user);
        UserDTO EditUser(UserDTO user);
        bool DeleteUser(UserDTO user);
        UserDTO GetUser(Guid id);
    }
}