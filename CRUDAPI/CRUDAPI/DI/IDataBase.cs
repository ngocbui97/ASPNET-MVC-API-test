using CRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAPI.DI
{
    public interface IDataBase
    {
        void Save();
        void Insert();
        Boolean Delete();
        IList<UserViewModel> getAll();
    }
}
