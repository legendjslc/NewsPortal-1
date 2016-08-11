using System;
using NewsPortal.DAL.EF;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.DAL.Repositories
{
    public class EfUnitOfWork : IDALUnitOfWork
    {
        private NewsPortalContext _db;
        private bool _disposed = false;

        //interfaces of IRepo here

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