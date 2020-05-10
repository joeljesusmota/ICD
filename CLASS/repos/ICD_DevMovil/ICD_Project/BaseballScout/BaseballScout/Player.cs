using System;
using System.Collections.Generic;
using System.Text;

namespace BaseballScout
{
    public class Player
    {
        public string Name { get; set; }
        public int Classification { get; set; }
        public string Categorie { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
