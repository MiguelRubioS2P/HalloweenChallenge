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
        bool staff;
        string userStaff;
        public MainSakila()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            if (staff)
            {
                if (!checkBoxMWW.Checked)
                {
                    List<Film> films = new List<Film>();
                    MySqlConnection connection = new MySqlConnection(connectionStringStaff);
                    string sql = $"select * from film where title like '%{textBoxSearch.Text}%'";
                    films = connection.Query<Film>(sql).ToList();
                    listBoxFilms.DataSource = films;
                    listBoxFilms.DisplayMember = "title";
                    labelFounds.Text = films.Count + " records founds";
                    connection.Close();
                }
                else
                {
                    List<Film> films = new List<Film>();
                    MySqlConnection connection = new MySqlConnection(connectionStringStaff);
                    string sql = $"select * from film where title like '{textBoxSearch.Text}%' or title like '%{textBoxSearch.Text}'";
                    films = connection.Query<Film>(sql).ToList();
                    listBoxFilms.DataSource = films;
                    listBoxFilms.DisplayMember = "title";
                    labelFounds.Text = films.Count + " records founds";
                    connection.Close();
                }
            }
            else
            {
                if (!checkBoxMWW.Checked)
                {
                    List<Film> films = new List<Film>();
                    MySqlConnection connection = new MySqlConnection(connectionStringClient);
                    string sql = $"select * from film where title like '%{textBoxSearch.Text}%'";
                    films = connection.Query<Film>(sql).ToList();
                    listBoxFilms.DataSource = films;
                    listBoxFilms.DisplayMember = "title";
                    labelFounds.Text = films.Count + " records founds";
                    connection.Close();
                }
                else
                {
                    List<Film> films = new List<Film>();
                    MySqlConnection connection = new MySqlConnection(connectionStringClient);
                    string sql = $"select * from film where title like '{textBoxSearch.Text}%' or title like '%{textBoxSearch.Text}'";
                    films = connection.Query<Film>(sql).ToList();
                    listBoxFilms.DataSource = films;
                    listBoxFilms.DisplayMember = "title";
                    labelFounds.Text = films.Count + " records founds";
                    connection.Close();
                }
            }

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //textBoxUser
            //textBoxPassword

            if(textBoxUser.Text == "guest")
            {
                if (textBoxUser.Text == "guest" && textBoxPassword.Text == "£123")
                {
                    pictureBoxNoLogin.Visible = true;
                    enabledComponents(true);
                    textBoxUser.Enabled = false;
                    textBoxPassword.Enabled = false;
                    buttonLogIn.Visible = false;
                    buttonLogOut.Visible = true;
                    staff = false;
                    tabControlMain.SelectedIndex = 1;
                    labelTag.Visible = false;
                }
                else
                {
                    MessageBox.Show("Fail client", "User Manager", MessageBoxButtons.OK);
                    textBoxUser.Text = string.Empty;
                    textBoxPassword.Text = string.Empty;
                }
            }
            else
            {
                //£456
                MySqlConnection connection = new MySqlConnection(connectionStringStaff);
                string sql = $"select username from staff where first_name like '{textBoxUser.Text}'";
                string user = connection.Query<string>(sql).FirstOrDefault();
                userStaff = user;

                if (textBoxUser.Text == user && textBoxPassword.Text == "£456")
                {

                    pictureBoxNoLogin.Visible = false;
                    enabledComponents(true);
                    textBoxUser.Enabled = false;
                    textBoxPassword.Enabled = false;
                    buttonLogIn.Visible = false;
                    buttonLogOut.Visible = true;
                    staff = true;
                    labelTag.Visible = true;
                    labelTag.Text = "Mr." + userStaff;
                    tabControlMain.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("Fail staff", "User Manager", MessageBoxButtons.OK);
                    textBoxUser.Text = string.Empty;
                    textBoxPassword.Text = string.Empty;
                }
            }


        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            buttonLogOut.Visible = false;
            buttonLogIn.Visible = true;
            textBoxUser.Enabled = true;
            textBoxPassword.Enabled = true;
            enabledComponents(false);
            pictureBoxNoLogin.Visible = true;
            labelTag.Visible = false;


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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //userStaff have value username connect
            //UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;
            MySqlConnection connection = new MySqlConnection(connectionStringStaff);
            string sql = $"Update staff set email = '{textBoxEmail.Text}' where username like '{userStaff}'";

            try
            {

                var rowsAffected = connection.Execute(sql);

                if (rowsAffected == 1)
                {
                    
                    MessageBox.Show("Update correctly", "User Manager", MessageBoxButtons.OK);

                    textBoxEmail.Text = string.Empty;

                }

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                Console.WriteLine("Warning: Exception thrown " + ex.Message);
                MessageBox.Show("Fail update", "User Manager", MessageBoxButtons.OK);
                textBoxEmail.Text = string.Empty;

            }


            connection.Close();
        }

        private void listBoxFilms_DoubleClick(object sender, EventArgs e)
        {
            
            Film selectedFilm = listBoxFilms.SelectedItem as Film;

            FilmDetails modal = new FilmDetails(selectedFilm);

            DialogResult result = modal.ShowDialog(this);

            modal.Dispose();
        }
    }
}
