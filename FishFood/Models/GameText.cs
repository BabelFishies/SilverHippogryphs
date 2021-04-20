using System;
using System.Collections.Generic;

namespace FishFood.Models
{
    public class GameText
    {
        public int Id { get; set; }
        
        public string StoryPassage { get; set; }
        public List<Option> OptionList { get; set; } = new List<Option>();
        
        public string Title { get; set; }

        public bool IsAWinner { get; set; }
        public bool IsALoser { get; set; }

        public GameText()
        {
            
        }
        
        public GameText (string title, string storyPassage, bool isAWinner, bool isALoser) : this()
        {
            Title = title;
            StoryPassage = storyPassage;
            IsAWinner = isAWinner;
            IsALoser = isALoser;
        }

        public GameText (string title, string storyPassage)
        {
            Title = title;
            StoryPassage = storyPassage;
        }

        public string ConvertOptionListToJS()
        {
            var result = string.Empty;
            foreach(var option in OptionList)
            {
                result += "'" + option.Text + "', ";
            }
            return $"[{result}]";
        }

    }
}
