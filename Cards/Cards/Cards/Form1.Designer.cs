namespace Cards
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
            this.cardsListBox = new System.Windows.Forms.ListBox();
            this.showCardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.kingOfClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenOfHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.aceOfSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingOfClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpadesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardsListBox
            // 
            this.cardsListBox.FormattingEnabled = true;
            this.cardsListBox.ItemHeight = 16;
            this.cardsListBox.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.cardsListBox.Location = new System.Drawing.Point(152, 188);
            this.cardsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardsListBox.Name = "cardsListBox";
            this.cardsListBox.Size = new System.Drawing.Size(112, 68);
            this.cardsListBox.TabIndex = 3;
            // 
            // showCardButton
            // 
            this.showCardButton.Location = new System.Drawing.Point(104, 265);
            this.showCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(100, 28);
            this.showCardButton.TabIndex = 4;
            this.showCardButton.Text = "Show Card";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(212, 265);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardPanel
            // 
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPanel.Controls.Add(this.kingOfClubsPictureBox);
            this.cardPanel.Controls.Add(this.tenOfHeartsPictureBox);
            this.cardPanel.Controls.Add(this.aceOfSpadesPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(16, 15);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(379, 165);
            this.cardPanel.TabIndex = 6;
            // 
            // kingOfClubsPictureBox
            // 
            this.kingOfClubsPictureBox.Image = global::Cards.Properties.Resources.King_Clubs;
            this.kingOfClubsPictureBox.Location = new System.Drawing.Point(255, 7);
            this.kingOfClubsPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kingOfClubsPictureBox.Name = "kingOfClubsPictureBox";
            this.kingOfClubsPictureBox.Size = new System.Drawing.Size(113, 142);
            this.kingOfClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingOfClubsPictureBox.TabIndex = 5;
            this.kingOfClubsPictureBox.TabStop = false;
            this.kingOfClubsPictureBox.Visible = false;
            // 
            // tenOfHeartsPictureBox
            // 
            this.tenOfHeartsPictureBox.Image = global::Cards.Properties.Resources._10_Hearts;
            this.tenOfHeartsPictureBox.Location = new System.Drawing.Point(133, 7);
            this.tenOfHeartsPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenOfHeartsPictureBox.Name = "tenOfHeartsPictureBox";
            this.tenOfHeartsPictureBox.Size = new System.Drawing.Size(113, 142);
            this.tenOfHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenOfHeartsPictureBox.TabIndex = 4;
            this.tenOfHeartsPictureBox.TabStop = false;
            this.tenOfHeartsPictureBox.Visible = false;
            // 
            // aceOfSpadesPictureBox
            // 
            this.aceOfSpadesPictureBox.Image = global::Cards.Properties.Resources.Ace_Spades;
            this.aceOfSpadesPictureBox.Location = new System.Drawing.Point(12, 7);
            this.aceOfSpadesPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceOfSpadesPictureBox.Name = "aceOfSpadesPictureBox";
            this.aceOfSpadesPictureBox.Size = new System.Drawing.Size(113, 142);
            this.aceOfSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceOfSpadesPictureBox.TabIndex = 3;
            this.aceOfSpadesPictureBox.TabStop = false;
            this.aceOfSpadesPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 305);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.cardsListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cards";
            this.cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kingOfClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenOfHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpadesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cardsListBox;
        private System.Windows.Forms.Button showCardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.PictureBox kingOfClubsPictureBox;
        private System.Windows.Forms.PictureBox tenOfHeartsPictureBox;
        private System.Windows.Forms.PictureBox aceOfSpadesPictureBox;
    }
}

