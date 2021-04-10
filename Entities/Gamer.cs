using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_K.Entities
    {
    public class Gamer
        {
        public int gamerId { get; set; }
        public string gamerName { get; set; }
        public string gamerMail { get; set; }
        public string gamerPassword { get; set; }
        public bool auth { get; set; }
        }
    }
