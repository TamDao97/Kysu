using Kysu.DAL.DuLich.UnitOfWork;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Kysu.DB.DuLich.Model.TouristPlace;
using Microsoft.EntityFrameworkCore;
using Kysu.DB.DuLich.Model.Base;

namespace Kysu.Service.DuLich.TouristPlace
{
    public class TouristPlaceService : ITouristPlaceService
    {
        private IUnitOfWork _unitOfWork { get; set; }
        public TouristPlaceService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<SearchResultModel<DB.DuLich.Entities.TouristPlace>> Search(TouristPlaceSearchModel model)
        {
            SearchResultModel<DB.DuLich.Entities.TouristPlace> result = new SearchResultModel<DB.DuLich.Entities.TouristPlace>();
            Expression<Func<Kysu.DB.DuLich.Entities.TouristPlace, bool>> filter = x => x.Name.Contains(model.Name);
            Func<IQueryable<Kysu.DB.DuLich.Entities.TouristPlace>, IOrderedQueryable<Kysu.DB.DuLich.Entities.TouristPlace>> orderBy = q => q.OrderByDescending(e => e.Name);
            var query = _unitOfWork.TouristPlace.GetAll(filter, orderBy).Result;

            result.TotalItem = query.Select(r => r.Id).Count();
            result.Data = await query.Skip((model.PageNumber - 1) * model.PageSize)
                            .Take(model.PageSize)
                            .ToListAsync();
            return result;
        }

        public async Task Insert(TouristPlaceModel model)
        {
            Kysu.DB.DuLich.Entities.TouristPlace entity = Kysu.DB.DuLich.Entities.TouristPlace.Clone(model);
            await _unitOfWork.TouristPlace.Insert(entity);
            _unitOfWork.Save();
        }

        public async Task Update(TouristPlaceModel model)
        {
            Kysu.DB.DuLich.Entities.TouristPlace entity = Kysu.DB.DuLich.Entities.TouristPlace.Clone(model);
            await _unitOfWork.TouristPlace.Update(entity);
            _unitOfWork.Save();
        }

        public async Task Delete(object id)
        {
            await _unitOfWork.TouristPlace.Delete(id);
            _unitOfWork.Save();
        }

        public void GetTest()
        {
            var query = _unitOfWork.TouristPlace.GetAll().Result;
        }
    }
}
