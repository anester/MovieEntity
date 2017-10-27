using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Db.Interfaces
{
    public enum UnitOfWorkState
    {
        Nothing = 0,
        Entered,
        Committed,
        Rollback
    }

    public interface IUnitOfWork : IDisposable
    {
        void Enter();
        void Commit();
        void Rollback();
        UnitOfWorkState State { get; }
    }
}
