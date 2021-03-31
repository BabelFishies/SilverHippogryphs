using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FishFood.Models;

namespace FishFood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GameText> GameText { get; set; }
        public DbSet<Option> Option { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
