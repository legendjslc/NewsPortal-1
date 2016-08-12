using System;
using NewsPortal.DAL.Entities;

namespace NewsPortal.DAL.Interfaces
{
    public interface IDALUnitOfWork : IDisposable
    {
        IRepository<Comment> CommentRepository { get; }
        IRepository<News> NewsRepository { get; }
        IRepository<Role> RoleRepository { get; }  
        IRepository<User> UserRepository { get; } 

        void Save();
    }
}