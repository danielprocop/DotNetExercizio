using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio.Core
{
    public class Rectangle: IShape 
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override string ToString()
        {
            return $"The Rectangle has Height: {Height} and Width: {Width} with area: {Height * Width}";
        }
    }
}
