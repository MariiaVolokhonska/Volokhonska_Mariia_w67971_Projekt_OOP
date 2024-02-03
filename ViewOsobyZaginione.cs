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
    public partial class ViewOsobyZaginione : Form
    {
        DataBase database = new DataBase();
        public ViewOsobyZaginione()
        {
            InitializeComponent();
        }
        public void ShowLostPeople()
        {
            string searchQuery = $"select * from OsobyZaginione"; //here i try to create a string constructor for a query because we don't know which fields and how many of them were used as filter for a search
           
            database.OpenConnection();// we need to open a close connection with database
            SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
            DataTable table = new DataTable();//create local table in our programm where we put sql data 
            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());
            adapter.SelectCommand = command;//here we show adapter a command that is executed 
            database.CloseConnection();

            adapter.Fill(table);// we fill table with sql data
            dataGridViewOsobyZaginione.DataSource = table;
        }

        private void osobaButton_Click(object sender, EventArgs e)
        {
            OsobaPage osobaPage = new OsobaPage();
            this.Hide();
            osobaPage.Show();
        }

        private void rzeczButton_Click(object sender, EventArgs e)
        {
            RzeczPage rzeczPage = new RzeczPage();
            this.Hide();
            rzeczPage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PodmiotPage podmiotPage = new PodmiotPage();
            this.Hide();
            podmiotPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FaktPage faktPage = new FaktPage();
            this.Hide();
            faktPage.Show();
        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();

            MyProfilePage profile = new MyProfilePage();
            profile.fillProfilePageWithInfo(int.Parse("1"));
            this.Hide();
            profile.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GreetingPage page = new GreetingPage();
            this.Hide();
            page.Show();
        }
    }
}
