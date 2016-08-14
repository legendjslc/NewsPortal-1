using System.Collections.Generic;
using AutoMapper;
using NewsPortal.BL.DTO;
using NewsPortal.BL.Interfaces;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public class RoleService : AbstractService, IRoleService
    {
        public RoleService(IDALUnitOfWork uow) : base(uow)
        {

        }

        public IEnumerable<RoleDTO> GetRoles()
        {
            var x = Database.RoleRepository.All();
            return Mapper.Map<IEnumerable<RoleDTO>>(x);
        }
    }
}