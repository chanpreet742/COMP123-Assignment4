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
 * Version: 0.2- Implemented HasMoons() and HasRings() method
 */
namespace COMP123_Assignment4
{
    // This is the GiantPlanet class

    class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        // PRIVATE FIELDS (Instance Variables) ~~~~~~~~~~
        string _type;

        // CONSTRUCTORS ~~~~~~~~~~~~
        /// <summary>
        /// This is the public constructor of the GiantPlanet class
        /// It takes four arguments-
        /// -name(string)
        /// -diameter(double)
        /// -mass(double)
        /// -type(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(String name,double diameter,double mass,string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }
        public bool HasMoons()
        {
            if (MoonCount > 0)
            
                return true;

                else

                return false;
            
        }
        public bool HasRings()
        {
            if (RingCount > 0)
                return true;
            else
                return false;
        }


    }
}