using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int Id_Patients { get; set; }
        public int Id_Doctor { get; set; }
        public DateTime Date_Appointment { get; set; }
        public string Cause { get; set; }
        public int StatusAppointment { get; set; }



    }
}
