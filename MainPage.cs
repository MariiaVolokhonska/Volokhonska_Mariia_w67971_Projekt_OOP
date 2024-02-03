using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_OOP
{
    public partial class MainPage : Form
    {
        public string autLog;
        public MainPage()
        {
            InitializeComponent();
            autLog = "1";


        }

        private void label1_Click(object sender, EventArgs e)
        {
            OsobaPage osobaPage = new OsobaPage();
            this.Hide();
            osobaPage.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Authorization aut = new Authorization();
            
            MyProfilePage profile = new MyProfilePage();
            profile.fillProfilePageWithInfo(int.Parse(autLog));
            this.Hide();
            profile.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GreetingPage page = new GreetingPage();
            this.Hide();
            page.Show();
        }

        private void rzeczButton_Click(object sender, EventArgs e)
        {
            RzeczPage rzeczPage = new RzeczPage();
            this.Hide();
            rzeczPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FaktPage faktPage = new FaktPage();
            this.Hide();
            faktPage.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            PodmiotPage podmiotPage = new PodmiotPage();
            this.Hide();
            podmiotPage.Show();
        }

        private void linkLabelOsobyZaginione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewOsobyZaginione zagOsPage = new ViewOsobyZaginione();
            zagOsPage.ShowLostPeople();
            this.Hide();
            zagOsPage.Show();

        }
    }
}
