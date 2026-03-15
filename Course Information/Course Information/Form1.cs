using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Information
{
    public partial class Form1 : Form
    {
        // Dictionaries must be INSIDE the class
        Dictionary<string, string> rooms = new Dictionary<string, string>()
        {
            {"CS101","3004"},
            {"CS102","4501"},
            {"CS103","6755"},
            {"NT110","1244"},
            {"CM241","1411"}
        };

        Dictionary<string, string> instructors = new Dictionary<string, string>()
        {
            {"CS101","Haynes"},
            {"CS102","Alvarado"},
            {"CS103","Rich"},
            {"NT110","Burke"},
            {"CM241","Lee"}
        };

        Dictionary<string, string> times = new Dictionary<string, string>()
        {
            {"CS101","8:00 AM"},
            {"CS102","9:00 AM"},
            {"CS103","10:00 AM"},
            {"NT110","11:00 AM"},
            {"CM241","1:00 PM"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void getCourseButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                string course = courseListBox.SelectedItem.ToString();

                roomTextBox.Text = rooms[course];
                instructorTextBox.Text = instructors[course];
                meetingTimeTextBox.Text = times[course];
            }
            else
            {
                MessageBox.Show("Please select a course.");
            }
        }
    }
}