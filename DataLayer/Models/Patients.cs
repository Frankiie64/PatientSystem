using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Identification { get; set; }
        public string NatalDay { get; set; }
        public bool Smoker { get; set; }
        public string Allergies { get; set; }
        public string Photo { get; set; }

    }
}
