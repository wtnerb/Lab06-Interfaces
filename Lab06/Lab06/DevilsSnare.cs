using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class DevilsSnare : Plant
    {
        public override string Size { get; set; } = "large shrubbery";
        public override string Sustenance()
        {
            return "Animal flesh";
        }
        public override string Source()
        {
            return "Harry Potter and the Philosopher's Stone (1997) by J. K. Rowling";
        }
    }
}
