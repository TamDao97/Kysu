using Kysu.DB.DuLich.Model.Base;
using Kysu.DB.DuLich.Model.TouristPlace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kysu.Service.DuLich.TouristPlace
{
    public interface ITouristPlaceService
    {
        Task<SearchResultModel<DB.DuLich.Entities.TouristPlace>> Search(TouristPlaceSearchModel model);
        Task Insert(TouristPlaceModel model);
        Task Update(TouristPlaceModel model);
        Task Delete(object id);

        void GetTest();
    }
}
