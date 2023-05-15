using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
    public class RoomId
    {
        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public int FloorNumber { get; }
        public int RoomNumber { get; }


        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }


        public override bool Equals(object? obj)
        {
            return obj is RoomId roomId &&
                FloorNumber == roomId.FloorNumber &&
                RoomNumber == roomId.RoomNumber;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
    }
}
