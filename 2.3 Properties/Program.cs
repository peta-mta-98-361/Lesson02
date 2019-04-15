using System;

namespace _2._3_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //There is no explicit constructor
            //As such the default constructor is used and properties are used to initialise class data

            Rectangle rect = new Rectangle();

            //Now you can use the new constructor to populate the private fields using a public property
            //The main method is using the properties 'Length' and 'Width' to set data
            //Setting it to a negative value will result in it being ignored
            //As such the data fields would retain their defaults of zero - 0

            //You can exclude the get or set accessor
            //If you don't include the set accessor, you don't provide a way to set the property value
            //It becomes a read-only property
            //If you don't include the get accessor, you can't get the value of the property
            //It becomes a write-only property  

            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle : {0}", area);
        }
    }
}
