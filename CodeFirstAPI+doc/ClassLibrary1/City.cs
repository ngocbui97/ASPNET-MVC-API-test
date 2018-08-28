﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassLibrary1
{
    public class City : Entity<int>
    {
        public string Name { get; set; }
        public virtual State State{get;set;}

    }
}