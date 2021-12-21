using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Gym
{
    public partial class List : Form
    {
        SQLiteCommand sqlite_cmd;
        public List()
        {
            InitializeComponent();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
            try
            {
                sqlite_conn.Open();
                String query = "select  name, prenom, n_cart from reg ";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                sqlite_cmd.ExecuteNonQuery();
                SQLiteDataAdapter dataadpt = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable("reg");
                dataadpt.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataadpt.Update(dt);
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rech_text_TextChanged(object sender, EventArgs e)
        {

            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
            string selc = comboBox1.Text.ToString();
            string rs = rech_text.Text.ToString();
            try
            {
                sqlite_conn.Open();
                String query = "select name, prenom, n_cart from reg where  " + selc + "='" + rs + "'";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                sqlite_cmd.ExecuteNonQuery();
                SQLiteDataAdapter dataadpt = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable("reg");
                dataadpt.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataadpt.Update(dt);
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
            DateTime now = DateTime.Today;
            try
            {
                sqlite_conn.Open();
                String query = "SELECT name, julianday(Date) - julianday(DATE('now')) as Jours_restants from reg;";
                sqlite_cmd = new SQLiteCommand(query, sqlite_conn);
                sqlite_cmd.ExecuteNonQuery();
                SQLiteDataAdapter dataadpt = new SQLiteDataAdapter(sqlite_cmd);
                DataTable dt = new DataTable("reg");
                dataadpt.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                dataadpt.Update(dt);
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
