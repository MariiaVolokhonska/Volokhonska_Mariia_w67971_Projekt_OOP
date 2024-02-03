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
    public partial class Registration : Form
    {
        private string userLoginID;
        DataBase database = new DataBase();
        public Registration()
        {
            InitializeComponent();
            userLoginID = "0";

        }
        

    
        public string getUserLoginID()
        {
            return this.userLoginID;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var nameUser = imieRegistr.Text;
            var surnameUser = nazwiskoRegistr.Text;
            var positionUser = stanowiskoRegistr.Text;
            var departmentUser = jednostkaRegistr.Text;
            var instituteUser = InstytucjaRegistr.Text;
            var studentIDUser = albumRegistr.Text;
            var passwordUser = passwordFieldRegistr.Text;
            var repeatPasswordUser = repeatPasswordFieldRegistr.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
 
            string registrQuery = $"INSERT INTO Users(Imię, Nazwisko, Stanowisko,JednostkaPolicji,NazwaInstytucji,NumerAlbumu,Hasło) VALUES ('{nameUser}','{surnameUser}','{positionUser}','{departmentUser}','{instituteUser}','{studentIDUser}','{passwordUser}')";
           /*we need getIDQuery to get the last added id (id that was created rigth after created new user) to show user his new login*/
            string getIdQuery = $"SELECT TOP 1 PracownikID FROM Users ORDER BY PracownikID DESC ";
            /*command is a container for sql query for creating new user(inserting data to table in database) and also link it to the correct database*/
            SqlCommand command = new SqlCommand(registrQuery, database.getConnection());
            if (passwordUser.Trim() == repeatPasswordUser.Trim()) {
                database.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    SqlCommand getIDCommand = new SqlCommand(getIdQuery, database.getConnection());
                    SqlDataReader reader = getIDCommand.ExecuteReader();//there we got ID we wanted from database and put it in 'reader' variable
                    
                    //while ()
                    //{
                    reader.Read();
                    this.userLoginID = reader["PracownikID"].ToString();//and here we converted that id to string
                    //}
 
                    reader.Close();
                    MessageBox.Show($"Account was successfully created! Your new login is {userLoginID}");
                    Authorization authorizationPage = new Authorization();
                    this.Hide();
                    authorizationPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Account wasn't created");
                }
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Password is incorrect");
            }
        }

        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
