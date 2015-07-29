using System;

namespace Serkomut.Repository.SqlDb
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}