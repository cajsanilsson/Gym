

using MySql.Data.MySqlClient;

namespace Gym_Database
{
    public partial class Login : Form
    {
        //Dictionary containing staff.
        public Dictionary<int, Staff> staffs = new Dictionary<int, Staff>();

        //Instanse of my database connection.
        DatabaseConnection connection = new DatabaseConnection();
        public Login()
        {

            InitializeComponent();

            LoadStaffData();
        }

        //Get staff info.
        private void LoadStaffData()
        {
            staffs = connection.GetStaff();
        }

        //Logs in staff.
        private void LoginLabel_Click(object sender, EventArgs e)
        {

            string usernameInput = UsernameTextbox.Text;
            string passwordInput = PasswordTextbox.Text;

            bool loggedIn = false;

            foreach (var staff in staffs.Values)
            {
                if (staff.Email == usernameInput && staff.Password == passwordInput)
                {
                    menuPanel.Visible = true;
                    loggedIn = true;
                    welcomeLabel.Text = ("Welcome " + staff.Username + "!");
                    break;
                }
            }
            if (!loggedIn)
            {
                MessageBox.Show("Wrong email-adress or password, try again.");
            }
        }

        //GENVÄG
        private void button1_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = true;
        }

        //Opens gymManager where you can handle members and hides Login form.
        private void membersLabel_Click(object sender, EventArgs e)
        {
            Hide();
            GymManager gymManager = new GymManager();
            gymManager.Show();
            gymManager.goBackButton.Visible = true;
        }

        //Logs out user and returns to login page.
        private void logOutLabel_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
        }

        //Opens gymManager + panel for creating a new member and hides Login form.
        private void newMemberLabel_Click(object sender, EventArgs e)
        {
            Hide();
            GymManager gymManager = new GymManager();
            gymManager.Show();
            gymManager.idTextbox.Visible = false;
            gymManager.saveUpdatesButton.Visible = false;
            gymManager.saveNewMemberButton.Visible = true;
            gymManager.newMembershipPanel.Visible = true;
            gymManager.updateMemberLabel.Text = "Create new member";
        }

        private void workoutClassLabel_Click(object sender, EventArgs e)
        {
            WorkoutClassManager workoutClassManager = new WorkoutClassManager();
            workoutClassManager.Show();
        }
    }
}
