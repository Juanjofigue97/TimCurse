using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingUpForBeauty
{
    internal class AppointmentComunnity
    {
        static class Appointment
        {
            public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);
            public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;
            public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
            public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";
            public static DateTime AnniversaryDate() => new(DateTime.Today.Year, 09, 15);
        }
    }
}
