namespace Gym_Database
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UsernameTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            LoginLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            menuPanel = new Panel();
            workoutClassLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            logOutLabel = new Label();
            menuLabel = new Label();
            membersLabel = new Label();
            newMemberLabel = new Label();
            welcomeLabel = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(202, 356);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.PlaceholderText = "Username";
            UsernameTextbox.Size = new Size(125, 27);
            UsernameTextbox.TabIndex = 1;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(202, 433);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '*';
            PasswordTextbox.PlaceholderText = "Password";
            PasswordTextbox.Size = new Size(125, 27);
            PasswordTextbox.TabIndex = 2;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BorderStyle = BorderStyle.FixedSingle;
            LoginLabel.Font = new Font("Franklin Gothic Medium", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(222, 509);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(83, 31);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "LOG IN";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 279);
            label1.Name = "label1";
            label1.Size = new Size(441, 20);
            label1.TabIndex = 4;
            label1.Text = "________________________________________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 581);
            label2.Name = "label2";
            label2.Size = new Size(441, 20);
            label2.TabIndex = 5;
            label2.Text = "________________________________________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(383, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuPanel
            // 
            menuPanel.Controls.Add(workoutClassLabel);
            menuPanel.Controls.Add(label4);
            menuPanel.Controls.Add(label3);
            menuPanel.Controls.Add(logOutLabel);
            menuPanel.Controls.Add(menuLabel);
            menuPanel.Controls.Add(membersLabel);
            menuPanel.Controls.Add(newMemberLabel);
            menuPanel.Controls.Add(welcomeLabel);
            menuPanel.Controls.Add(pictureBox2);
            menuPanel.Location = new Point(12, 12);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(520, 615);
            menuPanel.TabIndex = 8;
            menuPanel.Visible = false;
            // 
            // workoutClassLabel
            // 
            workoutClassLabel.AutoSize = true;
            workoutClassLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            workoutClassLabel.ForeColor = SystemColors.ControlLightLight;
            workoutClassLabel.Location = new Point(178, 344);
            workoutClassLabel.Name = "workoutClassLabel";
            workoutClassLabel.Size = new Size(153, 28);
            workoutClassLabel.TabIndex = 12;
            workoutClassLabel.Text = "Workoutclasses";
            workoutClassLabel.Click += workoutClassLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(82, 477);
            label4.Name = "label4";
            label4.Size = new Size(357, 20);
            label4.TabIndex = 11;
            label4.Text = "__________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(82, 70);
            label3.Name = "label3";
            label3.Size = new Size(357, 20);
            label3.TabIndex = 10;
            label3.Text = "__________________________________________________________";
            // 
            // logOutLabel
            // 
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            logOutLabel.ForeColor = SystemColors.ControlLightLight;
            logOutLabel.Location = new Point(210, 417);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(83, 28);
            logOutLabel.TabIndex = 9;
            logOutLabel.Text = "Log out";
            logOutLabel.Click += logOutLabel_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuLabel.ForeColor = SystemColors.ControlLightLight;
            menuLabel.Location = new Point(190, 99);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(140, 54);
            menuLabel.TabIndex = 6;
            menuLabel.Text = "MENU";
            // 
            // membersLabel
            // 
            membersLabel.AutoSize = true;
            membersLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            membersLabel.ForeColor = SystemColors.ControlLightLight;
            membersLabel.Location = new Point(210, 209);
            membersLabel.Name = "membersLabel";
            membersLabel.Size = new Size(98, 28);
            membersLabel.TabIndex = 5;
            membersLabel.Text = "Members";
            membersLabel.Click += membersLabel_Click;
            // 
            // newMemberLabel
            // 
            newMemberLabel.AutoSize = true;
            newMemberLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newMemberLabel.ForeColor = SystemColors.ControlLightLight;
            newMemberLabel.Location = new Point(190, 277);
            newMemberLabel.Name = "newMemberLabel";
            newMemberLabel.Size = new Size(136, 28);
            newMemberLabel.TabIndex = 4;
            newMemberLabel.Text = "New member";
            newMemberLabel.Click += newMemberLabel_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = SystemColors.ControlLightLight;
            welcomeLabel.Location = new Point(178, 31);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(66, 28);
            welcomeLabel.TabIndex = 2;
            welcomeLabel.Text = "label3";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(218, 525);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(544, 656);
            Controls.Add(menuPanel);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UsernameTextbox;
        private TextBox PasswordTextbox;
        private Label LoginLabel;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label WelcomeLabel;
        private PictureBox pictureBox2;
        private Label welcomeLabel;
        private Label menuLabel;
        private Label membersLabel;
        private Label newMemberLabel;
        private Label logOutLabel;
        private Label label4;
        private Label label3;
        private Label workoutClassLabel;
        public Panel menuPanel;
    }
}
