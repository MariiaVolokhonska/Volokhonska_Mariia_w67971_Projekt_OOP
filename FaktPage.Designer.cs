
namespace Projekt_OOP
{
    partial class FaktPage
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
            System.Windows.Forms.Label JednostkaPolicjiDokonującaRejestracje;
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rzeczButton = new System.Windows.Forms.Label();
            this.osobaButton = new System.Windows.Forms.Label();
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.enterIDLabel = new System.Windows.Forms.Label();
            this.enterIDToEditTextBoxF = new System.Windows.Forms.TextBox();
            this.AddButtonF = new System.Windows.Forms.Button();
            this.editButtonF = new System.Windows.Forms.Button();
            this.searchButtonF = new System.Windows.Forms.Button();
            this.formSearchPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.RzeczZwiązanaZWydarzeniemField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CzynnościPodjętePrzezJednostkęPolicjiField = new System.Windows.Forms.TextBox();
            this.JednostkaPolicjiDokonującaRejestracjeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OsobaRejestrującaIDField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumerSprawyKSIPField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGodzinaZgłoszeniaOWydarzeniuField = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RodzajWydarzeniaIDField = new System.Windows.Forms.TextBox();
            this.DataWydarzeniaField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MiejsceWydarzeniaField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SposobieZawiadomieniaPolicjiOWydarzeniuField = new System.Windows.Forms.TextBox();
            JednostkaPolicjiDokonującaRejestracje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            this.formSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JednostkaPolicjiDokonującaRejestracje
            // 
            JednostkaPolicjiDokonującaRejestracje.AutoSize = true;
            JednostkaPolicjiDokonującaRejestracje.Location = new System.Drawing.Point(34, 18);
            JednostkaPolicjiDokonującaRejestracje.Name = "JednostkaPolicjiDokonującaRejestracje";
            JednostkaPolicjiDokonującaRejestracje.Size = new System.Drawing.Size(291, 20);
            JednostkaPolicjiDokonującaRejestracje.TabIndex = 48;
            JednostkaPolicjiDokonującaRejestracje.Text = "JednostkaPolicjiDokonującaRejestracje:";
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
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 51;
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
            // dataGridViewF
            // 
            this.dataGridViewF.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Location = new System.Drawing.Point(523, 133);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.RowHeadersWidth = 62;
            this.dataGridViewF.RowTemplate.Height = 28;
            this.dataGridViewF.Size = new System.Drawing.Size(706, 562);
            this.dataGridViewF.TabIndex = 53;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Items.AddRange(new object[] {
            "Formularz wyszukiwania",
            "Formularz redagowania",
            "Formularz wypelnenia"});
            this.listBox3.Location = new System.Drawing.Point(121, 170);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(216, 24);
            this.listBox3.TabIndex = 54;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged_1);
            // 
            // enterIDLabel
            // 
            this.enterIDLabel.AutoSize = true;
            this.enterIDLabel.Location = new System.Drawing.Point(43, 425);
            this.enterIDLabel.Name = "enterIDLabel";
            this.enterIDLabel.Size = new System.Drawing.Size(294, 20);
            this.enterIDLabel.TabIndex = 56;
            this.enterIDLabel.Text = "Wprowadź numer sprawy, aby edytować:";
            this.enterIDLabel.Visible = false;
            // 
            // enterIDToEditTextBoxF
            // 
            this.enterIDToEditTextBoxF.Location = new System.Drawing.Point(351, 422);
            this.enterIDToEditTextBoxF.Name = "enterIDToEditTextBoxF";
            this.enterIDToEditTextBoxF.Size = new System.Drawing.Size(100, 26);
            this.enterIDToEditTextBoxF.TabIndex = 55;
            this.enterIDToEditTextBoxF.Visible = false;
            // 
            // AddButtonF
            // 
            this.AddButtonF.Location = new System.Drawing.Point(348, 476);
            this.AddButtonF.Name = "AddButtonF";
            this.AddButtonF.Size = new System.Drawing.Size(148, 32);
            this.AddButtonF.TabIndex = 59;
            this.AddButtonF.Text = "Wypełnij";
            this.AddButtonF.UseVisualStyleBackColor = true;
            this.AddButtonF.Click += new System.EventHandler(this.AddButtonF_Click);
            // 
            // editButtonF
            // 
            this.editButtonF.Location = new System.Drawing.Point(194, 476);
            this.editButtonF.Name = "editButtonF";
            this.editButtonF.Size = new System.Drawing.Size(148, 32);
            this.editButtonF.TabIndex = 58;
            this.editButtonF.Text = "Edytuj";
            this.editButtonF.UseVisualStyleBackColor = true;
            this.editButtonF.Click += new System.EventHandler(this.editButtonF_Click);
            // 
            // searchButtonF
            // 
            this.searchButtonF.Location = new System.Drawing.Point(25, 476);
            this.searchButtonF.Name = "searchButtonF";
            this.searchButtonF.Size = new System.Drawing.Size(148, 32);
            this.searchButtonF.TabIndex = 57;
            this.searchButtonF.Text = "Wyszukaj\r\n";
            this.searchButtonF.UseVisualStyleBackColor = true;
            this.searchButtonF.Click += new System.EventHandler(this.searchButtonF_Click);
            // 
            // formSearchPanel
            // 
            this.formSearchPanel.AutoScroll = true;
            this.formSearchPanel.Controls.Add(this.label10);
            this.formSearchPanel.Controls.Add(this.RzeczZwiązanaZWydarzeniemField);
            this.formSearchPanel.Controls.Add(this.label3);
            this.formSearchPanel.Controls.Add(this.CzynnościPodjętePrzezJednostkęPolicjiField);
            this.formSearchPanel.Controls.Add(JednostkaPolicjiDokonującaRejestracje);
            this.formSearchPanel.Controls.Add(this.JednostkaPolicjiDokonującaRejestracjeField);
            this.formSearchPanel.Controls.Add(this.label4);
            this.formSearchPanel.Controls.Add(this.OsobaRejestrującaIDField);
            this.formSearchPanel.Controls.Add(this.label5);
            this.formSearchPanel.Controls.Add(this.NumerSprawyKSIPField);
            this.formSearchPanel.Controls.Add(this.label6);
            this.formSearchPanel.Controls.Add(this.DataGodzinaZgłoszeniaOWydarzeniuField);
            this.formSearchPanel.Controls.Add(this.label11);
            this.formSearchPanel.Controls.Add(this.RodzajWydarzeniaIDField);
            this.formSearchPanel.Controls.Add(this.DataWydarzeniaField);
            this.formSearchPanel.Controls.Add(this.label7);
            this.formSearchPanel.Controls.Add(this.label8);
            this.formSearchPanel.Controls.Add(this.MiejsceWydarzeniaField);
            this.formSearchPanel.Controls.Add(this.label9);
            this.formSearchPanel.Controls.Add(this.SposobieZawiadomieniaPolicjiOWydarzeniuField);
            this.formSearchPanel.Location = new System.Drawing.Point(12, 221);
            this.formSearchPanel.Name = "formSearchPanel";
            this.formSearchPanel.Size = new System.Drawing.Size(505, 186);
            this.formSearchPanel.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "RzeczZwiązanaZWydarzeniem:";
            // 
            // RzeczZwiązanaZWydarzeniemField
            // 
            this.RzeczZwiązanaZWydarzeniemField.Location = new System.Drawing.Point(331, 338);
            this.RzeczZwiązanaZWydarzeniemField.Name = "RzeczZwiązanaZWydarzeniemField";
            this.RzeczZwiązanaZWydarzeniemField.Size = new System.Drawing.Size(141, 26);
            this.RzeczZwiązanaZWydarzeniemField.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "CzynnościPodjętePrzezJednostkęPolicji:";
            // 
            // CzynnościPodjętePrzezJednostkęPolicjiField
            // 
            this.CzynnościPodjętePrzezJednostkęPolicjiField.Location = new System.Drawing.Point(331, 303);
            this.CzynnościPodjętePrzezJednostkęPolicjiField.Name = "CzynnościPodjętePrzezJednostkęPolicjiField";
            this.CzynnościPodjętePrzezJednostkęPolicjiField.Size = new System.Drawing.Size(141, 26);
            this.CzynnościPodjętePrzezJednostkęPolicjiField.TabIndex = 62;
            // 
            // JednostkaPolicjiDokonującaRejestracjeField
            // 
            this.JednostkaPolicjiDokonującaRejestracjeField.Location = new System.Drawing.Point(331, 12);
            this.JednostkaPolicjiDokonującaRejestracjeField.Multiline = true;
            this.JednostkaPolicjiDokonującaRejestracjeField.Name = "JednostkaPolicjiDokonującaRejestracjeField";
            this.JednostkaPolicjiDokonującaRejestracjeField.Size = new System.Drawing.Size(141, 26);
            this.JednostkaPolicjiDokonującaRejestracjeField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "OsobaRejestrującaID:";
            // 
            // OsobaRejestrującaIDField
            // 
            this.OsobaRejestrującaIDField.Location = new System.Drawing.Point(331, 46);
            this.OsobaRejestrującaIDField.Multiline = true;
            this.OsobaRejestrującaIDField.Name = "OsobaRejestrującaIDField";
            this.OsobaRejestrującaIDField.Size = new System.Drawing.Size(141, 26);
            this.OsobaRejestrującaIDField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "NumerSprawyKSIP:";
            // 
            // NumerSprawyKSIPField
            // 
            this.NumerSprawyKSIPField.Location = new System.Drawing.Point(331, 81);
            this.NumerSprawyKSIPField.Multiline = true;
            this.NumerSprawyKSIPField.Name = "NumerSprawyKSIPField";
            this.NumerSprawyKSIPField.Size = new System.Drawing.Size(141, 26);
            this.NumerSprawyKSIPField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "DataGodzinaZgłoszeniaOWydarzeniu:";
            // 
            // DataGodzinaZgłoszeniaOWydarzeniuField
            // 
            this.DataGodzinaZgłoszeniaOWydarzeniuField.Location = new System.Drawing.Point(331, 118);
            this.DataGodzinaZgłoszeniaOWydarzeniuField.Multiline = true;
            this.DataGodzinaZgłoszeniaOWydarzeniuField.Name = "DataGodzinaZgłoszeniaOWydarzeniuField";
            this.DataGodzinaZgłoszeniaOWydarzeniuField.Size = new System.Drawing.Size(141, 26);
            this.DataGodzinaZgłoszeniaOWydarzeniuField.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "RodzajWydarzeniaID:";
            // 
            // RodzajWydarzeniaIDField
            // 
            this.RodzajWydarzeniaIDField.Location = new System.Drawing.Point(331, 154);
            this.RodzajWydarzeniaIDField.Multiline = true;
            this.RodzajWydarzeniaIDField.Name = "RodzajWydarzeniaIDField";
            this.RodzajWydarzeniaIDField.Size = new System.Drawing.Size(141, 26);
            this.RodzajWydarzeniaIDField.TabIndex = 23;
            // 
            // DataWydarzeniaField
            // 
            this.DataWydarzeniaField.Location = new System.Drawing.Point(331, 192);
            this.DataWydarzeniaField.Multiline = true;
            this.DataWydarzeniaField.Name = "DataWydarzeniaField";
            this.DataWydarzeniaField.Size = new System.Drawing.Size(141, 26);
            this.DataWydarzeniaField.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "DataWydarzenia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "MiejsceWydarzenia:";
            // 
            // MiejsceWydarzeniaField
            // 
            this.MiejsceWydarzeniaField.Location = new System.Drawing.Point(331, 230);
            this.MiejsceWydarzeniaField.Multiline = true;
            this.MiejsceWydarzeniaField.Name = "MiejsceWydarzeniaField";
            this.MiejsceWydarzeniaField.Size = new System.Drawing.Size(141, 26);
            this.MiejsceWydarzeniaField.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "SposobieZawiadomieniaPolicjiOWydarzeniu:";
            // 
            // SposobieZawiadomieniaPolicjiOWydarzeniuField
            // 
            this.SposobieZawiadomieniaPolicjiOWydarzeniuField.Location = new System.Drawing.Point(331, 267);
            this.SposobieZawiadomieniaPolicjiOWydarzeniuField.Name = "SposobieZawiadomieniaPolicjiOWydarzeniuField";
            this.SposobieZawiadomieniaPolicjiOWydarzeniuField.Size = new System.Drawing.Size(141, 26);
            this.SposobieZawiadomieniaPolicjiOWydarzeniuField.TabIndex = 19;
            // 
            // FaktPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 763);
            this.Controls.Add(this.formSearchPanel);
            this.Controls.Add(this.AddButtonF);
            this.Controls.Add(this.editButtonF);
            this.Controls.Add(this.searchButtonF);
            this.Controls.Add(this.enterIDLabel);
            this.Controls.Add(this.enterIDToEditTextBoxF);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.dataGridViewF);
            this.Controls.Add(this.panel1);
            this.Name = "FaktPage";
            this.Text = "FaktPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            this.formSearchPanel.ResumeLayout(false);
            this.formSearchPanel.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewF;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label enterIDLabel;
        private System.Windows.Forms.TextBox enterIDToEditTextBoxF;
        private System.Windows.Forms.Button AddButtonF;
        private System.Windows.Forms.Button editButtonF;
        private System.Windows.Forms.Button searchButtonF;
        private System.Windows.Forms.Panel formSearchPanel;
        private System.Windows.Forms.TextBox JednostkaPolicjiDokonującaRejestracjeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OsobaRejestrującaIDField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumerSprawyKSIPField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DataGodzinaZgłoszeniaOWydarzeniuField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RodzajWydarzeniaIDField;
        private System.Windows.Forms.TextBox DataWydarzeniaField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MiejsceWydarzeniaField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SposobieZawiadomieniaPolicjiOWydarzeniuField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RzeczZwiązanaZWydarzeniemField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CzynnościPodjętePrzezJednostkęPolicjiField;
    }
}