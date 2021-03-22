using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Models
{
    public class CharacterPortrait
    {
        public int Id { get; set; }
        
        public string ImgSrc { get; set; }

        public CharacterPortrait()
        {
         
        }

        public CharacterPortrait(string imgSrc ) : this()
        {
            ImgSrc = imgSrc;
        }
    }
}
