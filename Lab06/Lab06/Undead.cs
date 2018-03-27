using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public abstract class Undead : Imaginary
    {
        abstract public string[] SlainBy { get; set; }
        public override string Sustenance()
        {
            return "null";
        }
        public override string Size { get; set; } = "varies by base";
        virtual public string Base { get; set; } = "Human";
        virtual public string Basis()
        {
            return $"this was once a living {Base}";
        }
    }
}
