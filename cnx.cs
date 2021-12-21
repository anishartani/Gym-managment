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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();

            var pos = this.PointToScreen(cnx_lab.Location);
            pos = cnx_backg.PointToClient(pos);
            cnx_lab.Parent = cnx_backg;
            cnx_lab.Location = pos;
            cnx_lab.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(user_lab.Location);
            pos1 = cnx_backg.PointToClient(pos1);
            user_lab.Parent = cnx_backg;
            user_lab.Location = pos1;
            user_lab.BackColor = Color.Transparent;


            var pos2 = this.PointToScreen(pass_lab.Location);
            pos2 = cnx_backg.PointToClient(pos2);
            pass_lab.Parent = cnx_backg;
            pass_lab.Location = pos2;
            pass_lab.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(pictureBox1.Location);
            pos3 = cnx_backg.PointToClient(pos3);
            pictureBox1.Parent = cnx_backg;
            pictureBox1.Location = pos3;
            pictureBox1.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection cnx = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
                SQLiteCommand SelectCommand = new SQLiteCommand("select * from user where name='" + this.user_text.Text + "'and pass='" + this.user_pass.Text + "';", cnx);
                SQLiteDataReader myReader;
                cnx.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Connexion approuvée");
                    this.Hide();
                    Form2 f3 = new Form2();
                    f3.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Connexion refusée");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void user_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    SQLiteConnection cnx = new SQLiteConnection(@"Data Source=.\Data.db;Version=3");
                    SQLiteCommand SelectCommand = new SQLiteCommand("select * from user where name='" + this.user_text.Text + "'and pass='" + this.user_pass.Text + "';", cnx);
                    SQLiteDataReader myReader;
                    cnx.Open();
                    myReader = SelectCommand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Connexion approuvée");
                        this.Hide();
                        Form2 f3 = new Form2();
                        f3.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Connexion refusée");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
        
    
