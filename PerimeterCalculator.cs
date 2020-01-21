using System;
using System.Collections.Generic;
using System.Text;

namespace RoomCalculator
{
    public class PerimeterCalculator
    {
        double Length;
        double Width;
        double Perimeter;
       public double PerimCalc(double lengthInput, double widthInput)
        {
            this.Length = lengthInput;
            this.Width = widthInput;
            Perimeter = (Length * 2) + (Width * 2);
            return Perimeter;
        }

    }
}
