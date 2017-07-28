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
 * Version: 0.2 - Implemented the HasMoons() and Habitable(() methods.
 * Link: https://github.com/chanpreet742/COMP123-Assignment4 
 */
namespace COMP123_Assignment4
{
    /// <summary>
    /// This is the TerrestrialPlanet class.
    /// </summary>
    class TerrestrialPlanet : Planet,IHabitable,IHasMoons

    {
        // PRIVATE FIELDS(Instance Variables)  ~~~~~~~~~~~~~~~~

        bool _oxygen;
        // CONSTRUCTORS ~~~~~~~~~~~~
        /// <summary>
        /// This is the public constructor of the TerrestrialPlanet class
        /// It takes four arguments-
        /// -name(string)
        /// -diameter(double)
        /// -mass(double)
        /// -oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(String name, double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen= oxygen;
        }
        /// <summary>
        /// This is the HasMoons() method.
        /// It returns true value if the MoonCount is greater than zero
        /// else returns the false value.
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if (MoonCount > 0)

                return true;

            else

                return false;

        }
        /// <summary>
        /// This is the Habitable() method.
        /// It returns true value if the Oxygen instance variable is set to true
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            return _oxygen;
        }


    }
}

