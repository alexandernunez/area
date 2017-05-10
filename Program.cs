using System;

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