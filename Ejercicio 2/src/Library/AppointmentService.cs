using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private static PacientData Pacient{get; set;}
        private static DoctorData Doctor{get; set;}
        private static int AppoimentCode = 1;
        public AppointmentService(PacientData pacient, DoctorData doctor)
        {
            Pacient = pacient;
            Doctor = doctor;
        }
        public string Appointment()
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            AppoimentCode++;
            stringBuilder.Append(Pacient.IsValidPacientData().Item1);
            stringBuilder.Append(Doctor.IsValidDoctorData().Item1);
            if (Pacient.IsValidPacientData().Item2 & Doctor.IsValidDoctorData().Item2)
            {
                stringBuilder.Append("Appointment schedul");
            }
            return stringBuilder.ToString();

        }

    }
    public class DoctorData
    {
        public string AppoinmentPlace{get; set;}
        public string DoctorName{get; set;}
        public string DoctorEspecialisation{get; set;}

        public DoctorData(string appoinmentPlace, string doctorName, string doctorEspecialisation )
        {
            this.AppoinmentPlace = appoinmentPlace;
            this.DoctorName = doctorName;
            this.DoctorEspecialisation = doctorEspecialisation;
        }
        public Tuple<StringBuilder,Boolean> IsValidDoctorData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Boolean isValid = true;
            if (string.IsNullOrEmpty(AppoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, valid Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, valid Doctor name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(DoctorEspecialisation))
            {
                stringBuilder.Append("Unable to schedule appointment, valid Doctor especialisation is required\n");
                isValid = false;
            }
                if (isValid)
            {
                stringBuilder.Append("Doctor data correct\n");
            }
            Tuple<StringBuilder, Boolean> Valores =new Tuple<StringBuilder, Boolean> (stringBuilder, isValid);
            return Valores;
        }

    }
    public class PacientData
    {
        public string Name{get; set;}
        public string Id{get; set;}
        public string PhoneNumber{get; set;}
        public DateTime Date{get; set;}
        public string Age{get; set;}

        public PacientData(string name, string id, string phoneNumber, DateTime date, string age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.Age = age;
        }
        public Tuple<StringBuilder, Boolean> IsValidPacientData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, valid Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, valid id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, valid Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Age))
            {
                stringBuilder.Append("Unable to schedule appointment, valid age is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Pacient data correct\n");
            }
            Tuple<StringBuilder, Boolean> Valores =new Tuple<StringBuilder, Boolean> (stringBuilder, isValid);
            return Valores;
        }

    }
}

/*Lo que veo de este codigo es que una sola clase posee muchas responsabolidades, ya que ella es la que regula 
los datos del paciente, y tambien los del medico. Asimismo, al tener una sola clase todo las responsabilidad,
a la hora de modificar el programa y agregar nuevas carcateristicas, se hay mas propension a que haya mas de un
solo motivo para cambiarla, por lo que estaria incumpliendo los principios SOLID. */