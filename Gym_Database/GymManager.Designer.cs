namespace Gym_Database
{
    partial class GymManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gymListbox = new ListBox();
            label1 = new Label();
            memberInfoLabel = new Label();
            searchbarTextbox = new TextBox();
            updateMemberButton = new Button();
            deleteMemberButton = new Button();
            searchButton = new Button();
            newMembershipPanel = new Panel();
            idTextbox = new TextBox();
            saveUpdatesButton = new Button();
            updateMemberLabel = new Label();
            backButton = new Button();
            saveNewMemberButton = new Button();
            ageTextbox = new TextBox();
            phonenumberTextbox = new TextBox();
            cityTextbox = new TextBox();
            nameTextbox = new TextBox();
            goBackButton = new Button();
            newMembershipPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gymListbox
            // 
            gymListbox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gymListbox.FormattingEnabled = true;
            gymListbox.ItemHeight = 23;
            gymListbox.Location = new Point(144, 143);
            gymListbox.Name = "gymListbox";
            gymListbox.Size = new Size(188, 188);
            gymListbox.TabIndex = 0;
            gymListbox.SelectedIndexChanged += gymListbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(144, 31);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "MEMBERS";
            // 
            // memberInfoLabel
            // 
            memberInfoLabel.AutoSize = true;
            memberInfoLabel.BackColor = SystemColors.WindowText;
            memberInfoLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberInfoLabel.ForeColor = SystemColors.ControlLightLight;
            memberInfoLabel.Location = new Point(372, 143);
            memberInfoLabel.Name = "memberInfoLabel";
            memberInfoLabel.Size = new Size(55, 23);
            memberInfoLabel.TabIndex = 2;
            memberInfoLabel.Text = "label2";
            memberInfoLabel.Visible = false;
            // 
            // searchbarTextbox
            // 
            searchbarTextbox.Location = new Point(144, 94);
            searchbarTextbox.Name = "searchbarTextbox";
            searchbarTextbox.PlaceholderText = "Search by name";
            searchbarTextbox.Size = new Size(188, 27);
            searchbarTextbox.TabIndex = 3;
            // 
            // updateMemberButton
            // 
            updateMemberButton.FlatStyle = FlatStyle.Flat;
            updateMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateMemberButton.ForeColor = SystemColors.ControlLightLight;
            updateMemberButton.Location = new Point(394, 375);
            updateMemberButton.Name = "updateMemberButton";
            updateMemberButton.Size = new Size(145, 29);
            updateMemberButton.TabIndex = 4;
            updateMemberButton.Text = "Update member";
            updateMemberButton.UseVisualStyleBackColor = true;
            updateMemberButton.Visible = false;
            updateMemberButton.Click += updateMemberButton_Click;
            // 
            // deleteMemberButton
            // 
            deleteMemberButton.FlatStyle = FlatStyle.Flat;
            deleteMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMemberButton.ForeColor = SystemColors.ControlLightLight;
            deleteMemberButton.Location = new Point(144, 375);
            deleteMemberButton.Name = "deleteMemberButton";
            deleteMemberButton.Size = new Size(139, 29);
            deleteMemberButton.TabIndex = 5;
            deleteMemberButton.Text = "Delete member";
            deleteMemberButton.UseVisualStyleBackColor = true;
            deleteMemberButton.Visible = false;
            deleteMemberButton.Click += deleteMemberButton_Click;
            // 
            // searchButton
            // 
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.ControlLightLight;
            searchButton.Location = new Point(372, 92);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(92, 29);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // newMembershipPanel
            // 
            newMembershipPanel.Controls.Add(idTextbox);
            newMembershipPanel.Controls.Add(saveUpdatesButton);
            newMembershipPanel.Controls.Add(updateMemberLabel);
            newMembershipPanel.Controls.Add(backButton);
            newMembershipPanel.Controls.Add(saveNewMemberButton);
            newMembershipPanel.Controls.Add(ageTextbox);
            newMembershipPanel.Controls.Add(phonenumberTextbox);
            newMembershipPanel.Controls.Add(cityTextbox);
            newMembershipPanel.Controls.Add(nameTextbox);
            newMembershipPanel.Location = new Point(12, 12);
            newMembershipPanel.Name = "newMembershipPanel";
            newMembershipPanel.Size = new Size(579, 417);
            newMembershipPanel.TabIndex = 7;
            newMembershipPanel.Visible = false;
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(103, 80);
            idTextbox.Name = "idTextbox";
            idTextbox.PlaceholderText = "Id";
            idTextbox.Size = new Size(125, 27);
            idTextbox.TabIndex = 12;
            // 
            // saveUpdatesButton
            // 
            saveUpdatesButton.FlatStyle = FlatStyle.Flat;
            saveUpdatesButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveUpdatesButton.ForeColor = SystemColors.ControlLightLight;
            saveUpdatesButton.Location = new Point(359, 357);
            saveUpdatesButton.Name = "saveUpdatesButton";
            saveUpdatesButton.Size = new Size(157, 29);
            saveUpdatesButton.TabIndex = 10;
            saveUpdatesButton.Text = "Update and save";
            saveUpdatesButton.UseVisualStyleBackColor = true;
            saveUpdatesButton.Visible = false;
            saveUpdatesButton.Click += saveUpdatesButton_Click;
            // 
            // updateMemberLabel
            // 
            updateMemberLabel.AutoSize = true;
            updateMemberLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateMemberLabel.ForeColor = SystemColors.ControlLightLight;
            updateMemberLabel.Location = new Point(172, 19);
            updateMemberLabel.Name = "updateMemberLabel";
            updateMemberLabel.Size = new Size(283, 31);
            updateMemberLabel.TabIndex = 9;
            updateMemberLabel.Text = "New/Update membership";
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(108, 357);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // saveNewMemberButton
            // 
            saveNewMemberButton.FlatStyle = FlatStyle.Flat;
            saveNewMemberButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveNewMemberButton.ForeColor = SystemColors.ControlLightLight;
            saveNewMemberButton.Location = new Point(359, 357);
            saveNewMemberButton.Name = "saveNewMemberButton";
            saveNewMemberButton.Size = new Size(125, 29);
            saveNewMemberButton.TabIndex = 7;
            saveNewMemberButton.Text = "Save ";
            saveNewMemberButton.UseVisualStyleBackColor = true;
            saveNewMemberButton.Visible = false;
            saveNewMemberButton.Click += SaveNewMemberButton_Click;
            // 
            // ageTextbox
            // 
            ageTextbox.Location = new Point(103, 228);
            ageTextbox.Name = "ageTextbox";
            ageTextbox.PlaceholderText = "Age";
            ageTextbox.Size = new Size(125, 27);
            ageTextbox.TabIndex = 4;
            // 
            // phonenumberTextbox
            // 
            phonenumberTextbox.Location = new Point(346, 154);
            phonenumberTextbox.Name = "phonenumberTextbox";
            phonenumberTextbox.PlaceholderText = "Phonenumber";
            phonenumberTextbox.Size = new Size(125, 27);
            phonenumberTextbox.TabIndex = 3;
            // 
            // cityTextbox
            // 
            cityTextbox.Location = new Point(346, 80);
            cityTextbox.Name = "cityTextbox";
            cityTextbox.PlaceholderText = "City";
            cityTextbox.Size = new Size(125, 27);
            cityTextbox.TabIndex = 2;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(103, 154);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.PlaceholderText = "Name";
            nameTextbox.Size = new Size(125, 27);
            nameTextbox.TabIndex = 0;
            // 
            // goBackButton
            // 
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goBackButton.ForeColor = SystemColors.ControlLightLight;
            goBackButton.Location = new Point(38, 375);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(69, 29);
            goBackButton.TabIndex = 8;
            goBackButton.Text = "Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Visible = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // GymManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(603, 441);
            Controls.Add(goBackButton);
            Controls.Add(newMembershipPanel);
            Controls.Add(searchButton);
            Controls.Add(deleteMemberButton);
            Controls.Add(updateMemberButton);
            Controls.Add(searchbarTextbox);
            Controls.Add(memberInfoLabel);
            Controls.Add(label1);
            Controls.Add(gymListbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GymManager";
            Text = "Form1";
            newMembershipPanel.ResumeLayout(false);
            newMembershipPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox gymListbox;
        private Label label1;
        private Label memberInfoLabel;
        private TextBox searchbarTextbox;
        private Button updateMemberButton;
        private Button deleteMemberButton;
        private Button searchButton;
        public Panel newMembershipPanel;
        public Label updateMemberLabel;
        public Button saveNewMemberButton;
        public Button saveUpdatesButton;
        public Button goBackButton;
        public Button backButton;
        public TextBox ageTextbox;
        public TextBox phonenumberTextbox;
        public TextBox cityTextbox;
        public TextBox nameTextbox;
        public TextBox gymClassTextbox;
        public TextBox idTextbox;
        private ListBox workoutclassListbox;
    }
}