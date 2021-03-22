using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasItem { get; set; }

        public InventoryItem()
        {
           
        }

        public InventoryItem(string name, string description, bool hasItem) : this()
        {
            Name = name;
            Description = description;
            HasItem = hasItem;
        }
    }
}
