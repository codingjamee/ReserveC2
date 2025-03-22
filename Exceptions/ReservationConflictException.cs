﻿using Reservoom2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom2.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation
        {
            get;
        } 
        public Reservation IncomingReservation
        {
            get;
        }
        public ReservationConflictException(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string message) : base(message)
        {
        }

        public ReservationConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReservationConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
