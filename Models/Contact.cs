﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}