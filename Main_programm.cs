using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_logismiko_v1
{
    public partial class Main_programm : Form
    {
        public static string quiz_number;
        string query;
        OleDbConnection connection = new OleDbConnection();
        string filename;
        public Main_programm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
        }

        private void Main_programm_Load(object sender, EventArgs e)
        {
            User_label.Text = Form1.username_logged_in;
            Theories_panel.Visible = false;
            Statistics_panel.Visible = false;
        }

        private void Exit_picturebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_picturebox_MouseEnter(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_red;
        }

        private void Exit_picturebox_MouseLeave(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_white;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Log out button 
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
        // user clicks on review theory button when he first sign in to the application.
        // When user presses this button first chapter of theory appears on screen.

        private void Review_theory_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Showing how many times user has viewed this theory
                connection.Open();
                first_theory_number++;
                query = "SELECT TheoryOne FROM Table2 WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                number_of_times1 = Int32.Parse(command.ExecuteScalar().ToString());
                number_of_times1++;
                query = "UPDATE Table2 SET TheoryOne='" + number_of_times1 + "' WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command1 = new OleDbCommand(query, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                Have_visited_label.Text = "You have visited this theory : " + number_of_times1 + " times";
                // Database ends here for viewing number of times user has viewed this theory level .
                Theory_one_button.Enabled = false;
                Theory_two_button.Enabled = false;
                Theory_three_button.Enabled = false;
                timer_for_exception.Enabled = true;
                filename = "if-else statements.pdf";
                axAcroPDF1.LoadFile(filename);
                Theories_panel.Visible = true;
                Review_theory_button.Visible = false;
                Take_quiz_button.Visible = false;
                Welcome_label.Visible = false;
                Statistics_panel.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured , please try again!");
            }
        }
        // user clicks ontake quiz button when he first sign in to the application.
        // When user presses this button first quiz appears on screen.
        private void Take_quiz_button_Click(object sender, EventArgs e)
        {
            quiz_number = "1";
            Quiz_Form frm = new Quiz_Form();
            this.Hide();
            frm.ShowDialog();
            Review_theory_button.Visible = false;
            Take_quiz_button.Visible = false;
            Welcome_label.Visible = false;
        }
        int first_theory_number=0;
        int number_of_times1;
        private void Theory_one_button_Click(object sender, EventArgs e)
        {
            // Showing how many times user has viewed this theory
                connection.Open();
                first_theory_number++;
                query = "SELECT TheoryOne FROM Table2 WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                number_of_times1 = Int32.Parse(command.ExecuteScalar().ToString());
                number_of_times1++;
                query = "UPDATE Table2 SET TheoryOne='" + number_of_times1 + "' WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command1 = new OleDbCommand(query, connection);
                command1.ExecuteNonQuery();
                connection.Close();
            // Database ends here for viewing number of times user has viewed this theory level .
                Have_visited_label.Text = "You have visited this theory : " + number_of_times1 + " times";
                Theory_one_button.Enabled = false;
                Theory_two_button.Enabled = false;
                Theory_three_button.Enabled = false;
                timer_for_exception.Enabled = true;
                filename = "if-else statements.pdf";
                axAcroPDF1.LoadFile(filename);
                Theories_panel.Visible = true;
                Review_theory_button.Visible = false;
                Take_quiz_button.Visible = false;
                Welcome_label.Visible = false;
            Statistics_panel.Visible = false;
        }
        int second_theory_number = 0;
        int number_of_times2;
        private void Theory_two_button_Click(object sender, EventArgs e)
        {
            // Showing how many times user has viewed this theory
            connection.Open();
            second_theory_number++;
            query = "SELECT TheoryTwo FROM Table2 WHERE Username='" + Form1.username_logged_in + "'";
            OleDbCommand command = new OleDbCommand(query, connection);
            number_of_times2 = Int32.Parse(command.ExecuteScalar().ToString());
            number_of_times2++;
            query = "UPDATE Table2 SET TheoryTwo='" + number_of_times2 + "' WHERE Username='" + Form1.username_logged_in + "'";
            OleDbCommand command1 = new OleDbCommand(query, connection);
            command1.ExecuteNonQuery();
            connection.Close();
            Have_visited_label.Text = "You have visited this theory : " + number_of_times2 + " times";
            // Database ends here for viewing number of times user has viewed this theory level .
            Theory_one_button.Enabled = false;
            Theory_two_button.Enabled = false;
            Theory_three_button.Enabled = false;
            timer_for_exception.Enabled = true;
            filename = "Loops.pdf";
            axAcroPDF1.LoadFile(filename);
            Theories_panel.Visible = true;
            Review_theory_button.Visible = false;
            Take_quiz_button.Visible = false;
            Welcome_label.Visible = false;
            Statistics_panel.Visible = false;
        }
        int third_theory_number = 0;
        int number_of_times3;
        private void Theory_three_button_Click(object sender, EventArgs e)
        {
            // Showing how many times user has viewed this theory
            connection.Open();
            third_theory_number++;
            query = "SELECT TheoryThree FROM Table2 WHERE Username='" + Form1.username_logged_in + "'";
            OleDbCommand command = new OleDbCommand(query, connection);
            number_of_times3 = Int32.Parse(command.ExecuteScalar().ToString());
            number_of_times3++;
            query = "UPDATE Table2 SET TheoryThree='" + number_of_times3 + "' WHERE Username='" + Form1.username_logged_in + "'";
            OleDbCommand command1 = new OleDbCommand(query, connection);
            command1.ExecuteNonQuery();
            connection.Close();
            Have_visited_label.Text = "You have visited this theory : " + number_of_times3 + " times";
            // Database ends here for viewing number of times user has viewed this theory level .
            Theory_one_button.Enabled = false;
            Theory_two_button.Enabled = false;
            Theory_three_button.Enabled = false;
            Statistics_panel.Visible = false;
            timer_for_exception.Enabled = true;
            filename = "Data structures.pdf";
            try
            {
                axAcroPDF1.LoadFile(filename);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured , please try again!");
            }
            Theories_panel.Visible = true;
            Review_theory_button.Visible = false;
            Take_quiz_button.Visible = false;
            Welcome_label.Visible = false;
        }
        int counter = 0;
        private void timer_for_exception_Tick(object sender, EventArgs e)
        {
            if (counter < 1 )
            {
                counter++;
                Theory_one_button.Enabled = true;
                Theory_two_button.Enabled = true;
                Theory_three_button.Enabled = true;
                counter = 0;
            }
        }

        private void Quiz_button_one_Click(object sender, EventArgs e)
        {
            quiz_number = "1";
            Quiz_Form frm = new Quiz_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void Quiz_button_two_Click(object sender, EventArgs e)
        {
            quiz_number = "2";
            Quiz_Form frm = new Quiz_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void Quiz_button_three_Click(object sender, EventArgs e)
        {
            quiz_number = "3";
            Quiz_Form frm = new Quiz_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void Quiz_button_all_theories_Click(object sender, EventArgs e)
        {
            quiz_number = "4";
            Quiz_Form frm = new Quiz_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
        string SyntaxOne;
        string SyntaxTwo;
        string SyntaxThree;
        string LogicOne;
        string LogicTwo;
        string LogicThree;
        string TypographyOne;
        string TypographyTwo;
        string TypographyThree;
        int scores_first;
        int scores_second;
        int scores_third;
        int scores_fourth;
        private void Stats_button_Click(object sender, EventArgs e)
        {
            Theories_panel.Visible = false;
            User_label1.Text = Form1.username_logged_in;
            Statistics_panel.Visible = true;
            connection.Open();
            query = "SELECT * FROM User_theories WHERE Username='" + Form1.username_logged_in + "'";
            OleDbCommand command2 = new OleDbCommand(query, connection);
            OleDbDataReader rdr = command2.ExecuteReader();
            while (rdr.Read())
            {
                SyntaxOne = rdr.GetString(2);
                SyntaxTwo = rdr.GetString(3);
                SyntaxThree = rdr.GetString(4);
                TypographyOne = rdr.GetString(5);
                TypographyTwo = rdr.GetString(6);
                TypographyThree = rdr.GetString(7);
                LogicOne = rdr.GetString(8);
                LogicTwo = rdr.GetString(9);
                LogicThree = rdr.GetString(10);
                scores_first = rdr.GetInt32(11);
                scores_second = rdr.GetInt32(12);
                scores_third = rdr.GetInt32(13);
                scores_fourth = rdr.GetInt32(14);
            }
            Syntax1st.Text ="Difficulty in 1st Syntax: "+ SyntaxOne;
            Syntax2nd.Text = "Difficulty in 2nd Syntax: " +SyntaxTwo;
            Syntax3rd.Text = "Difficulty in 3rd Syntax: "+SyntaxThree;
            Typography1st.Text = "Difficulty in 1st Typography: " +TypographyOne;
            Typography2nd.Text = "Difficulty in 2nd Typography: " + TypographyTwo;
            Typography3rd.Text = "Difficulty in 3rd Typography: " + TypographyThree;
            Logic1st.Text = "Difficulty in 1st Logic: " + LogicOne;
            Logic2nd.Text = "Difficulty in 2nd Logic: " + LogicTwo;
            Logic3rd.Text = "Difficulty in 3rd Logic: " + LogicThree;
            First_quiz_label.Text = "First Quiz: " + scores_first.ToString();
            Second_quiz_label.Text = "Second Quiz: " + scores_second.ToString();
            Third_quiz_label.Text = "Third Quiz: " + scores_third.ToString();
            Fourth_quiz_label.Text = "Fourth Quiz: " + scores_fourth.ToString();
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("online-help.html");
        }
    }
}
