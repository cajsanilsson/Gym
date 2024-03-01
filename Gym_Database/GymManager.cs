using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gym_Database
{
    public partial class GymManager : Form
    {
        //Dictionary containing gym-members.
        public Dictionary<int, Member> members = new Dictionary<int, Member>();

       

        //Instans of my database connection.
        DatabaseConnection connection = new DatabaseConnection();

        public GymManager()
        {
            InitializeComponent();

           

            members = connection.GetMembers();

           

            foreach (var member in members.Values)
            {
                gymListbox.Items.Add($"ID: {member.Id}, Name: {member.Name}");
            }
        }

        //Function that shows all information about the chosen member
        public void UpdateMemberInfoLabel(string memberInfo)
        {
            memberInfoLabel.Text = memberInfo;
        }

        //Function that lets user search for a member by Id.
        private void searchButton_Click(object sender, EventArgs e)
        {

            string searchInput = searchbarTextbox.Text;

            if (!string.IsNullOrEmpty(searchInput))
            {
                Dictionary<int, Member> searchResults = connection.SearchMembersByName(searchInput);

                gymListbox.Items.Clear();

                foreach (Member member in searchResults.Values)
                {
                    gymListbox.Items.Add($"ID: {member.Id}, Name: {member.Name}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }

        }

        //Function that displays all information about a member.
        private void gymListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            memberInfoLabel.Visible = true;

            if (gymListbox.SelectedIndex != -1)
            {
                string selectedMemberString = gymListbox.SelectedItem.ToString();

                Match match = Regex.Match(selectedMemberString, @"ID: (\d+), Name: (.+)");
                if (match.Success)
                {
                    int selectedMemberId = int.Parse(match.Groups[1].Value);

                    if (members.TryGetValue(selectedMemberId, out Member selectedMember))
                    {
                        memberInfoLabel.Text = $"ID: {selectedMember.Id}{Environment.NewLine}" +
                                               $"Name: {selectedMember.Name}{Environment.NewLine}" +
                                               $"Age: {selectedMember.Age}{Environment.NewLine}" +
                                               $"Phonenumber: {selectedMember.Phonenumber}{Environment.NewLine}" +
                                               $"City: {selectedMember.City}{Environment.NewLine}"; 
                                              //$"Workoutclass: {selectedMember.GymClass}{Environment.NewLine}";
                                             

                        deleteMemberButton.Visible = true;
                        updateMemberButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Member not found in the dictionary.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a member to view.");
                }
            }
            else
            {
                MessageBox.Show("Please select a member to view.");
            }
        }

        //Function to delete member.
        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            if (gymListbox.SelectedIndex != -1)
            {
                string selectedMemberString = gymListbox.SelectedItem.ToString();
                Match match = Regex.Match(selectedMemberString, @"ID: (\d+), Name: (.+)");
                if (match.Success)
                {
                    int selectedMemberId = int.Parse(match.Groups[1].Value);

                   

                    //Calls the DeleteMember function from DatabaseConnection.
                    connection.DeleteMember(selectedMemberId);

                    // Deletes the member from the dictionary.
                    members.Remove(selectedMemberId);

                    // Deletes the member from listbox.
                    gymListbox.Items.RemoveAt(gymListbox.SelectedIndex);

                    MessageBox.Show("Member deleted.");
                }
                else
                {
                    MessageBox.Show("Select a member to delete.");
                }
            }
            else
            {
                MessageBox.Show("Select a member to delete.");
            }

        }

        //Function to update a members membership.
        private void updateMemberButton_Click(object sender, EventArgs e)
        {
            updateMemberLabel.Text = "Update member";
            newMembershipPanel.Visible = true;
            goBackButton.Visible = false;
            saveNewMemberButton.Visible = false;
            saveUpdatesButton.Visible = true;
            idTextbox.Visible = false;

            if (gymListbox.SelectedIndex != -1)
            {
                string selectedMemberString = gymListbox.SelectedItem.ToString();
               

                Match match = Regex.Match(selectedMemberString, @"ID: (\d+), Name: (.+)");
                
                if (match.Success)
                {
                    int selectedMemberId = int.Parse(match.Groups[1].Value);

                    if (members.TryGetValue(selectedMemberId, out Member selectedMember))
                    {
                        // Populate textboxes with selected member's information
                        idTextbox.Text = selectedMember.Id.ToString();
                        nameTextbox.Text = selectedMember.Name;
                        ageTextbox.Text = selectedMember.Age.ToString();
                        phonenumberTextbox.Text = selectedMember.Phonenumber;
                        cityTextbox.Text = selectedMember.City;
                        //gymClassTextbox.Text = selectedMember.GymClass;
                    }
                    else
                    {
                        MessageBox.Show("Member not found in the dictionary.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a member to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a member to update.");
            }

        }

        //Goes back to GymManagers start view.
        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
            login.menuPanel.Visible = true;
            newMembershipPanel.Visible = false;
            goBackButton.Visible = true;
        }

        //Closes GymManager.
        private void goBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
            login.menuPanel.Visible = true;

        }


        //Function to add a new member.
        private void SaveNewMemberButton_Click(object sender, EventArgs e)
        {
            //Checks that all texboxes required are filled in.
            if (nameTextbox.Text != null && ageTextbox.Text != null && cityTextbox.Text != null && phonenumberTextbox.Text != null) 
            {
                // Converts Id and Age.
                if (int.TryParse(ageTextbox.Text, out int memberAge))
                {
                   
                    //Adds member to database.
                    Member newMember = connection.AddNewMember(nameTextbox.Text, memberAge, phonenumberTextbox.Text, cityTextbox.Text);
                    
                    //Adds member to dictionary.
                    members.Add(newMember.Id, newMember);
                   
                    //Clear textboxes after a new member is added.
                    nameTextbox.Clear();
                    ageTextbox.Clear();
                    cityTextbox.Clear();
                    phonenumberTextbox.Clear();

                    //Adds member to gymListbox.
                    gymListbox.Items.Add($"ID: {newMember.Id}, Name: {newMember.Name}");

                    MessageBox.Show("Member added.");
                }
                else
                {
                    MessageBox.Show("Invalid Id or Age. Please enter valid integer values.");
                }
            }
        }

        //Updates and saves new information about a member.
        public void saveUpdatesButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextbox.Text, out int selectedMemberId))
            {
                if (members.TryGetValue(selectedMemberId, out Member selectedMember))
                {
                    

                        
                            // Använd newGymClassId direkt i UpdateMember-funktionen för den valda medlemmen
                            connection.UpdateMember(selectedMemberId, nameTextbox.Text, int.Parse(ageTextbox.Text), phonenumberTextbox.Text, cityTextbox.Text);

                            // Uppdatera även det lokala objektet
                            //selectedMember.GymClass = newGymClassId.ToString();

                            MessageBox.Show("Member updated");
                        
                   
                }
                else
                {
                    MessageBox.Show("Member not found in the dictionary.");
                }
            }
        }
    }
}   
