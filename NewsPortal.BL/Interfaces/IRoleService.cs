using System.Collections.Generic;
using NewsPortal.BL.DTO;

namespace NewsPortal.BL.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<RoleDTO> GetRoles();
    }
}