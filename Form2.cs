using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Gym
{
    public partial class Form2 : Form
    {
        SQLiteCommand sqlite_cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nom_text.Text))
            {
                MessageBox.Show("le nom ne doit pas être vide");
            }
            else if (string.IsNullOrEmpty(Prenom_text.Text))
            {
                MessageBox.Show("le prénom ne doit pas être vide");
            }
            else if (string.IsNullOrEmpty(Cart_text.Text))
            {
                MessageBox.Show("le numero de la cart national ne doit pas être vide");
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Veuillez sélectionner combien de mois");
            }
            else
            {
                SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
                string m = comboBox1.Text.ToString();
                try
                {
                    DateTime today = DateTime.Today;
                    if (m == "01 mois")
                    {
                        today = today.AddMonths(1);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "02 mois")
                    {
                        today = today.AddMonths(2);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "03 mois")
                    {
                        today = today.AddMonths(3);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "04 mois")
                    {
                        today = today.AddMonths(4);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "05 mois")
                    {
                        today = today.AddMonths(5);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "06 mois")
                    {
                        today = today.AddMonths(6);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "07 mois")
                    {
                        today = today.AddMonths(7);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "08 mois")
                    {
                        today = today.AddMonths(8);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "09 mois")
                    {
                        today = today.AddMonths(9);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "10 mois")
                    {
                        today = today.AddMonths(10);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Prenom_text.Text + "','" + this.Nom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "11 mois")
                    {
                        today = today.AddMonths(11);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }
                    else if (m == "12 mois")
                    {
                        today = today.AddMonths(12);
                        var j = today.ToString("yyyy-MM-dd");
                        sqlite_conn.Open();
                        string query = "insert into reg (name, prenom, n_cart, Date) values('" + this.Nom_text.Text + "','" + this.Prenom_text.Text + "','" + this.Cart_text.Text + "','" + j + "')";
                        sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                        sqlite_cmd.ExecuteNonQuery();
                        MessageBox.Show("saved");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
