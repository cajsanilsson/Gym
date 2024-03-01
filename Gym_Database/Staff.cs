using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Database
{
    public class Staff
    {
        //Staff variables.

        public int Id { get; set; }
        public string Username { get; set; }
        
        public string Email { get; set; }

        public string Password { get; set; }




        //Constructor for Staff.
         
        public Staff(int id, string username, string email, string password) 
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            

        }
    }
}
