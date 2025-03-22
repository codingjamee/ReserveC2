using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class Hotel
    {
        private string Name {
            get;
        }
        private readonly ReservationBook _reservationBook;

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();

        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservationBook.GetReservationsForUser(username);
        }

        /// <summary>
        /// Make a Reservation.
        /// </summary>
        /// <exception cref="ReservationConflictException">
        /// <param name="reservation"></param>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
