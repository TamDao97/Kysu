using Kysu.API.Response;
using Kysu.Core.Common;
using Kysu.DB.DuLich.Entities;
using Kysu.DB.DuLich.Model;
using Kysu.DB.DuLich.Model.Base;
using Kysu.DB.DuLich.Model.TouristPlace;
using Kysu.Service.DuLich.TouristPlace;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kysu.API.Controllers
{
    [Route("api/touristplace")]
    [ApiController]
    public class TouristPlaceController : ControllerBase
    {
        private readonly ITouristPlaceService _service;
        public TouristPlaceController(ITouristPlaceService service)
        {
            this._service = service;
        }

        [Route("search")]
        [HttpPost]
        public async Task<ActionResult<ResponseAPI<SearchResultModel<TouristPlace>>>> Search(TouristPlaceSearchModel model)
        {
            ResponseAPI<SearchResultModel<TouristPlace>> response = new ResponseAPI<SearchResultModel<TouristPlace>>
            {
                Status = new Status { Code = Constant.C100, Message = Constant.Error[Constant.C100] }
            };

            try
            {
                response.Data = await _service.Search(model);
            }
            catch (Exception ex)
            {
                response.Status.Code = Constant.C101;
                response.Status.Message = Constant.Error[Constant.C101];
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseAPI<TouristPlace>>> Insert(TouristPlaceModel model)
        {
            ResponseAPI<TouristPlace> response = new ResponseAPI<TouristPlace>
            {
                Status = new Status { Code = Constant.C100, Message = Constant.Error[Constant.C100] }
            };

            try
            {
                await _service.Insert(model);
            }
            catch (Exception ex)
            {
                response.Status.Code = Constant.C101;
                response.Status.Message = Constant.Error[Constant.C101];
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<ResponseAPI<TouristPlace>>> Update(TouristPlaceModel model)
        {
            ResponseAPI<TouristPlace> response = new ResponseAPI<TouristPlace>
            {
                Status = new Status { Code = Constant.C100, Message = Constant.Error[Constant.C100] }
            };

            try
            {
                await _service.Update(model);
            }
            catch (Exception ex)
            {
                response.Status.Code = Constant.C101;
                response.Status.Message = Constant.Error[Constant.C101];
            }

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<ResponseAPI<TouristPlace>>> Delete(int id)
        {
            ResponseAPI<TouristPlace> response = new ResponseAPI<TouristPlace>
            {
                Status = new Status { Code = Constant.C100, Message = Constant.Error[Constant.C100] }
            };

            try
            {
                await _service.Delete(id);
            }
            catch (Exception ex)
            {
                response.Status.Code = Constant.C101;
                response.Status.Message = Constant.Error[Constant.C101];
            }

            return Ok(response);
        }
    }
}
