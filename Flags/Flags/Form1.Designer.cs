namespace Flags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.germanyPictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a flag to see the name of the country.";
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandPictureBox.Image")));
            this.finlandPictureBox.Location = new System.Drawing.Point(50, 94);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(120, 70);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.finlandPictureBox.TabIndex = 1;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
            this.francePictureBox.Location = new System.Drawing.Point(219, 94);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(122, 72);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.francePictureBox.TabIndex = 2;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // germanyPictureBox
            // 
            this.germanyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("germanyPictureBox.Image")));
            this.germanyPictureBox.Location = new System.Drawing.Point(415, 94);
            this.germanyPictureBox.Name = "germanyPictureBox";
            this.germanyPictureBox.Size = new System.Drawing.Size(120, 70);
            this.germanyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.germanyPictureBox.TabIndex = 3;
            this.germanyPictureBox.TabStop = false;
            this.germanyPictureBox.Click += new System.EventHandler(this.germanyPictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(229, 216);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(100, 23);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(608, 209);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Flags";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanyPictureBox;
        private System.Windows.Forms.Label countryLabel;
    }
}

