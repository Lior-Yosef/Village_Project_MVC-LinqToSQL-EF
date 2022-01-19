﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Village_Project_MVC_LinqToSQL_EF.Models
{
    public class Resident
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public bool IsBornInVillage { get; set; }
        public DateTime boorn { get; set; }

    }
}