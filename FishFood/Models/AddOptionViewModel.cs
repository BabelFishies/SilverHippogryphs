using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FishFood.Models
{
    public class AddOptionViewModel
    {
        [Required]
        public int GameTextId { get; set; }
        [Required]
        public int LinkId { get; set; }
        [Required]
        public string Text { get; set; }



    //make a list of gametextid's to choose from and linkid's to choose from when making an option


    }
}
