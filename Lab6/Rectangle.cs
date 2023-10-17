using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Rectangle
    {
        int height;
        int width;
        string color;
        public Rectangle(int height, int width, string color)
        {
            this.height = height;
            this.width = width;
            this.color = color;
        }
        private int Area()
        {
            return height * width;
        }
        private bool isValid()
        {
            return Area() > 0;
        }
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
           // Console.ForegroundColor = color;
        }
    }
}
