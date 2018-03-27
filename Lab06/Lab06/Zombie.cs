using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Zombie : Undead
    {

        public override string Sustenance()
        {
            return "BRAINS!";
        }
        public override string Source()
        {
            return "Haitian voodoo/folklore";
        }
        public override string Base { get; set; } = "Typically human";
        public override string[] SlainBy { get; set; } = { "Beheading", "Excessive physical trauma" };
    }
}
