using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Ent : Plant, ISpeak
    {
        public override string Size { get; set; } = "Large";
        public override string Source()
        {
            return "Lord of the Rings: The Two Towers (1954) by J.R.R. Tolkien";
        }

        public string Speak()
        {
            return "Where have all the Entwives gone?";
        }
    }
}
