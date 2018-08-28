using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class CityModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public CityModel()
        {

        }
        public  CityModel(City c)
        {
            id = c.Id;
            Name = c.Name;
           StateId = c.State.Id;
        }

    }
}