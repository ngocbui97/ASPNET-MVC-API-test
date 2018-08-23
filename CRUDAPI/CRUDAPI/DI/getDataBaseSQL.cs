using CRUDAPI.EF;
using CRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAPI.DI
{
    public class getDataBaseSQL : IDataBase
    {
        private ShoppingCartEntities db = null;
        public getDataBaseSQL()
        {
           db= new ShoppingCartEntities();
         }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }


        void IDataBase.Save()
        {
            throw new NotImplementedException();
        }
        public IList<UserViewModel> getAll()
        {
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