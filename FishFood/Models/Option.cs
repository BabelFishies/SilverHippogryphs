using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishFood.Models
{
    public class Option
    {
        public int Id { get; set; }
        public int PassageId { get; set; }
        public string Text { get; set; }

        public Option()
        {

        }

        public Option(int id, int passageId)
        {
            Id = id;
            PassageId = passageId;
        }
    }
}
