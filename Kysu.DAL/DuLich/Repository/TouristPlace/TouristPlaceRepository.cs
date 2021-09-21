using Kysu.DAL.DuLich.Repository.Generic;
using Kysu.DB.DuLich.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DAL.DuLich.Repository.TouristPlace
{
    public class TouristPlaceRepository : GenericRepository<Kysu.DB.DuLich.Entities.TouristPlace>, ITouristPlaceRepository
    {
        public TouristPlaceRepository(DulichContext context) : base(context)
        { }
    }
}
