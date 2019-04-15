using System;

namespace _2._2_Create_an_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is where you create the Rectangle Object using the new keyword
            //After new is a call to the the appropriate class construtor
            //As this code executes, the object is created in the heap memory and a reference to this memory stored

            Rectangle rect = new Rectangle(10.0, 20.0);

            //From here you can now use the rect object with GetArea() to carry out calculations
            //The value called by GetArea)9 is stored in the variable area
            //Data fields are not accessible here due to being marked private in class definition

            double area = rect.GetArea();

            //Now you output the calculation results

            Console.WriteLine("Area of Rectangle : {0}", area);
        }
    }
}
