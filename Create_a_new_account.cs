using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ekpaideutiko_logismiko_v1
{
    public partial class Create_a_new_account : Form
    {
        string query;
        OleDbConnection connection = new OleDbConnection();
        public Create_a_new_account()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
        }

        private void Create_a_new_account_Load(object sender, EventArgs e)
        {

        }

        int counter_for_username_textbox = 0;

        private void Username_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (counter_for_username_textbox == 0 && value_for_username == 0)
            {
                Username_textbox.Text = "";
                counter_for_username_textbox++;
            }
        }

        int counter_for_password_textbox = 0;
        private void Password_textbox_MouseEnter_1(object sender, EventArgs e)
        {
            if (counter_for_password_textbox == 0 && value_for_password == 0)
            {
                Password_textbox.Text = "";
                counter_for_password_textbox++;
            }
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

        int counter_for_email_textbox = 0;
        private void Email_textbox_MouseEnter(object sender, EventArgs e)
        {
            if (counter_for_email_textbox == 0 && value_for_email == 0)
            {
                Email_textbox.Text = "";
                counter_for_email_textbox++;
            }
        }

        private void Go_back_button_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        int value_for_username = 0;
        private void Username_textbox_OnValueChanged(object sender, EventArgs e)
        {
            value_for_username++;
        }
        int value_for_password = 0;
        private void Password_textbox_OnValueChanged(object sender, EventArgs e)
        {
            value_for_password++;
        }
        int value_for_email = 0;
        private void Email_textbox_OnValueChanged(object sender, EventArgs e)
        {
            value_for_email++;
        }

        // user can only input letters, digits , the character "-"  and back
        private void Username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                if (Username_textbox.Text.Length >= 8)
                {
                    e.Handled = true;
                    if (e.KeyChar == (char)Keys.Back)
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

        private void Login_button_Click(object sender, EventArgs e)
        {
            // checking if password and username are empty!
            if (Password_textbox.Text != "" && Username_textbox.Text != "")
            {
                if (Username_textbox.Text.Length <= 8)
                {
                    Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = reg.Match(Email_textbox.Text);
                    if (match.Success)
                    //everything is valid !
                    {
                        connection.Open();
                        query = "SELECT * FROM Table1 WHERE Username='" + Username_textbox.Text + "' and Email='" + Email_textbox.Text + "'";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        OleDbDataReader reader = command.ExecuteReader();
                        int counter = 0;
                        while (reader.Read())
                        {
                            counter++;
                        }
                        if (counter != 0)
                        {
                            MessageBox.Show("This user already exists, please choose different information!");
                        }
                        connection.Close();
                        if (counter == 0)
                        {
                            connection.Open();
                            OleDbCommand command1 = new OleDbCommand();
                            command1.Connection = connection;
                            command1.CommandText = "insert into Table1 (Username,[Password],Email) values ('" + Username_textbox.Text + "','" + Password_textbox.Text + "','" + Email_textbox.Text + "')";
                            command1.ExecuteNonQuery();
                            command1.CommandText = "insert into Table2 (Username,TheoryOne,TheoryTwo,TheoryThree) values ('" + Username_textbox.Text + "','" + 0.ToString() + "','" + 0.ToString() + "','" + 0.ToString() + "')";
                            command1.ExecuteNonQuery();
                            command1.CommandText = "insert into User_theories (Username,ErrorOnSyntax1st,ErrorOnSyntax2nd,ErrorOnSyntax3rd,ErrorOnTypography1st,ErrorOnTypography2nd,ErrorOnTypography3rd,ErrorOnLogic1st,ErrorOnLogic2nd,ErrorOnLogic3rd,Scores_first,Scores_second,Scores_third,Scores_fourth) values ('" + Username_textbox.Text + "','No','No','No','No','No','No','No','No','No','0','0','0','0')";
                            command1.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Successful  registration! ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid email address");
                    }
                }
                else
                {
                    MessageBox.Show("Username is too big! It must be up to 8 charactes max !");
                }
            }
            else
            {
                MessageBox.Show("Don't leave empty any fields!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("online-help.html");
        }
    }
}
