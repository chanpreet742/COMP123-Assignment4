using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Chanpreet Mudhar
 * Student Number - 300932732
 * Date: July 28, 2017
 * Description: This is a class called 'GiantPlanet' which is a subclass of the 'Planet' abstract class.
 * Version: 0.2 - Added WaitForKey method and declared objects.
 * Link: https://github.com/chanpreet742/COMP123-Assignment4 
 */
namespace COMP123_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet planet1 = new GiantPlanet("Mars", 6779, 6.39 * Math.Pow(10, 23), "Gas");
            TerrestrialPlanet planet2 = new TerrestrialPlanet("Mercury", 4879, 3.285 * Math.Pow(10, 23), false);

            Console.WriteLine(planet1.ToString());
            Console.WriteLine(planet2.ToString());

            WaitForAnyKey();
        }
        /// <summary>
        /// This method reads the console for any key press before the console is closed.
        /// </summary>
        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
