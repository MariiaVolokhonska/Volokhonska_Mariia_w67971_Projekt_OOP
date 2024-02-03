
namespace Projekt_OOP
{
    partial class MyProfilePage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rzeczButton = new System.Windows.Forms.Label();
            this.osobaButton = new System.Windows.Forms.Label();
            this.listBoxProfile = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_OOP.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(501, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(589, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mój Profil";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.myProfile);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rzeczButton);
            this.panel2.Controls.Add(this.osobaButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 100);
            this.panel2.TabIndex = 53;
            // 
            // logOutButton
            // 
            this.logOutButton.AutoSize = true;
            this.logOutButton.Font = new System.Drawing.Font("Book Antiqua", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.ForeColor = System.Drawing.Color.MintCream;
            this.logOutButton.Location = new System.Drawing.Point(1052, 59);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(131, 27);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Wyłoguj się";
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(787, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "FAKT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // myProfile
            // 
            this.myProfile.Image = global::Projekt_OOP.Properties.Resources.icon;
            this.myProfile.Location = new System.Drawing.Point(1057, 12);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(124, 44);
            this.myProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myProfile.TabIndex = 4;
            this.myProfile.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(516, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "PODMIOT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rzeczButton
            // 
            this.rzeczButton.AutoSize = true;
            this.rzeczButton.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rzeczButton.ForeColor = System.Drawing.Color.MintCream;
            this.rzeczButton.Location = new System.Drawing.Point(292, 32);
            this.rzeczButton.Name = "rzeczButton";
            this.rzeczButton.Size = new System.Drawing.Size(125, 39);
            this.rzeczButton.TabIndex = 1;
            this.rzeczButton.Text = "RZECZ";
            this.rzeczButton.Click += new System.EventHandler(this.rzeczButton_Click);
            // 
            // osobaButton
            // 
            this.osobaButton.AutoSize = true;
            this.osobaButton.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.osobaButton.ForeColor = System.Drawing.Color.MintCream;
            this.osobaButton.Location = new System.Drawing.Point(83, 32);
            this.osobaButton.Name = "osobaButton";
            this.osobaButton.Size = new System.Drawing.Size(137, 39);
            this.osobaButton.TabIndex = 0;
            this.osobaButton.Text = "OSOBA";
            this.osobaButton.Click += new System.EventHandler(this.osobaButton_Click);
            // 
            // listBoxProfile
            // 
            this.listBoxProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxProfile.FormattingEnabled = true;
            this.listBoxProfile.ItemHeight = 20;
            this.listBoxProfile.Location = new System.Drawing.Point(462, 465);
            this.listBoxProfile.Name = "listBoxProfile";
            this.listBoxProfile.Size = new System.Drawing.Size(394, 224);
            this.listBoxProfile.TabIndex = 54;
            // 
            // MyProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 772);
            this.Controls.Add(this.listBoxProfile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MyProfilePage";
            this.Text = "MyProfilPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox myProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rzeczButton;
        private System.Windows.Forms.Label osobaButton;
        private System.Windows.Forms.ListBox listBoxProfile;
    }
}