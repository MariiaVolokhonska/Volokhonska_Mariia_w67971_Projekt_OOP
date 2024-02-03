
namespace Projekt_OOP
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rzeczButton = new System.Windows.Forms.Label();
            this.osobaButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelOsobyZaginione = new System.Windows.Forms.LinkLabel();
            this.myProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.myProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rzeczButton);
            this.panel1.Controls.Add(this.osobaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1291, 100);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(516, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "PODMIOT";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rzeczButton
            // 
            this.rzeczButton.AutoSize = true;
            this.rzeczButton.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rzeczButton.ForeColor = System.Drawing.Color.MintCream;
            this.rzeczButton.Location = new System.Drawing.Point(302, 32);
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
            this.osobaButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informacje w domenie publicznej";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabelOsobyZaginione);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 700);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(485, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(627, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Krajowy System Informacyjny Policji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(374, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(834, 250);
            this.label5.TabIndex = 4;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // linkLabelOsobyZaginione
            // 
            this.linkLabelOsobyZaginione.AutoSize = true;
            this.linkLabelOsobyZaginione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelOsobyZaginione.Location = new System.Drawing.Point(11, 118);
            this.linkLabelOsobyZaginione.Name = "linkLabelOsobyZaginione";
            this.linkLabelOsobyZaginione.Size = new System.Drawing.Size(191, 22);
            this.linkLabelOsobyZaginione.TabIndex = 5;
            this.linkLabelOsobyZaginione.TabStop = true;
            this.linkLabelOsobyZaginione.Text = "Lista osób zaginionych";
            this.linkLabelOsobyZaginione.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOsobyZaginione_LinkClicked);
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
            this.myProfile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1291, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rzeczButton;
        private System.Windows.Forms.Label osobaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox myProfile;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelOsobyZaginione;
    }
}