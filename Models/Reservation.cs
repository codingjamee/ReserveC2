using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class Reservation
    {
        public RoomId RoomId
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
    }
}
