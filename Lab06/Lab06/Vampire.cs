using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Vampire : Sentient_Undead
    {
        public override string[] Weaknesses { get; set; } = { "garlic", "sunlight", "holy symbols" };
        public override string Name { get; set; }
        public Vampire (string name)
        {
            Name = name;
        }

        public override string Sustenance()
        {
            return "Blood";
        }
        public override string Source()
        {
            return "Dracula (1897) by Bram Stoker";
        }
        public override string[] SlainBy { get; set; } = { "wooden stake", "fire", "sunlight" };
        public override string Speak()
        {
            return "I vant to drink your blood";
        }
    }
}
