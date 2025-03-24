using Reservoom2.Exceptions;
using Reservoom2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom2
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Famous Hotel");


            try
            {
                hotel.MakeReservation(new Reservation(
                    new RoomId(1, 3),
                    "Some Guest",
                    new DateTime(2025, 1, 1),
                    new DateTime(2025, 1, 3)));

                hotel.MakeReservation(new Reservation(
                   new RoomId(1, 3),
                   "Some Guest",
                   new DateTime(2025, 1, 2),
                   new DateTime(2025, 1, 5)));

            }

            catch (ReservationConflictException ex)
            {

            }
          
            IEnumerable<Reservation> reservations = hotel.GetAllReservations("Some Guest");

            base.OnStartup(e);
        }
    }
}
