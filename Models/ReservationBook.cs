using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class ReservationBook
    {
        private readonly Dictionary<RoomId, List<Reservation>> _roomsToReservations;

        public ReservationBook()
        {
            _roomsToReservations = new Dictionary<RoomId, List<Reservation>>();
        }
    }
}
