using System;
//Alexander Nunez

// 1. You're tasked with creating some software that should be able to calculate the area of a rectangle. Write a single function that accepts 2 integer parameters and return the calculated area as an integer. In your Main function, call your area function passing in same sample data to test that your function works. You will be required to print the result of your calculation to the screen.
namespace area
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Rectangle area calculator");

            Console.WriteLine("Please input the width of the rectangle (without decimals)");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the height of the rectangle (without decimals)");
            int height = int.Parse(Console.ReadLine());
            
            //This calls the area function
            int Area = area(width, height);

            Console.WriteLine("The area of the rectangle is: "+Area);            
        }

        private static int area(int width, int height)
        {
            return (width * height);
        }
    }
}