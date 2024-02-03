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
    public partial class MyProfilePage : Form
    {
       
        DataBase database = new DataBase();
        public MyProfilePage()
        {
            InitializeComponent();
            
        }

        public string[] getInformationAboutUserFromDB(int id)
        {
            string getInfoQuery = $"select * from Users where PracownikID={id}";

            database.OpenConnection();// we need to open a close connection with database
            SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
            DataTable Newtable = new DataTable();//create local table in our programm where we put sql data 
            SqlCommand command = new SqlCommand(getInfoQuery, database.getConnection());
            
                                                                //}
            adapter.SelectCommand = command;//here we show adapter a command that is executed 
            database.CloseConnection();

            adapter.Fill(Newtable);// we fill table with sql data
           // return Newtable;
            string[] arrOfInfo = new string[8];
            int i = 0;
            foreach(DataColumn column in Newtable.Columns)
             {
                arrOfInfo[i] = Convert.ToString(Newtable.Rows[0][column]);
                i++;
             }

            return arrOfInfo;
             
  


            /** MessageBox.Show($"{Convert.ToString(Newtable.Rows[0][1])}");**/


            // dataGridView6.DataSource = table;
        }
        public void fillProfilePageWithInfo(int id)
        {
            
            
            if (id!= 0)
            {
                listBoxProfile.Items.Clear();
                string[] listOfInf = new string[7];
                string[] listOfHeaders = {"Login: ","Imię: ","Nazwisko: ","Stanowisko: ","Jednostka policji: ","Nazwsa instytucji: ","Numer albumu: "};
                listOfInf = getInformationAboutUserFromDB(id);
                for (int i = 0; i < listOfInf.Length - 1; i++)
                {
                    listBoxProfile.Items.Add(listOfHeaders[i]+listOfInf[i]);
                }

                
                
                  
              //  dataGridViewPr.DataSource = getInformationAboutUserFromDB(id);
            }
           
        }

        public void panelProfile_Paint(object sender, PaintEventArgs e)
        {

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

        private void label3_Click(object sender, EventArgs e)
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GreetingPage page = new GreetingPage();
            this.Hide();
            page.Show();
        }
    }
}
