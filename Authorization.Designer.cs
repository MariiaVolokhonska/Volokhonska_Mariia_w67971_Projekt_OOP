
namespace Projekt_OOP
{
    partial class Authorization
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
            this.logInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordAuthorization = new System.Windows.Forms.TextBox();
            this.loginAuthorization = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.logInButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordAuthorization);
            this.panel1.Controls.Add(this.loginAuthorization);
            this.panel1.Location = new System.Drawing.Point(240, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 412);
            this.panel1.TabIndex = 0;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Transparent;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logInButton.Location = new System.Drawing.Point(85, 325);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(150, 43);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(23, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(88, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            
            // 
            // passwordAuthorization
            // 
            this.passwordAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordAuthorization.Location = new System.Drawing.Point(28, 253);
            this.passwordAuthorization.Multiline = true;
            this.passwordAuthorization.Name = "passwordAuthorization";
            this.passwordAuthorization.PasswordChar = '*';
            this.passwordAuthorization.Size = new System.Drawing.Size(267, 46);
            this.passwordAuthorization.TabIndex = 1;
            // 
            // loginAuthorization
            // 
            this.loginAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginAuthorization.Location = new System.Drawing.Point(28, 172);
            this.loginAuthorization.Multiline = true;
            this.loginAuthorization.Name = "loginAuthorization";
            this.loginAuthorization.Size = new System.Drawing.Size(267, 46);
            this.loginAuthorization.TabIndex = 0;
           
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(837, 508);
            this.Controls.Add(this.panel1);
            this.Name = "Authorization";
            this.Text = "Autoryzacja";
            this.Load += new System.EventHandler(this.Autoryzacja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordAuthorization;
        private System.Windows.Forms.TextBox loginAuthorization;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

