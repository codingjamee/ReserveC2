using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class Reservation
    {
        public Reservation(RoomId roomId, string Username, DateTime startDate, DateTime endDate)
        {
            RoomId = roomId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public RoomId RoomId
        {
            get;
        }
        public string Username
        {
            get;
        }
        public DateTime StartDate
        {
            get;
        }
        public DateTime EndDate
        {
            get;
        }
        public TimeSpan Length => EndDate.Subtract(StartDate);
    }
}
