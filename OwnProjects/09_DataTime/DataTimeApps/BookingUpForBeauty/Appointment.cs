using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingUpForBeauty
{
    public static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            var Datetime = DateTime.Parse(appointmentDateDescription);
            return Datetime;
        }

        public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

        public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour > 12 && appointmentDate.Hour<18;

        public static string Description(DateTime appointmentDate)
        {
            return $"You have an appointment on {appointmentDate:G}";
        }

        public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
