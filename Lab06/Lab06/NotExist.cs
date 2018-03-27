using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public abstract class Imaginary
    {
        public bool Exists = false;
        abstract public string Sustenance();
        abstract public string Size { get; set; }
        abstract public string Source();
    }
}
