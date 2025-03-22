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
    }
}
