using CRUDAPI.EF;
using CRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDAPI.Controllers
{
    public class UserController : ApiController
    {
        private ShoppingCartEntities db = null;
        public UserController()
        {
           db = new ShoppingCartEntities();
        }
        [HttpGet]
        public IHttpActionResult getAll()
        {
            IList<UserViewModel> lUser = null;
            UserViewModel u = null;
            lUser = db.Users.Select(s => new UserViewModel()
            {
                UserID = s.UserID,
                Username=s.Username,
                Password=s.Password
            }).ToList<UserViewModel>();
            if (lUser.Count == 0) return NotFound();
            return Ok(lUser);
        }

        [HttpGet]
        public IHttpActionResult getById(int id)
        {
            var user = db.Users.Find(id);
            if (user == null) return NotFound();
            else return Ok(user);
        }
        [HttpPost]
        public IHttpActionResult create(UserViewModel model)
        {
            if (model != null)
            {
                User u = new User();
               // u.UserID = model.UserID;
                u.Username = model.Username;
                u.Password = model.Password;
                db.Users.Add(u);
                db.SaveChanges();
                return Ok(u);
            }
            else return BadRequest();

        }
        [HttpPut]
        public IHttpActionResult update(UserViewModel model)
        {
            var u = db.Users.FirstOrDefault(x => x.UserID == model.UserID);
            if (u != null)
            {
                u.Username = model.Username;
                u.Password = model.Password;
                db.SaveChanges();
                return Ok(u);

            }
            else return BadRequest();

        }
        [HttpDelete]
        public IHttpActionResult delete(int id)
        {
            var u = db.Users.FirstOrDefault(x => x.UserID == id);
            if (u != null)
            {
                db.Users.Remove(u);
                db.SaveChanges();
                return Ok(u);
            }
            else return BadRequest();

        }
    }
}
