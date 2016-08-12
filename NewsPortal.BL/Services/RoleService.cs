using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class RoleService : AbstractService, IRoleService
    {
        public RoleService(IDALUnitOfWork uow) : base(uow)
        {
        }
    }
}