﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVCMySql.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}