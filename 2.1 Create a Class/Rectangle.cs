using System;
using System.Collections.Generic;
using System.Text;

namespace _2._1_Create_a_Class
{
    class Rectangle
    {
        private double length;
        private double width;

        //Constructor
        //Note how the name of the constructor and the class must match precisely
        //There is only one way to create the Rectangle, by calling a constructor with two arguments of double
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        //Method
        public double GetArea()
        {
            return length * width;
        }
    }
}
