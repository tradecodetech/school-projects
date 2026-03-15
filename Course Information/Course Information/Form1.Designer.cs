namespace Course_Information
{
    partial class Form1
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
            this.getCourseButton = new System.Windows.Forms.Button();
            this.roomLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.courseInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.meetingLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.instructorTextBox = new System.Windows.Forms.TextBox();
            this.meetingTimeTextBox = new System.Windows.Forms.TextBox();
            this.courseInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // getCourseButton
            // 
            this.getCourseButton.Location = new System.Drawing.Point(34, 176);
            this.getCourseButton.Name = "getCourseButton";
            this.getCourseButton.Size = new System.Drawing.Size(132, 23);
            this.getCourseButton.TabIndex = 1;
            this.getCourseButton.Text = "Get Course Info";
            this.getCourseButton.UseVisualStyleBackColor = true;
            this.getCourseButton.Click += new System.EventHandler(this.getCourseButton_Click);
            // 
            // roomLabel
            // 
            this.roomLabel.Location = new System.Drawing.Point(6, 29);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(105, 23);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Room Number:";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(31, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(179, 16);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Select a Course Number.";
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 16;
            this.courseListBox.Items.AddRange(new object[] {
            "CS101",
            "CS102",
            "CS103",
            "NT110",
            "CM241"});
            this.courseListBox.Location = new System.Drawing.Point(46, 58);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(120, 84);
            this.courseListBox.TabIndex = 5;
            // 
            // courseInfoGroupBox
            // 
            this.courseInfoGroupBox.Controls.Add(this.meetingTimeTextBox);
            this.courseInfoGroupBox.Controls.Add(this.instructorTextBox);
            this.courseInfoGroupBox.Controls.Add(this.roomTextBox);
            this.courseInfoGroupBox.Controls.Add(this.meetingLabel);
            this.courseInfoGroupBox.Controls.Add(this.roomLabel);
            this.courseInfoGroupBox.Controls.Add(this.instructorLabel);
            this.courseInfoGroupBox.Location = new System.Drawing.Point(12, 219);
            this.courseInfoGroupBox.Name = "courseInfoGroupBox";
            this.courseInfoGroupBox.Size = new System.Drawing.Size(274, 168);
            this.courseInfoGroupBox.TabIndex = 6;
            this.courseInfoGroupBox.TabStop = false;
            this.courseInfoGroupBox.Text = "Course Information";
            // 
            // meetingLabel
            // 
            this.meetingLabel.Location = new System.Drawing.Point(6, 106);
            this.meetingLabel.Name = "meetingLabel";
            this.meetingLabel.Size = new System.Drawing.Size(100, 23);
            this.meetingLabel.TabIndex = 4;
            this.meetingLabel.Text = "Meeting Time:";
            // 
            // instructorLabel
            // 
            this.instructorLabel.Location = new System.Drawing.Point(6, 62);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(100, 23);
            this.instructorLabel.TabIndex = 5;
            this.instructorLabel.Text = "Instructor:";
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(135, 29);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.ReadOnly = true;
            this.roomTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomTextBox.TabIndex = 6;
            // 
            // instructorTextBox
            // 
            this.instructorTextBox.Location = new System.Drawing.Point(135, 59);
            this.instructorTextBox.Name = "instructorTextBox";
            this.instructorTextBox.ReadOnly = true;
            this.instructorTextBox.Size = new System.Drawing.Size(100, 22);
            this.instructorTextBox.TabIndex = 7;
            // 
            // meetingTimeTextBox
            // 
            this.meetingTimeTextBox.Location = new System.Drawing.Point(135, 106);
            this.meetingTimeTextBox.Name = "meetingTimeTextBox";
            this.meetingTimeTextBox.ReadOnly = true;
            this.meetingTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.meetingTimeTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 430);
            this.Controls.Add(this.courseInfoGroupBox);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.getCourseButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Information";
            this.courseInfoGroupBox.ResumeLayout(false);
            this.courseInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getCourseButton;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.GroupBox courseInfoGroupBox;
        private System.Windows.Forms.TextBox meetingTimeTextBox;
        private System.Windows.Forms.TextBox instructorTextBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.Label meetingLabel;
        private System.Windows.Forms.Label instructorLabel;
    }
}

