using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicLibrary.Components
{
    public class Rectangle
    {
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string GetInfo()
        {
            return String.Format("Position: X: {0}, Y: {1}, Width: {2}, Height: {3}", X, Y, Width, Height);
        }

        private int X;
        private int Y;
        private int Height;
        private int Width;
    }
}
