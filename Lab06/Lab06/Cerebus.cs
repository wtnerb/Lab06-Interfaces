using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Cerberus : Mammal
    {
        public override byte Heads { get; set; } = 3;
        public override string Size { get; set; } = "Large";
        public override string Sustenance()
        {
            return "Raw flesh";
        }
        public override string Source()
        {
            return "Theogony (circa 700 BCE) by Hesiod";
        }
        public override string Locomotion()
        {
            return "Run";
        }
    }
}
