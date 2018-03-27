using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public abstract class Sentient_Undead : Undead, ISpeak
    {
        abstract public string Name { get; set; }
        abstract public string[] Weaknesses { get; set; }
        virtual public string Speak()
        {
            return "I'm very dead.";
        }
    }
}
