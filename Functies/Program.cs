using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is een uitleg over functies, typ iets in...");
            int intResult = Program.ShowConsoleInfo(Console.ReadLine(), 10);
            Console.WriteLine("De uitkomst van de functie is : " + intResult);
            Console.ReadLine();
        }

        static int ShowConsoleInfo(string strResult, int intGetal, int intMultiplier = 5)
        {
            Console.WriteLine("U heeft ingetikt : " + strResult + " het getal is : " + intGetal);
            Console.WriteLine("Wilt u de multiplier aanpassen ? (y/n)");
            string strAdjustMultiplier = Console.ReadLine();

            if (strAdjustMultiplier == "y")
            {
                Console.WriteLine("Voer uw nieuwe multiplier in : ");
                intMultiplier = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadLine();

            return (intGetal * intMultiplier);
        }

        //return value
    }
}
