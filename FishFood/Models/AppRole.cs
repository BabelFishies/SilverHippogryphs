using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FishFood.Models
{
    public class AppRole : IdentityRole<int>
    {
          public string RoleName { get; set; }

        //public AppRole(string roleName) : base(roleName)
        //{
        //    RoleName = roleName;
        //}
    }
}