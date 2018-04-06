using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragon smaug = new Dragon();
            Lich xykon = new Lich("Xykon");
            Console.WriteLine("the dragon worked his spell and incanted:");
            ConsoleMagic(smaug);
            Console.WriteLine();
            Console.WriteLine("The lich cackled at your foolish naivette and explained:");
            ConsoleRant(xykon);
            Console.ReadKey();
        }

        /// <summary>
        /// The entity of a class that implements ISpellcaster casts a spell and prints it to the console.
        /// </summary>
        /// <param name="mage">The instance of a spellcaster who is printing to the console.</param>
        static void ConsoleMagic (ISpellcaster mage)
        {
            Console.WriteLine(mage.UseMagic());
        }

        /// <summary>
        /// Many of my creatures like to talk at length. Those who have the ability implement ISpeak.
        /// This takes their ranting and prints it to the console.
        /// </summary>
        /// <param name="loudly">a badly named parameter. This is an instance of a class that implements ISpeak and this specific instance will be speaking.</param>
        static void ConsoleRant (ISpeak loudly)
        {
            Console.WriteLine(loudly.Speak());
        }
    }
}
