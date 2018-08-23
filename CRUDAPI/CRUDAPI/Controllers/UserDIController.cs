using CRUDAPI.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDAPI.Controllers
{
    public class UserDIController : ApiController // controler use to test dependency injection
    {
        private readonly IRepository _repository; //  doi tuong controler
        private readonly IDataBase _dataBase; // loai data base
       public UserDIController(IRepository repository,IDataBase dataBase)
        {
            _repository = repository;
            _dataBase = dataBase;
        }
        [HttpGet]
        public IHttpActionResult all()
        {
            _dataBase.getAll();
            var all = this._repository.getAll();
            return Ok(all);
            
        }
    }
}
