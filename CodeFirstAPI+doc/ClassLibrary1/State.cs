using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassLibrary1
{
    public class State:Entity<int>
    {      
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
       public virtual Country Country { get; set; }
    }
}