using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Models
{
    public class GameInventory
    {
        public int Id { get; set; }
        
        public List<InventoryItem> InventoryItems { get; set; }

        public GameInventory()
        {
        
        }

        public GameInventory(List<InventoryItem> inventoryItems) : this()
        {
            InventoryItems = inventoryItems;
        }
    }
}
