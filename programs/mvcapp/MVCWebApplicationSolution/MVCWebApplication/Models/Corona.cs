﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class Corona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Active { get; set; }
        public int Recovered { get; set; }
        public int Death { get; set; }


    }
}