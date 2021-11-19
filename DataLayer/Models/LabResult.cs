using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class LabResult
    {
        public int Id { get; set; }
        public int Id_Patients { get; set; }
        public int Id_Appointment { get; set; }
        public int Id_LabTest { get; set; }
        public int Id_Doctor { get; set; }
        public string TestResult { get; set; }
        public int StatusResult { get; set; }

    }

}
