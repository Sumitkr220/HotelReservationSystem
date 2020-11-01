using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationsystem
{
    public class DateValidation
    {
        public DateTime[] ValidateDates(string[] enteredDates)
        {
            if (enteredDates == null)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.NULL_DATES, "Dates are null");
            }
            DateTime[] datesValidated = new DateTime[enteredDates.Length];

            for (int i = 0; i < enteredDates.Length; i++)
            {
                DateTime date = ConvertToDate(enteredDates[i]);
                if (date < DateTime.Today)
                {
                    throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE, "Dates are invalid");
                }
                datesValidated[i] = date;
            }
            return datesValidated;
        }
        public DateTime ConvertToDate(string enteredDate)
        {
            DateTime date;
            if (DateTime.TryParse(enteredDate, out date))
            {
                return date;
            }
            else
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE_FORMAT, "Date format is Invalid");
            }
        }
    }
}
