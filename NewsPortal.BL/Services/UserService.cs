using NewsPortal.BL.DTO;
using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class UserService : AbstractService, IUserService
    {
        public UserService(IDALUnitOfWork uow) : base(uow)
        {
        }

        public UserDTO CreateUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }

        public UserDTO EditUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }
    }
}