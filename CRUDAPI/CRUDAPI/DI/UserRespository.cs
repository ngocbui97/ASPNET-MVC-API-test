using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUDAPI.EF;
using CRUDAPI.Models;

namespace CRUDAPI.DI
{
    public class UserRespository : IRepository
    {
        public IList<UserViewModel> getAll()
        {
            ShoppingCartEntities db = new ShoppingCartEntities();
            IList<UserViewModel> lUser = null;
            UserViewModel u = null;
            lUser = db.Users.Select(s => new UserViewModel()
            {
                UserID = s.UserID,
                Username = s.Username,
                Password = s.Password
            }).ToList<UserViewModel>();
            if (lUser.Count == 0) return null;
            return lUser;
        }

       
    }
}