using Kysu.DAL.DuLich.Repository.TouristPlace;
using Kysu.DB.DuLich.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DAL.DuLich.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        DulichContext _context;
        private TouristPlaceRepository _touristPlace;

        public UnitOfWork(DulichContext context)
        {
            _context = context;
        }

        TouristPlaceRepository IUnitOfWork.TouristPlace
        {
            get
            {
                return _touristPlace ?? (_touristPlace = new TouristPlaceRepository(_context));
            }
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
