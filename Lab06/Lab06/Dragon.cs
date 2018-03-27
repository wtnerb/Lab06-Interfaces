using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Dragon : Lizard, ISpeak, ISpellcaster
    {
        public override string Sustenance()
        {
            return "Whatever it wants, really";
        }

        public override string Source()
        {
            return "Saint George and the Dragon(6th century ?) by Someone";
        }
        public override string Size { get; set; } = "Giant";
        public override string Locomotion()
        {
            string str = "Fly";
            Console.WriteLine(str);
            return str;
        }
        public string BreathFire()
        {
            string s = "Crispify that!";
            Console.WriteLine(s);
            return s;
        }
        public string Speak()
        {
            return "I am a dragon. Fear my teeth, claws, fire and cunning";
        }
        public string UseMagic()
        {
            return "You are feeling very sleepy. Sleep, mortal, and never awaken.";
        }
    }
}
