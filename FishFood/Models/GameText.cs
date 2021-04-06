using System;
using System.Collections.Generic;

namespace FishFood.Models
{
    public class GameText
    {
        public int Id { get; set; }
        
        public string StoryPassage { get; set; }
        public List<Option> OptionList { get; set; } = new List<Option>();

        public GameText()
        {
            
        }
        
        public GameText (string storyPassage, List<Option> optionList) : this()
        {
            StoryPassage = storyPassage;
            OptionList = optionList;
        }

        public GameText (string storyPassage)
        {
            StoryPassage = storyPassage;
        }



    }
}
