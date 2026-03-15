using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardsListBox.SelectedIndex != -1)
            {
                ShowCard(cardsListBox.SelectedItem.ToString());
            }
        }

        // The ShowCard method accepts a string that names 
        // the selected card, and displays that card.
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;

                case "10 of Hearts":
                    ShowTenHearts();
                    break;

                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        private void ShowAceSpades()
        {
            aceOfSpadesPictureBox.Visible = true;
            tenOfHeartsPictureBox.Visible = false;
            kingOfClubsPictureBox.Visible = false;
        }

        private void ShowTenHearts()
        {
            aceOfSpadesPictureBox.Visible = false;
            tenOfHeartsPictureBox.Visible = true;
            kingOfClubsPictureBox.Visible = false;
        }

        private void ShowKingClubs()   // ✅ Fixed capitalization typo
        {
            aceOfSpadesPictureBox.Visible = false;
            tenOfHeartsPictureBox.Visible = false;
            kingOfClubsPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}