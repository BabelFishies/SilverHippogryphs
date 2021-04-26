﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FishFood.Models
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole() 
        {
        }
        public string RoleName { get; set; }
    }
}