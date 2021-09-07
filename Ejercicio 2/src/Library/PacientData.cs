using System;
using System.Text;

namespace PacientDatao
{
    public class PacientData
    {
        public string Name{get; set;}
        public string Id{get; set;}
        public string PhoneNumber{get; set;}
        public DateTime Date{get; set;}
        public int Age{get; set;}

        public PacientData(string name, string id, string phoneNumber, DateTime date, int age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.Age = age;
        }
        public string IsValidPacientData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.Id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(this.PhoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (this.Age < 0)
            {
                stringBuilder.Append("Unable to schedule appointment, age is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}