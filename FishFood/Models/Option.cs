using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Models
{
    public class Option
    {
        public int Id { get; set; }
      
        public int GameTextId { get; set; }
        public string Text { get; set; }

        public Option()
        {

        }
        
        public Option( int gameTextId, string text)
        {
          
            GameTextId = gameTextId;
            Text = text;
        }
    }
}
