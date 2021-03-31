using System;
using System.Collections.Generic;

namespace FishFood.Models
{
    public class GameText
    {
        public int Id { get; set; }
        
        public string StoryPassage { get; set; }
        public List<Option> OptionList { get; set; }

        public GameText()
        {
            
        }
        
        public GameText (string storyPassage) : this()
        {
            StoryPassage = storyPassage;
        }



    }
}
