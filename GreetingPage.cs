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
    public partial class GreetingPage : Form
    {
        public GreetingPage()
        {
            InitializeComponent();
        }

        private void KSIP_Click(object sender, EventArgs e)
        {

        }
        /*lead you to registration page from GreetingPage*/
        private void button1_Click(object sender, EventArgs e)
        {
            Registration registrationPage = new Registration();
            this.Hide();
            registrationPage.Show();
        }
        /*lead you to authorization page from GreetingPage*/
        private void button2_Click(object sender, EventArgs e)
        {
            Authorization authorizationPage = new Authorization();
            this.Hide();
            authorizationPage.Show();
        }
        /*lead you directly to MainPage without authorization*/
        private void mainLoginGuestButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }
    }
}
