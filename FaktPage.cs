﻿using System;
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
    public partial class FaktPage : Form,PageCommands
    {
        DataBase database = new DataBase();
        public FaktPage()
        {
            InitializeComponent();
        }
        public DataTable search(Dictionary<string, string> dict, string section)//section - name of table in db f.e. 'Osoba.Osoba'. We need it to create universal query builder for each page
        {
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
            database.CloseConnection();

            adapter.Fill(table);// we fill table with sql data
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
            string addQuery = $"INSERT INTO {section}({stringKeys1}) OUTPUT INSERTED.NumerSprawyKSIP, INSERTED.DataWydarzenia, INSERTED.CzynnościPodjętePrzezJednostkęPolicji VALUES ({stringValues1}) ";

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
            string editQuery = $"UPDATE {section} SET "; //here i try to create a string constructor for a query because we don't know which fields and how many of them were used as filter for a search

            foreach (var pair in dict)
            {
                if (!string.IsNullOrEmpty(pair.Value))
                    editQuery += $"{pair.Key} = '{pair.Value}',";
            }
            string editQuery1 = editQuery.Remove(editQuery.Length - 1);
            string whereIDString = $" WHERE {idInSQL}='{editionPosition}'; ";
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
                database.CloseConnection();
                adapter.Fill(table);// we fill table with sql data
                return table;
            }
            else
            {
                MessageBox.Show("Account wasn't updated");
            }


            return null;

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }



        private Dictionary<string, string> createDictionaryFormEditSearch()
        {
            var JednostkaPolicjiDokonującaRejestracje = JednostkaPolicjiDokonującaRejestracjeField.Text;
            var OsobaRejestrującaID= OsobaRejestrującaIDField.Text;
            var NumerSprawyKSIP = NumerSprawyKSIPField.Text;
            var DataGodzinaZgłoszeniaOWydarzeniu = DataGodzinaZgłoszeniaOWydarzeniuField.Text;
            var RodzajWydarzeniaID= RodzajWydarzeniaIDField.Text;
            var DataWydarzenia = DataWydarzeniaField.Text;

            var MiejsceWydarzenia = MiejsceWydarzeniaField.Text;
            var SposobieZawiadomieniaPolicjiOWydarzeniu = SposobieZawiadomieniaPolicjiOWydarzeniuField.Text;
            var CzynnościPodjętePrzezJednostkęPolicji = CzynnościPodjętePrzezJednostkęPolicjiField.Text;
            var RzeczZwiązanaZWydarzeniem = RzeczZwiązanaZWydarzeniemField.Text;
           
            var dataDictionary = new Dictionary<string, string>//it is a dictionary that consist of names of columns in database as a keys and variables created from text we got from the textboxes as values
{
    {"JednostkaPolicjiDokonującaRejestracje", JednostkaPolicjiDokonującaRejestracje},
    {"OsobaRejestrującaID", OsobaRejestrującaID},
    {"NumerSprawyKSIP", NumerSprawyKSIP},
    {"DataGodzinaZgłoszeniaOWydarzeniu", DataGodzinaZgłoszeniaOWydarzeniu},
    {"RodzajWydarzeniaID", RodzajWydarzeniaID},
    {"DataWydarzenia", DataWydarzenia},
    {"MiejsceWydarzenia ", MiejsceWydarzenia },
    {"SposobieZawiadomieniaPolicjiOWydarzeniu", SposobieZawiadomieniaPolicjiOWydarzeniu},
    {"CzynnościPodjętePrzezJednostkęPolicji", CzynnościPodjętePrzezJednostkęPolicji},
    {"RzeczZwiązanaZWydarzeniem", RzeczZwiązanaZWydarzeniem},
    
};
            return dataDictionary;
        }




        private void searchButtonF_Click(object sender, EventArgs e)
        {
            var dataDictionary = new Dictionary<string, string>();
            dataDictionary = createDictionaryFormEditSearch();
            string section = "Fakt.Fakt";

            dataGridViewF.DataSource = search(dataDictionary, section);//this command shows table in the windows form 

        }

        private void editButtonF_Click(object sender, EventArgs e)
        {
            var dataDictionary = new Dictionary<string, string>();
            dataDictionary = createDictionaryFormEditSearch();
            string section = "Fakt.Fakt";
            var enterIdToEdit = enterIDToEditTextBoxF.Text;
            string idInSQl = "NumerSprawyKSIP";

            dataGridViewF.DataSource = edit(dataDictionary, section, enterIdToEdit, idInSQl);
        }

        private void AddButtonF_Click(object sender, EventArgs e)
        {
            var dataDictionary1 = new Dictionary<string, string>();
            dataDictionary1 = createDictionaryFormEditSearch();
            string section = "Fakt.Fakt";

            dataGridViewF.DataSource = add(dataDictionary1, section);
        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Dzialam");
            string curItem = listBox3.SelectedItem.ToString();
            if (curItem == "Formularz wyszukiwania")
            {

                enterIDLabel.Visible = false;
                enterIDToEditTextBoxF.Visible = false;
            }
            else if (curItem == "Formularz redagowania")
            {
                enterIDLabel.Visible = true;
                enterIDToEditTextBoxF.Visible = true;
            }
            else if (curItem == "Formularz wypelnenia")

            {

                enterIDLabel.Visible = false;
                enterIDToEditTextBoxF.Visible = false;
            }
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
