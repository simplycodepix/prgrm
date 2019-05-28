using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_06
{
    class Room : IComparable<Room>
    {
        protected double width, length;
        protected int windowsCount;
        public Room(double width, double length, int windowsCount)
        {
            this.width = width;
            this.length = length;
            this.windowsCount = windowsCount;
        }
        public double Area()
        {
            return Math.Round(width * length, 2);
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Room's width = {width}, length = {length}, windows = {windowsCount} and Area = {Area()}");
        }
        public int CompareTo(Room obj)
        {
            return this.Area().CompareTo(obj.Area());
        }
        public int GetWindowsCount() { return this.windowsCount; }
    }

    class RoomComparerByWindows : IComparer<Room>
    {
        public int Compare(Room x, Room y)
        {
            return x.GetWindowsCount().CompareTo(y.GetWindowsCount());
        }
    }
}
