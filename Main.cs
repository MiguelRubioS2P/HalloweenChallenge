using Dapper;
using HalloweenChallenge.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenChallenge
{
    public partial class MainSakila : Form
    {
        private const string connectionStringClient = "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t";
        private const string connectionStringStaff = "Server=localhost;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t";
        public MainSakila()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            List<Film> films = new List<Film>();
            MySqlConnection connection = new MySqlConnection(connectionStringStaff);
            string sql = $"select * from film where title like '%{textBoxSearch.Text}%'";
            films = connection.Query<Film>(sql).ToList();
            listBoxFilms.DataSource = films;
            listBoxFilms.DisplayMember = "title";
            connection.Close();

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //textBoxUser
            //textBoxPassword
            if(textBoxUser.Text == "guest" && textBoxPassword.Text == "£123")
            {
                pictureBoxNoLogin.Visible = true;
                enabledComponents(true);
                textBoxUser.Enabled = false;
                textBoxPassword.Enabled = false;
                buttonLogIn.Visible = false;
                buttonLogOut.Visible = true;
            }
            else
            {
                MessageBox.Show("Fail", "User Manager", MessageBoxButtons.OK);

            }

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {

        }

        private void MainSakila_Load(object sender, EventArgs e)
        {
            enabledComponents(false);
        }

        private void enabledComponents(Boolean option)
        {
            if (!option)
            {
                labelSearch.Enabled = false;
                textBoxSearch.Enabled = false;
                buttonFind.Enabled = false;
                labelFounds.Enabled = false;
                checkBoxMWW.Enabled = false;
                listBoxFilms.Enabled = false;
            }
            else
            {
                labelSearch.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonFind.Enabled = true;
                labelFounds.Enabled = true;
                checkBoxMWW.Enabled = true;
                listBoxFilms.Enabled = true;
            }
        }
    }
}
