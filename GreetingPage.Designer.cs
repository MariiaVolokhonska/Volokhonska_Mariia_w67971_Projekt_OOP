
namespace Projekt_OOP
{
    partial class GreetingPage
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
            this.KSIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainRegistrButton = new System.Windows.Forms.Button();
            this.mainLoginButton = new System.Windows.Forms.Button();
            this.mainLoginGuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KSIP
            // 
            this.KSIP.AutoSize = true;
            this.KSIP.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KSIP.ForeColor = System.Drawing.Color.MintCream;
            this.KSIP.Location = new System.Drawing.Point(312, 242);
            this.KSIP.Name = "KSIP";
            this.KSIP.Size = new System.Drawing.Size(423, 28);
            this.KSIP.TabIndex = 0;
            this.KSIP.Text = "Krajowy System Informacyjny Policji";
            this.KSIP.Click += new System.EventHandler(this.KSIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(441, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "KSIP";
            // 
            // mainRegistrButton
            // 
            this.mainRegistrButton.Location = new System.Drawing.Point(121, 376);
            this.mainRegistrButton.Name = "mainRegistrButton";
            this.mainRegistrButton.Size = new System.Drawing.Size(174, 39);
            this.mainRegistrButton.TabIndex = 2;
            this.mainRegistrButton.Text = "Zarejestruj się";
            this.mainRegistrButton.UseVisualStyleBackColor = true;
            this.mainRegistrButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainLoginButton
            // 
            this.mainLoginButton.Location = new System.Drawing.Point(427, 376);
            this.mainLoginButton.Name = "mainLoginButton";
            this.mainLoginButton.Size = new System.Drawing.Size(174, 39);
            this.mainLoginButton.TabIndex = 3;
            this.mainLoginButton.Text = "Zaloguj się";
            this.mainLoginButton.UseVisualStyleBackColor = true;
            this.mainLoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainLoginGuestButton
            // 
            this.mainLoginGuestButton.Location = new System.Drawing.Point(737, 376);
            this.mainLoginGuestButton.Name = "mainLoginGuestButton";
            this.mainLoginGuestButton.Size = new System.Drawing.Size(174, 39);
            this.mainLoginGuestButton.TabIndex = 4;
            this.mainLoginGuestButton.Text = "Zaloguj się jako gość";
            this.mainLoginGuestButton.UseVisualStyleBackColor = true;
            this.mainLoginGuestButton.Click += new System.EventHandler(this.mainLoginGuestButton_Click);
            // 
            // GreetingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1032, 601);
            this.Controls.Add(this.mainLoginGuestButton);
            this.Controls.Add(this.mainLoginButton);
            this.Controls.Add(this.mainRegistrButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KSIP);
            this.Name = "GreetingPage";
            this.Text = "GreetingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KSIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainRegistrButton;
        private System.Windows.Forms.Button mainLoginButton;
        private System.Windows.Forms.Button mainLoginGuestButton;
    }
}