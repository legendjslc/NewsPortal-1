using System;
using NewsPortal.DAL.Entities;

namespace NewsPortal.BL.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}