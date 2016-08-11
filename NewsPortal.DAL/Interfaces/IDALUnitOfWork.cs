using System;

namespace NewsPortal.DAL.Interfaces
{
    public interface IDALUnitOfWork : IDisposable
    {


        void Save();
    }
}