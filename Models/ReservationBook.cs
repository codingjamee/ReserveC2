using Reservoom2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservationBook;

        public ReservationBook()
        {
            _reservationBook = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook;
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservationBook)
            {
                if(existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }
            _reservationBook.Add(reservation);
        }
    }
}
