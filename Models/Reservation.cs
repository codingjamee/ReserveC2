﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Models
{
    public class Reservation
    {
        public Reservation(RoomId roomId, string username, DateTime startDate, DateTime endDate)
        {
            RoomId = roomId;
            Username = username;
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

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomId != RoomId)
            {
                return false;
            }

            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
