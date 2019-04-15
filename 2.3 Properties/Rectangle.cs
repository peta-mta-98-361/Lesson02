using System;
using System.Collections.Generic;
using System.Text;

namespace _2._3_Properties
{
    class Rectangle
    {
        //These are the backing fields for the properties that expose them

        private double length;
        private double width;

        public double Length
        {
            get
            {
                //Primarily this returns the value for the data field 'length'

                return length;
            }
            set
            {
                //This checks that the value assigned is positive
                //Uses the 'value' keyword
                //Modifies the 'length' field only if the result is positive

                if (value > 0.0)
                    length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                    width = value;
            }
        }


        //Constructor
        //Note how the name of the constructor and the class must match precisely
        //There is only one way to create the Rectangle, by calling a constructor with two arguments of double
        //This constructor is no longer required
        //public Rectangle(double l, double w)
        //{
        //    length = l;
        //    width = w;
        //}

        //Method
        public double GetArea()
        {
            return length * width;
        }
    }
}
