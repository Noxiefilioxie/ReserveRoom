using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Models
{
   public class Reservation
    {
        public Reservation(RoomId roomId, DateTime startTime, DateTime endTime, string userName)
        {
            RoomId = roomId;
            StartTime = startTime;
            EndTime = endTime;
            UserName = userName;
        }
   

        public RoomId RoomId { get;}
        public string UserName { get;}
        public DateTime StartTime { get;}
        public DateTime EndTime { get;}
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public bool Conflicts(Reservation reservation)
        {
            if(!reservation.RoomId.Equals(RoomId))
            {
                return false;
            }
            return reservation.StartTime < EndTime && reservation.EndTime < StartTime;

        }
    }
}
