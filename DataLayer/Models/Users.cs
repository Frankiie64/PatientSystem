using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public string Pass { get; set; }         
        public int TypeUsers { get; set; }

    }
}
