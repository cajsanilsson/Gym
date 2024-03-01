using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Database
{
    public partial class WorkoutClassManager : Form
    {
        //Dictionary containing workoutclasses.
        public Dictionary<int, Workoutclass> workoutclass = new Dictionary<int, Workoutclass>();

        //Dictionary containing gym-members.
        public Dictionary<int, Member> members = new Dictionary<int, Member>();

        //Instans of my database connection.
        DatabaseConnection connection = new DatabaseConnection();

        public WorkoutClassManager()
        {
            InitializeComponent();

            workoutclass = connection.GetWorkoutclasses();

            members = connection.GetMembers();

            

            foreach (var member in members.Values)
            {
                membersCombobox.Items.Add(member);
            }

            foreach (var workoutclasses in workoutclass.Values )
            {
                workoutclassesCombobox.Items.Add(workoutclasses);
            }

            membersCombobox.DisplayMember = "Name"; 
            membersCombobox.ValueMember = "Id";

            workoutclassesCombobox.DisplayMember = "WorkoutClass_Name";
            workoutclassesCombobox.ValueMember= "WorkoutClass_Id";


        }

        //Function that let's member join workoutclass.
        private void joinButton_Click(object sender, EventArgs e)
        {
            Member memberToJoin = (Member)membersCombobox.SelectedItem;
            Workoutclass classToJoin = (Workoutclass)workoutclassesCombobox.SelectedItem;

            if (memberToJoin != null && classToJoin != null)
            {
                connection.JoinMemberToWorkoutClass(memberToJoin.Id, classToJoin.WorkoutClass_Id);

                connection.UpdateMembersWithClassView();

                MessageBox.Show(memberToJoin.Name + " has now joined " + classToJoin.WorkoutClass_Name);
            }
            else
            {
                MessageBox.Show("You have to choose a member and a workoutclass to proceed..");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            GymManager gymManager = new GymManager();
            gymManager.Show();
        }
    }
}
