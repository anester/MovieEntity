using System;
using System.Collections.Generic;
using System.Text;
using Movie.Db.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace Movie.Db.Implementation
{
    class UnitOfWork : IUnitOfWork
    {
        readonly MovieContext _context;
        IDbContextTransaction _transaction = null;

        public UnitOfWork(MovieContext context)
        {
            _context = context;
        }

        public UnitOfWorkState State { get; private set; }

        public void Commit()
        {
            if (State == UnitOfWorkState.Entered)
            {
                _transaction?.Commit();
                State = UnitOfWorkState.Committed;
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
        }

        public void Enter()
        {
            if (State == UnitOfWorkState.Nothing)
            {
                _transaction = _context.Database.BeginTransaction();
                State = UnitOfWorkState.Entered;
            }
        }

        public void Rollback()
        {
            if(State == UnitOfWorkState.Entered)
            {
                _transaction?.Rollback();
                State = UnitOfWorkState.Rollback;
            }
        }
    }
}
