using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FishFood.Models
{
    public class AddPassageViewModel
    {
        [Required]
        public string StoryPassage { get; set; }

        [Required]
        public string Title { get; set; }
        public bool IsAWinner { get; set; }
        public bool IsALoser { get; set; }
        

    }
}
