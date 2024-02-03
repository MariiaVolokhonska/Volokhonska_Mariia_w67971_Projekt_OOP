using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projekt_OOP
{
    public partial class Authorization : Form
    {
        public string loginAut;
        DataBase database = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           
          
        }

        private void Autoryzacja_Load(object sender, EventArgs e)
        {
            passwordAuthorization.MaxLength = 50;


        }
        public string getAuthorizationLogin()
        {
            return this.loginAut;
        }

        
        public string searchForLog()
        {
            this.loginAut = loginAuthorization.Text;
            var passwordAut = passwordAuthorization.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string authorizationQuery = $"select PracownikID, Hasło from Users where PracownikID='{this.loginAut}' and Hasło='{passwordAut}'";
            SqlCommand command = new SqlCommand(authorizationQuery, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
           
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Success!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return this.loginAut;
        }
        

        private void logInButton_Click_1(object sender, EventArgs e)
        {
            MainPage mainp = new MainPage();
            mainp.autLog= searchForLog();


            /** var passwordAut = passwordAuthorization.Text;
             SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable table = new DataTable();
             string authorizationQuery = $"select PracownikID, Hasło from Users where PracownikID='{this.loginAut}' and Hasło='{passwordAut}'";
             SqlCommand command = new SqlCommand(authorizationQuery, database.getConnection());
             adapter.SelectCommand = command;
             adapter.Fill(table);
             MessageBox.Show(this.loginAut);
             if (table.Rows.Count == 1)
             {
                 MessageBox.Show("Success!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 MainPage mainPage = new MainPage();
                 this.Hide();
                 mainPage.ShowDialog();
             }
             else
             {
                 MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }**/



        }

       
    }
}
