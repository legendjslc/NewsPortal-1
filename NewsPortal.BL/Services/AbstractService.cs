using System;
using NewsPortal.DAL.Interfaces;

namespace NewsPortal.BL.Services
{
    public abstract class AbstractService : IDisposable
    {
        protected bool _disposed = false;

        public AbstractService(IDALUnitOfWork uow)
        {
            Database = uow;
        }


        protected IDALUnitOfWork Database { get; }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                Database.Dispose();
            }

            _disposed = true;
        }
    }
}
