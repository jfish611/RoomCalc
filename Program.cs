using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthInput;
            double widthInput;

            double area;
            double perimeter;

            Console.WriteLine("Hello. This application will ask for several measurements of your room, and then tell you the area and perimeter of your room.");
            while (true)
            {
                Console.WriteLine("Please enter your rooms's length in feet.");
                double.TryParse(Console.ReadLine(), out lengthInput);

                Console.WriteLine("Please enter your room's width in feet.");
                double.TryParse(Console.ReadLine(), out widthInput);
                Console.WriteLine("\n \n  ______________Results___________");
                Console.WriteLine("Room length: " + lengthInput.ToString() + "feet");
                Console.WriteLine("Room width: " + widthInput.ToString() + "feet.");

                var myAreaCalculator = new AreaCalculator();
                area = myAreaCalculator.AreaCalc(lengthInput, widthInput);
                string areaType = area.ToString("F2");
                Console.WriteLine("The area of this room is: " + areaType + "square feet");

                var myPerimeterCalculator = new PerimeterCalculator();

                perimeter = myPerimeterCalculator.PerimCalc(lengthInput, widthInput);
                string perimType = perimeter.ToString("F2");
                Console.WriteLine($"The perimeter of your room is {perimType} feet.");
                Console.WriteLine("Press 'N' to exit, otherwise any button to continue.");
                if(Console.ReadLine().ToLower() == "n")
                {
                    break;
                }

            }

        }
    }
}