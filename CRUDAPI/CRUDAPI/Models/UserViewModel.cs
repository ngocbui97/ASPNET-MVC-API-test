﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAPI.Models
{
    public class UserViewModel // call DTO (data trafer object)
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
       
        //public string FirstName { get; set; }
      //  public string LastName { get; set; }
       // public string Address { get; set; }
       // public string Email { get; set; }
        //public string Phone { get; set; }
        //public Nullable<System.DateTime> CreatedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public Nullable<System.DateTime> ModifiedDate { get; set; }
        //public string ModifiedBy { get; set; }
        //public Nullable<bool> Status { get; set; }
    }
}