using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Database
{
    public class Member
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }

        public string City { get; set; }

        public List<Workoutclass> workoutclasses { get; set; }

        public Member(int id, string name, int age, string phonenumber, string city)
        {
            Id = id;
            Name = name;
            Age = age;
            Phonenumber = phonenumber;
            City = city;
            workoutclasses = new List<Workoutclass>();
            
        }



    }
}
