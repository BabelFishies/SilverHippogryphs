using System;

namespace FishFood.Models
{
    public class GameText
    {
        public int Id { get; set; }
        private int nextId;
        public string StoryPassage { get; set; }

        public GameText()
        {
            Id = nextId;
            nextId++;
        }
        
        public GameText (string storyPassage) : this()
        {
            StoryPassage = storyPassage;
        }



    }
}
