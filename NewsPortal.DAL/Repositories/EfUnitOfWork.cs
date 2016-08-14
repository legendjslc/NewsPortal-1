using System;
using NewsPortal.DAL.EF;
using NewsPortal.DAL.Entities;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.DAL.Repositories
{
    public class EfUnitOfWork : IDALUnitOfWork
    {
        private NewsPortalContext _db;
        private bool _disposed = false;

        private IRepository<Comment> _commentRepository;
        private IRepository<News> _newsRepository;
        private IRepository<Role> _roleRepository;
        private IRepository<User> _userRepository;

        public EfUnitOfWork()
        {
            _db = new NewsPortalContext();
        }

        public IRepository<Comment> CommentRepository
        {
            get { return _commentRepository ?? (_commentRepository = new Repository<Comment>(_db)); }
        }

        public IRepository<News> NewsRepository
        {
            get { return _newsRepository ?? (_newsRepository = new Repository<News>(_db)); }
        }

        public IRepository<Role> RoleRepository
        {
            get { return _roleRepository ?? (_roleRepository = new Repository<Role>(_db));  }
        }

        public IRepository<User> UserRepository
        {
            get { return _userRepository ?? (_userRepository = new Repository<User>(_db));  }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }
        }
    }
}