using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationsystem
{
    public class HotelReservationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DATE,
            NULL_DATES,
            INVALID_DATE_FORMAT,
        }
        public ExceptionType type;
        public HotelReservationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
