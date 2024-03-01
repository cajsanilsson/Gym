namespace Gym_Database
{
    partial class WorkoutClassManager
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
            label1 = new Label();
            label2 = new Label();
            joinButton = new Button();
            button1 = new Button();
            membersCombobox = new ComboBox();
            workoutclassesCombobox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(236, 38);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 0;
            label1.Text = "Workoutclasses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(169, 93);
            label2.Name = "label2";
            label2.Size = new Size(313, 20);
            label2.TabIndex = 3;
            label2.Text = "Chose member and what workoutclass to join.";
            // 
            // joinButton
            // 
            joinButton.Location = new Point(282, 337);
            joinButton.Name = "joinButton";
            joinButton.Size = new Size(94, 29);
            joinButton.TabIndex = 4;
            joinButton.Text = "Join class";
            joinButton.UseVisualStyleBackColor = true;
            joinButton.Click += joinButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 371);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // membersCombobox
            // 
            membersCombobox.FormattingEnabled = true;
            membersCombobox.Location = new Point(119, 171);
            membersCombobox.Name = "membersCombobox";
            membersCombobox.Size = new Size(151, 28);
            membersCombobox.TabIndex = 6;
            // 
            // workoutclassesCombobox
            // 
            workoutclassesCombobox.FormattingEnabled = true;
            workoutclassesCombobox.Location = new Point(401, 171);
            workoutclassesCombobox.Name = "workoutclassesCombobox";
            workoutclassesCombobox.Size = new Size(151, 28);
            workoutclassesCombobox.TabIndex = 7;
            // 
            // WorkoutClassManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(680, 428);
            Controls.Add(workoutclassesCombobox);
            Controls.Add(membersCombobox);
            Controls.Add(button1);
            Controls.Add(joinButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WorkoutClassManager";
            Text = "WorkoutClassManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button joinButton;
        private Button button1;
        private ComboBox membersCombobox;
        private ComboBox workoutclassesCombobox;
    }
}