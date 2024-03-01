using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Database
{
    public class Workoutclass
    {
        //Values for Workoutclass.
        public int WorkoutClass_Id { get; set; }

        public string WorkoutClass_Name { get; set; }

        public List<Member> Members { get; set; }

        //Constructor for Workoutclass.
        public Workoutclass(int workoutClass_id, string workoutClass_name)
        {
            WorkoutClass_Id = workoutClass_id;

            WorkoutClass_Name = workoutClass_name;


        }
    }
}
