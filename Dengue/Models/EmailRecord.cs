﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dengue.Models
{
    public class EmailRecord
    {
        public string Location { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
