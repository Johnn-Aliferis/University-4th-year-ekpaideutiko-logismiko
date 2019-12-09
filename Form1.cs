using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ekpaideutiko_logismiko_v1
{
    public partial class Form1 : Form
    {
        public static string username_logged_in;
        OleDbConnection connection = new OleDbConnection();
        string query;
        string username;
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void New_account_label_MouseEnter(object sender, EventArgs e)
        {
            New_account_label.ForeColor = Color.White;
        }

        private void New_account_label_MouseLeave(object sender, EventArgs e)
        {
            New_account_label.ForeColor = Color.LightBlue;
        }

        private void Exit_picturebox_MouseEnter(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_red;
        }

        private void Exit_picturebox_MouseLeave(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_white;
        }

        private void Exit_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if(Username_textbox.Text=="" || Password_textbox.Text=="") 
            {
                MessageBox.Show("Don't leave empty fields !");
            }
            else
            {
                try
                {
                    connection.Open();
                    query = "SELECT * FROM Table1 WHERE Username='" + Username_textbox.Text + "' and [Password]='" + Password_textbox.Text + "'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    int counter = 0;
                    while (reader.Read())
                    {
                        counter++;
                        username = reader.GetString(1);
                    }

                    connection.Close();
                    if (counter == 0)
                    {
                        MessageBox.Show("Invalid information! Check your inputs or if you don't have an account click on Create a new account to create one!");
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + username);
                        username_logged_in = username;
                        Main_programm programm = new Main_programm();
                        this.Hide();
                        programm.ShowDialog();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured , please try again!");
                }
            }
                
            }

        int username_value_changed = 0;
        private void Username_textbox_OnValueChanged(object sender, EventArgs e)
        {
            username_value_changed++;
        }
        int password_value_changed = 0;
        private void Password_textbox_OnValueChanged(object sender, EventArgs e)
        {
            password_value_changed++;
        }

        private void New_account_label_Click(object sender, EventArgs e)
        {
            Create_a_new_account create = new Create_a_new_account();
            this.Hide();
            create.ShowDialog();
        }

        // user can only input letters, digits , the character "-"  and back
        private void Username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back  && e.KeyChar != '-' )
            {
                e.Handled = true;
            }
            else
            {
                if (Username_textbox.Text.Length >= 8)
                {
                        e.Handled = true;
                    if (e.KeyChar==(char)Keys.Back)
                    {
                        e.Handled = false;
                    }
                }
            }
        }

        private void Password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("online-help.html");
        }
    }
}
