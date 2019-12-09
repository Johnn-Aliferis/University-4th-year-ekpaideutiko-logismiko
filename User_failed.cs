using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_logismiko_v1
{
    public partial class User_failed : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string query;
        string query1;
        string query2;
        int number = 0;
        public User_failed()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
        }
        string filename;
        string filetext;
        // Setting our arrays to the appropriate length.
        List<string> QuestionsArray = new List<string>();
        List<string> Question = new List<string>();
        List<string> AnswersA = new List<string>();
        List<string> AnswersB = new List<string>();
        List<string> AnswersC = new List<string>();
        List<string> AnswersD = new List<string>();
        List<string> CorrectAnswers = new List<string>();
        List<string> UserAnswers = new List<string>();
        string question;
        string answerA;
        string answerB;
        string answerC;
        string answerD;
        string CorrectAnswer;
        int arithmos = 0;
        private void User_failed_Load(object sender, EventArgs e)
        {

            if (Main_programm.quiz_number == "1")
            {
                if (Quiz_Form.OnSyntax1 == "Yes" || Quiz_Form.OnTypography1 == "Yes" || Quiz_Form.OnLogic1 == "Yes")
                {
                    filename = "chapter1.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;   
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='1'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));      
                    }
                    rdr.Close();
                    connection.Close();
                }             
            }
            else if (Main_programm.quiz_number == "2")
            {
                if (Quiz_Form.OnSyntax2 == "Yes" || Quiz_Form.OnTypography2 == "Yes" || Quiz_Form.OnLogic2 == "Yes")
                {
                    filename = "chapter2.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='2'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();
                    connection.Close();
                }
               
            }
            else if (Main_programm.quiz_number == "3")
            {
                if (Quiz_Form.OnSyntax3 == "Yes" || Quiz_Form.OnTypography3 == "Yes" || Quiz_Form.OnLogic3 == "Yes")
                {
                    filename = "chapter3.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='3'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();
                    connection.Close();
                }    
            }
            else
            {
                if (Quiz_Form.OnLogic1 == "Yes" && Quiz_Form.OnLogic2 != "Yes" && Quiz_Form.OnLogic3 != "Yes")
                {
                    filename = "chapter1.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext; connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='1'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic2 == "Yes" && Quiz_Form.OnLogic1 != "Yes" && Quiz_Form.OnLogic3 != "Yes")
                {
                    filename = "chapter2.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='2'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic3 == "Yes" && Quiz_Form.OnLogic2 != "Yes" && Quiz_Form.OnLogic1 != "Yes")
                {
                    filename = "chapter3.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='3'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic1 == "Yes" && Quiz_Form.OnLogic2 == "Yes" && Quiz_Form.OnLogic3 != "Yes")
                {
                    filename = "chapter1,2.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='1'OR Chapter='2'" ;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                    rdr.Close();                 
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic1 == "Yes" && Quiz_Form.OnLogic3 == "Yes" && Quiz_Form.OnLogic2 != "Yes")
                {
                    filename = "chapter1,3.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='1' OR Chapter='3'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }                   
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic2 == "Yes" && Quiz_Form.OnLogic3 == "Yes" && Quiz_Form.OnLogic1 != "Yes")
                {
                    filename = "chapter2,3.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions WHERE Chapter='3' OR Chapter='2'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }               
                    connection.Close();
                }
                else if (Quiz_Form.OnLogic3 == "Yes" && Quiz_Form.OnLogic2 == "Yes" && Quiz_Form.OnLogic1 == "Yes")
                {
                    filename = "chapter1,2,3.txt";
                    filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                    connection.Open();
                    query = "SELECT * FROM More_questions";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        Question.Add(rdr.GetString(1));
                        AnswersA.Add(rdr.GetString(2));
                        AnswersB.Add(rdr.GetString(3));
                        AnswersC.Add(rdr.GetString(4));
                        AnswersD.Add(rdr.GetString(5));
                        CorrectAnswers.Add(rdr.GetString(6));
                    }
                       connection.Close();
                }
            }
            //Theories and arrays have been loaded.
            number=0;
            for (int i = 0; i < Question.Count; i++)
            {
                Question[i] = Question[i].Replace('@', '\n');
                number++;
            }
            richTextBox2.Text = Question[0];
            radioButton1.Text = AnswersA[0];
            radioButton2.Text = AnswersB[0];
            radioButton3.Text = AnswersC[0];
            radioButton4.Text = AnswersD[0];
            question_number_label.Text = "1/" + number.ToString(); 
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

        private void Back_picturebox_Click(object sender, EventArgs e)
        {
            Main_programm main = new Main_programm();
            this.Hide();
            main.ShowDialog();
        }
        int arithmos1 = 1;
        int total_correct_answers = 0;
        private void Next_question_picturebox_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                UserAnswers.Add("a");
            }
            else if (radioButton2.Checked == true)
            {
                UserAnswers.Add("b");
            }
            else if (radioButton3.Checked == true)
            {
                UserAnswers.Add("c");
            }
            else
            {
                UserAnswers.Add("d");
            }
            //got user answers
            if (arithmos1==number)
            {
                for (int i=0;i<number;i++)
                {
                    if (UserAnswers[i]==CorrectAnswers[i])
                    {
                        total_correct_answers++;
                    }
                }
                MessageBox.Show("Total correct answers : " + total_correct_answers.ToString());
                Main_programm main = new Main_programm();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                arithmos1++;
                richTextBox2.Text = Question[arithmos1 - 1];
                radioButton1.Text = AnswersA[arithmos1 - 1];
                radioButton2.Text = AnswersB[arithmos1 - 1];
                radioButton3.Text = AnswersC[arithmos1 - 1];
                radioButton4.Text = AnswersD[arithmos1 - 1];
                question_number_label.Text = arithmos1.ToString() + "/" + number.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("online-help.html");
        }
    }
}
