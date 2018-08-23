using CRUDAPI.EF;
using CRUDAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAPI.DI
{
    public interface IRepository // 
    {
        IList<UserViewModel> getAll();
    }
}
