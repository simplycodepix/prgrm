using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_lab_06
{
    class Exercise2
    {
        public Exercise2()
        {
            List<Room> rooms = new List<Room>();

            rooms.Add(new Room(3, 2, 10));
            rooms.Add(new Room(1, 4, 6));
            rooms.Add(new Room(8, 4, 15));
            rooms.Add(new Room(2, 7, 3));
            rooms.Sort();

            foreach (Room room in rooms)
            {
                room.PrintInfo();
            }

            Console.WriteLine(Environment.NewLine);
            rooms.Sort(new RoomComparerByWindows());

            foreach (Room room in rooms)
            {
                room.PrintInfo();
            }
        }
    }
}
