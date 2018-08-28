using ClassLibrary1;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Api.Models.CityModel;

namespace Api.Controllers
{
    public class CityController : ApiController
    {
        private APIDbContext db=null;
        public CityController()
        {
            db = new APIDbContext();
        }
        //http://apidocjs.com/ len day va xem huong dan chi tiet

        /**
         * @api {get} /City/getAll get all city
       * @apiGroup City
       * @apiPermission none
       * @apiVersion 1.0.0
       * 
       * @apiParam {string} MaLop Ma cua lop moi 
       * @apiParam {string} TenLop Ten cua lop moi
       * 
       * @apiParamExample {json} Request-Example:
       * {
       *      MaLop: '001',
       *      TenLop: 'Cong nghe thong tin 01'
       * }
       * 
       * @apiSuccess {string} MaLop Ma cua lop moi vua tao
       * @apiSuccess {string} TenLop Ten cua lop moi vua tao
       * @apiSuccess {long} Id  Iid cua lop moi vua tao
       * 
       * @apiSuccessExample {json} Response:
       * {
       *      Id: 1,
       *      MaLop: '001'
       *      TenLop: 'Cong nghe thong tin 01'
       * }
       * 
       * 
       * @apiError (400) {string[]} Errors Mang cac loi
       * 
       * @apiErrorExample: {json}
       * {
       *      "Errors": [
       *          "Ma lop la truong bat buoc",
       *          
       *      ]
       * } 
       * 
       * 
      */
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var listLops = this.db.Citys.Select(x => new CityModel()
            {
                id = x.Id,
                Name=x.Name,
                StateId=x.State.Id

            });

            return Ok(listLops);
        }

    }
}
