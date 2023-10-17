using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Runner
    {
        string name;
        int startNumber;
        int speed;
        int distance;

        public Runner(string name, int startNumber, int speed)
        {
            this.name = name;
            this.startNumber = startNumber;
            this.speed = speed;
            this.distance = 0;
        }
        public void RefreshDistance(int timeInSeconds)
        {
            int newDistance = speed * timeInSeconds;
            distance += newDistance;
        }
        public void Show()
        {
            int x = distance;
            int y = startNumber;
            Console.SetCursorPosition(x, y);
            Console.Write(name[0]);
        }
        public int GetDistance()
        {
            return distance;
        }
    }
}
