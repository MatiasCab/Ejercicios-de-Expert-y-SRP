using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService appointmentResult =  new  AppointmentService(new PacientData("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "23"),new DoctorData ("Wall Street", "Armand", "hola"));
            Console.WriteLine(appointmentResult.Appointment());

            AppointmentService appointmentResult2 = new AppointmentService(new PacientData("Ralf Manson", "", "5555-555-555", DateTime.Now, "12"), new DoctorData("Queen Street", "H", "fee"));
            Console.WriteLine(appointmentResult2.Appointment());
        }
    }
}
