using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Lich : Sentient_Undead, ISpeak, ISpellcaster
    {
        public override string Source()
        {
            return "Sword and The Sorcerer (1969) by Gardner Fox";
        }
        public override string[] Weaknesses { get; set; } = { "Phylactery" };
        public Lich (string name)
        {
            Name = name;
        }
        public override string[] SlainBy { get; set; } = { "Phylactery destruction" };

        public override string Name { get; set; }
        public string Speak()
        {
            return "Death is an obstacle. Fail to overcome it and face oblivion.";
        }
        public string UseMagic()
        {
            return "Avada Kedavra";
        }
    }
}
