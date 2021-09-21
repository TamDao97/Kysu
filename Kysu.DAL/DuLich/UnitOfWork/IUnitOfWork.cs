using Kysu.DAL.DuLich.Repository.TouristPlace;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DAL.DuLich.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        TouristPlaceRepository TouristPlace { get; }
        bool Save();
    }
}
