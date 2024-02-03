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
using CsvHelper;
using System.IO;
using OfficeOpenXml;
using System.Globalization;

namespace Projekt_OOP
{
    public partial class OsobaPage : Form, PageCommands
    {
        DataBase database = new DataBase();
        public OsobaPage()
        {
            InitializeComponent();
        }
        public void writeToCSV(List<OsobaQueries> dataList)
        {
            string filePath = "C:\\Users\\Korystuvach\\Desktop\\new.csv";
            using (var writer = new StreamWriter(filePath,false, new UTF8Encoding(true)))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(dataList);
            }
        }
        public List<OsobaQueries> readFromCSV()
        {
            List<OsobaQueries> dataList;

            string filePath = "C:\\Users\\Korystuvach\\Desktop\\new.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                dataList = csv.GetRecords<OsobaQueries>().ToList();
            }
            return dataList;
        }
        public DataTable search(Dictionary<string, string> dict, string section)//section - name of table in db f.e. 'Osoba.Osoba'. We need it to create universal query builder for each page
        {
            List<OsobaQueries> dataList = new List<OsobaQueries>();
            
            string searchQuery = $"select * from {section} where "; //here i try to create a string constructor for a query because we don't know which fields and how many of them were used as filter for a search
            foreach (var pair in dict)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                {
                    searchQuery += $"{pair.Key} = '{pair.Value}' and ";
                }
            }
            string searchQuery1 = searchQuery.Remove(searchQuery.Length - 5); // there is one extra "and" we need to get rid of 

            database.OpenConnection();// we need to open a close connection with database
            SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
            DataTable table = new DataTable();//create local table in our programm where we put sql data 
            SqlCommand command = new SqlCommand(searchQuery1, database.getConnection());
            adapter.SelectCommand = command;//here we show adapter a command that is executed 
            
            adapter.Fill(table);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OsobaQueries osoba = new OsobaQueries(Convert.ToInt32(reader["OsobaID"]), reader["NazwiskoAktualne"].ToString(), reader["NazwiskoPoprzednie"].ToString(), reader["ImieAktualne"].ToString(), reader["ImiePoprzdnie"].ToString(), reader["NazwiskoRodoweMatki"].ToString(), reader["DataUrodzenia"].ToString(), reader["MiejsceUrodzenia"].ToString(), reader["Narodowość"].ToString(), reader["Obywatelstwo"].ToString(), reader["Płeć"].ToString(), reader["RodzajDokumentuTorzsamości"].ToString(), reader["NumerDokumentuTorzsamości"].ToString(), reader["Wykształcenie"].ToString(), reader["Zawód"].ToString(), reader["KategoriaID"].ToString(), reader["FormularzID"].ToString(), reader["NumerPESEL"].ToString(), reader["Adres"].ToString(), reader["NumerTelefonu"].ToString());
                dataList.Add(osoba);
            }
            database.CloseConnection();
            writeToCSV(dataList);
            
          
            return table; //we need to return local table to main class to show it in dataGridView
        }

        public DataTable add(Dictionary<string, string> dict, string section)
        {
            List<String> listOfValues = dict.Values.ToList();//we need list because in case of INSERT INTO query, first of all, we must fill bluprint with all keys, and only then VALUES() with values. With only dictionary it is impossible
            string stringValues = "";
            List<String> listOfKeys = dict.Keys.ToList();
            string stringKeys = "";

            foreach (string value in listOfValues)
            {
                if (string.IsNullOrEmpty(value))//if we don`t fill the field with information it is empty, but not NULL. We need NULL to deliver the information to database correctly
                {
                    stringValues += "NULL,";
                }
                else
                {
                    stringValues += $"'{value}',";
                }

            }
            string stringValues1 = stringValues.Remove(stringValues.Length - 1);//get rid of last comma
            foreach (string key in listOfKeys)
            {
                stringKeys += $"{key},";
            }
            string stringKeys1 = stringKeys.Remove(stringKeys.Length - 1);
            string addQuery = $"INSERT INTO {section}({stringKeys1}) OUTPUT INSERTED.OsobaID, INSERTED.NazwiskoAktualne, INSERTED.ImieAktualne VALUES ({stringValues1}) ";

            database.OpenConnection();// we need to open a close connection with database
            SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
            DataTable table = new DataTable();//create local table in our programm where we put sql data 
            SqlCommand command = new SqlCommand(addQuery, database.getConnection());
            adapter.SelectCommand = command;//here we show adapter a command that is executed 
            database.CloseConnection();

            adapter.Fill(table);// we fill table with sql data
            return table;//we need to return local table to main class to show it in dataGridView

        }




        public DataTable edit(Dictionary<string, string> dict, string section, string editionPosition/**var enterIdToEdit = enterIDToEditTextBox.Text;**/, string idInSQL /** where to edit in sql**/)
        {
            List<OsobaQueries> dataList = new List<OsobaQueries>();
            string editQuery = "UPDATE Osoba.Osoba SET "; //here i try to create a string constructor for a query because we don't know which fields and how many of them were used as filter for a search

            foreach (var pair in dict)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                    editQuery += $"{pair.Key} = '{pair.Value}',";
            }
            string editQuery1 = editQuery.Remove(editQuery.Length - 1);
            string whereIDString = $" WHERE {idInSQL}={editionPosition}; ";
            editQuery1 += whereIDString;


            database.OpenConnection();// we need to open a close connection with database

            SqlCommand command = new SqlCommand(editQuery1, database.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
                DataTable table = new DataTable();//create local table in our programm where we put sql data
                string searchQuery = $"select * from {section} " + whereIDString;
                SqlCommand commandSearchForUpdated = new SqlCommand(searchQuery, database.getConnection());
                adapter.SelectCommand = commandSearchForUpdated;
                
                adapter.Fill(table);// we fill table with sql data
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    OsobaQueries osoba = new OsobaQueries(Convert.ToInt32(reader["OsobaID"]), reader["NazwiskoAktualne"].ToString(), reader["NazwiskoPoprzednie"].ToString(), reader["ImieAktualne"].ToString(), reader["ImiePoprzdnie"].ToString(), reader["NazwiskoRodoweMatki"].ToString(), reader["DataUrodzenia"].ToString(), reader["MiejsceUrodzenia"].ToString(), reader["Narodowość"].ToString(), reader["Obywatelstwo"].ToString(), reader["Płeć"].ToString(), reader["RodzajDokumentuTorzsamości"].ToString(), reader["NumerDokumentuTorzsamości"].ToString(), reader["Wykształcenie"].ToString(), reader["Zawód"].ToString(), reader["KategoriaID"].ToString(), reader["FormularzID"].ToString(), reader["NumerPESEL"].ToString(), reader["Adres"].ToString(), reader["NumerTelefonu"].ToString());
                    dataList.Add(osoba);
                }
                database.CloseConnection();
                writeToCSV(dataList);
                return table;
            }
            else
            {
                MessageBox.Show("Account wasn't updated");
            }


            return null;

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            if(curItem== "Formularz wyszukiwania")
            {

                enterIDLabel.Visible = false;
                enterIDToEditTextBox.Visible = false;
            }
            else if (curItem == "Formularz redagowania")
            {
                enterIDLabel.Visible = true;
                enterIDToEditTextBox.Visible = true;
            }
            else if (curItem == "Formularz wypelnenia")
            {

                enterIDLabel.Visible = false;
                enterIDToEditTextBox.Visible = false;
            }
            
        }

    

        private Dictionary<string,string> createDictionaryFormEditSearch()
        {
            var osobaId = osobaIDField.Text;
            var nazwiskoAktualne = nazwiskoAktualneField.Text;
            var nazwiskoPoprzednie = nazwiskoPoprzednieField.Text;
            var imieAktualne = imieAktualneField.Text;
            var imiePoprzednie = imiePoprzednieField.Text;
            var nazwiskoRodoweMatki = nazwiskoRodoweMatkiField.Text;

            var dataUrodzenia = dataUrodzeniaField.Text;
            var miejsceUrodzenia = miejsceUrodzeniaField.Text;
            var narodowość = narodowośćField.Text;
            var obywatelstwo = obywatelstwoField.Text;
            var płeć = płećField.Text;
            var rodzajDokumentuTorzsamości = rodzajDokumentuTorzsamościField.Text;

            var numerDokumentuTorzsamości = numerDokumentuTorzsamościField.Text;
            var wykształcenie = wykształcenieField.Text;
            var zawód = zawódField.Text;
            var kategoriaID = kategoriaIDField.Text;
            var formularzID = formularzIDField.Text;
            var numerPESEL = numerPESELField.Text;

            var adresID = adresIDField.Text;
            var numerTelefonu = numerTelefonuField.Text;
            var dataDictionary = new Dictionary<string, string>//it is a dictionary that consist of names of columns in database as a keys and variables created from text we got from the textboxes as values
{
    {"OsobaID", osobaId},
    {"NazwiskoAktualne", nazwiskoAktualne},
    {"NazwiskoPoprzednie", nazwiskoPoprzednie},
    {"ImieAktualne", imieAktualne},
    {"ImiePoprzdnie", imiePoprzednie},
    {"NazwiskoRodoweMatki", nazwiskoRodoweMatki},
    {"DataUrodzenia", dataUrodzenia},
    {"MiejsceUrodzenia", miejsceUrodzenia},
    {"Narodowość", narodowość},
    {"Obywatelstwo", obywatelstwo},
    {"Płeć", płeć},
    {"RodzajDokumentuTorzsamości", rodzajDokumentuTorzsamości},
    {"NumerDokumentuTorzsamości", numerDokumentuTorzsamości},
    {"Wykształcenie", wykształcenie},
    {"Zawód", zawód},
    {"KategoriaID", kategoriaID},
    {"FormularzID", formularzID},
    {"NumerPESEL", numerPESEL},
    {"Adres", adresID},
    {"NumerTelefonu", numerTelefonu},
};
            return dataDictionary;
        }

      



        private void searchButton_Click(object sender, EventArgs e)
        {
            var dataDictionary = new Dictionary<string, string>();
            dataDictionary = createDictionaryFormEditSearch();
            string section = "Osoba.Osoba";
            
            dataGridView1.DataSource = search(dataDictionary,section);//this command shows table in the windows form 

        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var dataDictionary1 = new Dictionary<string, string>();
            dataDictionary1 = createDictionaryFormEditSearch();
            string section = "Osoba.Osoba";
           
            dataGridView1.DataSource = add(dataDictionary1,section);//this command shows table in the windows form 
        }

       

        private void editButton_Click(object sender, EventArgs e)
        {
            var dataDictionary = new Dictionary<string, string>();
            dataDictionary = createDictionaryFormEditSearch();
            string section = "Osoba.Osoba";
            var enterIdToEdit = enterIDToEditTextBox.Text;
            string idInSQl = "OsobaID";
            
            dataGridView1.DataSource = edit(dataDictionary,section, enterIdToEdit,idInSQl);

        }

       

        

      

        private void labelFaktO_Click(object sender, EventArgs e)
        {
            FaktPage faktPage = new FaktPage();
            this.Hide();
            faktPage.Show();
        }

        private void labelPodmiotO_Click(object sender, EventArgs e)
        {
            PodmiotPage podmiotPage = new PodmiotPage();
            this.Hide();
            podmiotPage.Show();
        }

        private void labelRzeczO_Click(object sender, EventArgs e)
        {
            RzeczPage rzeczPage = new RzeczPage();
            this.Hide();
            rzeczPage.Show();
        }

        private void labelLogOutO_Click(object sender, EventArgs e)
        {
            GreetingPage page = new GreetingPage();
            this.Hide();
            page.Show();
        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();

            MyProfilePage profile = new MyProfilePage();
            profile.fillProfilePageWithInfo(int.Parse("1"));
            this.Hide();
            profile.Show();
        }
    }
}
