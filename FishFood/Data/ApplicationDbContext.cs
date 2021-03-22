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

        public DbSet<GameInventory> GameInventory { get; set; }
        public DbSet<InventoryItem> InventoryItem { get; set; }
        public DbSet<CharacterPortrait> CharacterPortrait  { get; set; }
        //public DbSet<MenuButton> MenuButton { get; set; }
        //public DbSet<GameChoice> GameChoice { get; set; }
        //public DbSet<GameText> GameText { get; set; }
        


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
