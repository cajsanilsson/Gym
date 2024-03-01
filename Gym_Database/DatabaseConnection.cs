//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Gym_Database;
using MySql.Data.MySqlClient;

namespace Gym_Database
{
    public class DatabaseConnection
    {
        //Creating connectionstring.
        string server = "localhost"; 
        string database = "Gym_Database"; 
        string username = ""; 
        string password = ""; 

        string connectionString = "";

        
        //Constructor for connectionstring with all it´s values.
        public DatabaseConnection(string server, string database, string username, string password)
        {
            
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
           
        }

        public DatabaseConnection()
        {
            connectionString =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";
            connectionString = "SERVER=localhost;DATABASE=Gym_Database;UID=;PASSWORD=;";
            
        }

        
        //Gets workoutclasses from database.
        public Dictionary<int, Workoutclass> GetWorkoutclasses() 
        {
           Dictionary<int, Workoutclass> workoutclass = new Dictionary<int, Workoutclass>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM Workoutclasses";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);


            // Execute the comman.
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                // Creates the object and adds it to the dictionary.
                Workoutclass workoutclasses = new Workoutclass((int)reader["Workoutclass_Id"], (string)reader["workoutclass_Name"]);
                workoutclass.Add(workoutclasses.WorkoutClass_Id, workoutclasses);

            }

            mySqlConnection.Close();

            return workoutclass;

        }


        //DATABASE CONNECTION TO GET MEMBER DATA.
        public Dictionary<int, Member> GetMembers()
        {
            Dictionary<int, Member> members = new Dictionary<int, Member>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            //Command SELECT * FROM members
            string query = "SELECT * FROM Members";

            
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            
            // Execute the comman.
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                // Creates the object and adds it to the dictionary.
                Member member = new Member((int)reader["Member_Id"], (string)reader["Member_Name"], (int)reader["Member_Age"], (string)reader["Member_Phonenumber"], (string)reader["Member_City"]);
                members.Add(member.Id, member);
                
            }

            mySqlConnection.Close();
            
            return members;
        }


        //DATABASE CONNECTION TO SAVE NEW MEMBERS.
        public Member AddNewMember(string name, int age, string phonenumber, string city)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

            mySqlConnection.Open();


            string query = "CALL create_member(@name, @age, @phonenumber, @city)";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

           
            mySqlCommand.Parameters.AddWithValue("@name", name);
            mySqlCommand.Parameters.AddWithValue("@age", age);
            mySqlCommand.Parameters.AddWithValue("@phonenumber", phonenumber);
            mySqlCommand.Parameters.AddWithValue("@city", city);
           
            int memberId = Convert.ToInt32(mySqlCommand.ExecuteScalar());

           
            Member member = new Member(memberId, name, age, phonenumber, city);

            mySqlConnection.Close();

            return member;
        }

        //Calls stored procedure to delete member from database.
        public void DeleteMember(int memberId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("DeleteMember", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Calls stored procedure to update member in database.
        public void UpdateMember(int memberId, string newName, int newAge, string newPhoneNumber, string newCity)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand("UpdateMember", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@memberId", memberId);
                    cmd.Parameters.AddWithValue("@newName", newName);
                    cmd.Parameters.AddWithValue("@newAge", newAge);
                    cmd.Parameters.AddWithValue("@newPhoneNumber", newPhoneNumber);
                    cmd.Parameters.AddWithValue("@newCity", newCity);
                   

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Searches in database for member by their name.
        public Dictionary<int, Member> SearchMembersByName(string searchName)
        {
            Dictionary<int, Member> searchResults = new Dictionary<int, Member>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT * FROM Members WHERE Member_Name LIKE @searchName";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Member member = new Member((int)reader["Member_Id"], (string)reader["Member_Name"], (int)reader["Member_Age"], (string)reader["Member_Phonenumber"], (string)reader["Member_City"]);
                    searchResults.Add(member.Id, member);
                }
            }

            return searchResults;
            
        }


        
        public int GetGymclassIdByName(string gymclassName)
        {
            int gymclassId = 0; 

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT Workoutclass_Id FROM Workoutclasses WHERE Workoutclass_Name = @gymclassName";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.Parameters.AddWithValue("@gymclassName", gymclassName);

                object result = mySqlCommand.ExecuteScalar();

                if (result != null)
                {
                    gymclassId = Convert.ToInt32(result);
                }
            }

            return gymclassId;
        }

        //Gets staff from database.
        public Dictionary<int, Staff> GetStaff()
        {
            Dictionary<int, Staff> staffs = new Dictionary<int, Staff>();

            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string query = "SELECT * FROM Staff";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Staff staff = new Staff((int)reader["Staff_Id"], (string)reader["Staff_Name"], (string)reader["Staff_Email"], (string)reader["Staff_Password"]);
                staffs.Add(staff.Id, staff);
            }

            mySqlConnection.Close();

            return staffs;
        }

        //Join for members and workoutclasses. Gör funktion i workoutclassmanager.
        public List<Workoutclass> GetClassForMember(int id)
        {

            List<Workoutclass> workoutclasses = new List<Workoutclass>();

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string query = "SELECT Workoutclasses.* FROM Workoutclasses " +
                               "JOIN member_workoutclass ON Workoutclasses.Workoutclass_Id = member_workoutclass.Workoutclass_id " +
                               "WHERE member_workoutclass.Member_id = @memberId";

                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@memberId", id);

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Workoutclass workoutclass = new Workoutclass((int)reader["Workoutclass_Id"], (string)reader["Workoutclass_Name"]);
                    workoutclasses.Add(workoutclass);
                }
            }

            return workoutclasses;
         
        }

        //Updates the view that shows members and their gymclasses.
        public void UpdateMembersWithClassView()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                string updateViewQuery = "CREATE OR REPLACE VIEW members_with_class AS " +
                                        "SELECT Members.Member_Id, Members.Member_Name, Members.Member_Age, " +
                                        "Members.Member_Phonenumber, Members.Member_City, " +
                                        "member_workoutclass1.Workoutclass_id " +
                                        "FROM Members " +
                                        "JOIN member_workoutclass1 ON Members.Member_Id = member_workoutclass1.Member_id " +
                                        "JOIN Workoutclasses ON member_workoutclass1.Workoutclass_id = Workoutclasses.Workoutclass_Id";

                MySqlCommand updateViewCommand = new MySqlCommand(updateViewQuery, mySqlConnection);
                updateViewCommand.ExecuteNonQuery();
            }
        }


        //Joins member and the gymclass of choice together in linktable.
        public void JoinMemberToWorkoutClass(int memberId, int workoutclassId)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();

                // Kontrollera om raden redan existerar
                string checkQuery = "SELECT COUNT(*) FROM member_workoutclass1 WHERE Member_id = @memberId AND Workoutclass_id = @workoutclassId";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, mySqlConnection);
                checkCommand.Parameters.AddWithValue("@memberId", memberId);
                checkCommand.Parameters.AddWithValue("@workoutclassId", workoutclassId);

                int existingRows = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingRows == 0)
                {
                    // Lägg bara till om det inte redan finns
                    string insertQuery = "INSERT INTO member_workoutclass1 (Member_id, Workoutclass_id) VALUES (@memberId, @workoutclassId)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, mySqlConnection);
                    insertCommand.Parameters.AddWithValue("@memberId", memberId);
                    insertCommand.Parameters.AddWithValue("@workoutclassId", workoutclassId);

                    insertCommand.ExecuteNonQuery();
                }
                else
                {
                    // Raden existerar redan
                    Console.WriteLine("Denna kombination finns redan i databasen.");
                }
            }
        }
    }

   
}

      


