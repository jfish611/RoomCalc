using System;
using System.Collections.Generic;
using System.Text;



namespace RoomCalculator
{
    public class AreaCalculator
    {
        double Length;
        double Width;
        double Area;

        public double AreaCalc (double lengthInput, double widthInput)
        {
            this.Length = lengthInput;
            this.Width = widthInput;
          
                Area = Length * Width;

                return Area;

        }
    }
        
}
