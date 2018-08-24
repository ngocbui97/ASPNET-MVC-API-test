using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace hostAPI
{
    public class HomeController : ApiController
    {
        // neu ko co khai bao attribute method o dau moi action thi phai viet ten method co chu dau cua http method(get,post,put,delete)
        public string Get()
        {
            return "Hello World!";
        }

        public string Get(string name)
        {
            return "Hello " + name;
        }
        public string GetIndex()
        {
            return "index page";
        }
    }
}
