
namespace Projekt_OOP
{
    partial class ViewOsobyZaginione
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rzeczButton = new System.Windows.Forms.Label();
            this.osobaButton = new System.Windows.Forms.Label();
            this.dataGridViewOsobyZaginione = new System.Windows.Forms.DataGridView();
            this.labelLista = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsobyZaginione)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1269, 100);
            this.panel1.TabIndex = 52;
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
            this.myProfile.Click += new System.EventHandler(this.myProfile_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // dataGridViewOsobyZaginione
            // 
            this.dataGridViewOsobyZaginione.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOsobyZaginione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOsobyZaginione.Location = new System.Drawing.Point(32, 192);
            this.dataGridViewOsobyZaginione.Name = "dataGridViewOsobyZaginione";
            this.dataGridViewOsobyZaginione.RowHeadersWidth = 62;
            this.dataGridViewOsobyZaginione.RowTemplate.Height = 28;
            this.dataGridViewOsobyZaginione.Size = new System.Drawing.Size(1164, 503);
            this.dataGridViewOsobyZaginione.TabIndex = 53;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLista.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelLista.Location = new System.Drawing.Point(27, 126);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(650, 29);
            this.labelLista.TabIndex = 54;
            this.labelLista.Text = "Lista wszystkich zaginionych osób na przestrzeni czasu";
            // 
            // ViewOsobyZaginione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 765);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.dataGridViewOsobyZaginione);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOsobyZaginione";
            this.Text = "ViewOsobyZaginione";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOsobyZaginione)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logOutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox myProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rzeczButton;
        private System.Windows.Forms.Label osobaButton;
        private System.Windows.Forms.DataGridView dataGridViewOsobyZaginione;
        private System.Windows.Forms.Label labelLista;
    }
}