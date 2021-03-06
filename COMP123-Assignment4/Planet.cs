﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Chanpreet Mudhar
 * Student Number - 300932732
 * Date: July 28, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 * Version: 0.2 - Implemented the Tostring() method
 * Link: https://github.com/chanpreet742/COMP123-Assignment4 
 */
namespace COMP123_Assignment4
{
    public abstract class Planet
    {
        // PRIVATE FIELDS (Instance Variables) ~~~~~~~~~~
        double _diameter;
        double _mass;
        int _moonCount;
        string _name;
        double _orbitalPeriod;
        int _ringCount;
        double _rotationPeriod;

        // PUBLIC PROPERTIES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public double Diameter
        {
            get
            {
                return this._diameter;
            }

        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this.OrbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //CONSTRUCTORS ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// <summary>
        /// This is the main constructor for the Planet abstract class.
        /// It takes three arguments-
        /// -name(string)
        /// -diameter(double)
        /// -mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        /// <summary>
        /// This is the ToSrtring() method of the Planet class
        /// that displays the Name , Diameter,and Mass of the planet.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" {0} - {1}Km - {2}Kg ", Name, Diameter, Mass);
        }


    }
}
