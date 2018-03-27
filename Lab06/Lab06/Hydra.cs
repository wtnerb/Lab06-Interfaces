using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Hydra : Lizard
    {
        public override byte Heads { get; set; } = 9;
        public override string Sustenance()
        {
            return "Whatever it wants, really";
        }
        public override string Source()
        {
            return "Theogony (circa 700 BCE) by Hesiod";
        }
        public override string Size { get; set; } = "Giant";
        public override string Locomotion()
        {
            string str = "Swim/Run";
            Console.WriteLine(str);
            return str;
        }
        public string CutOffHead(string use)
        {
            if ((use.ToLower() == "fire" || use.ToLower() == "hydra poison") && Heads > 0)
            {
                if (Heads > 1)
                {
                Heads--;
                return $"Clever adventurer, the hydra now has {Heads} heads remaining";
                }
                else
                {
                    return "Victory, the hydra is slain!";
                }
            }
            else
            {
                Heads++;
                return "Two grow back!";
            }
        }
    }
}
