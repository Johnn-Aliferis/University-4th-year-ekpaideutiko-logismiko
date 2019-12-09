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
    
    public partial class Quiz_Form : Form
    {
        public static  int counter = 0;
        public static string OnSyntax1;
        public static string OnSyntax2;
        public static string OnSyntax3;
        public static string OnLogic1;
        public static string OnLogic2;
        public static string OnLogic3;
        public static string OnTypography1;
        public static string OnTypography2;
        public static string OnTypography3;
        string query;
        string query1;
        int question_counter = 1;
        OleDbConnection connection = new OleDbConnection();
        public Quiz_Form()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb";
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
        string question;
        string answerA;
        string answerB;
        string answerC;
        string answerD;
        string CorrectAnswer;
        int arithmos = 0;
        string[] questionsArray = new String[15];
        string[] AnswersA = new String[15];
        string[] AnswersB= new String[15];
        string[] AnswersC = new String[15];
        string[] AnswersD = new String[15];
        string[] CorrectAnswers = new String[15];
        string[] UserAnswers = new String[15];

        string quiz;
        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            Quiz_label.Text = "Quiz #" + Main_programm.quiz_number;
            if (Main_programm.quiz_number=="1")
            {
                quiz = "Quiz1";
                Type_of_question_label.Text = "Syntax";
            }
            else if (Main_programm.quiz_number == "2")
            {
                quiz = "Quiz2";
                Type_of_question_label.Text = "Syntax";
            }
            else if (Main_programm.quiz_number == "3")
            {
                quiz = "Quiz3";
                Type_of_question_label.Text = "Syntax";
            }
            else
            {
                quiz = "Quiz4";
                Type_of_question_label.Text = "Logical";
            }
            connection.Open();
            query = "SELECT * FROM "+quiz;
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                //Getting multiple choices and correct answers from database and storing into arrays.
                question = rdr.GetString(1);
                answerA = rdr.GetString(2);
                answerB = rdr.GetString(3);
                answerC = rdr.GetString(4);
                answerD = rdr.GetString(5);
                CorrectAnswer = rdr.GetString(6);
                questionsArray[arithmos] = question;
                AnswersA[arithmos] = answerA;
                AnswersB[arithmos] = answerB;
                AnswersC[arithmos] = answerC;
                AnswersD[arithmos] = answerD;
                CorrectAnswers[arithmos] = CorrectAnswer;
                arithmos++;
            }
            for (int i = 0; i < arithmos; i++)
            {
                questionsArray[i]=questionsArray[i].Replace('@', '\n');
            }
            richTextBox1.Text = questionsArray[0];
            radioButton1.Text = "A ) " + AnswersA[0];
            radioButton2.Text = "B ) " + AnswersB[0];
            radioButton3.Text = "C ) " + AnswersC[0];
            radioButton4.Text = "D ) " + AnswersD[0];
            connection.Close();
        }

        private void Exit_picturebox_MouseEnter(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_red;
        }

        private void Exit_picturebox_MouseLeave(object sender, EventArgs e)
        {
            Exit_picturebox.Image = Properties.Resources.exit_white;
        }
        int counter_of_correct_syntax_questions=0;
        int counter_of_correct_typographical_questions = 0;
        int counter_of_correct_logical_questions = 0;
        int total_correct_answers = 0;
        int counter_for_first_chapter = 0;
        int counter_for_second_chapter = 0;
        int counter_for_third_chapter = 0;
        private void Next_question_picturebox_Click(object sender, EventArgs e)
        {
            // storing into UserAnswers array the choices of user for each question.
            if (radioButton1.Checked == true)
            {
                UserAnswers[question_counter - 1] = "a";
            }
            else if (radioButton2.Checked==true)
            {
                UserAnswers[question_counter - 1] = "b";
            }
            else if (radioButton3.Checked == true)
            {
                UserAnswers[question_counter - 1] = "c";
            }
            else
            {
                UserAnswers[question_counter - 1] = "d";
            }
            question_counter++;
            // stored in UserAnswers.
            //Chaning label according to the number  and type of questions.
            if (question_counter<=15)
            {
                question_number_label.Text = question_counter.ToString() + "/15";
            }
            if (Main_programm.quiz_number!="4")
            {

                if (question_counter <= 5)
                {
                    Type_of_question_label.Text = "Syntax";

                }
                else if (question_counter > 5 && question_counter <= 10)
                {
                    Type_of_question_label.Text = "Typographical";
                }
                else
                {
                    Type_of_question_label.Text = "Logical";
                }
            }
            else
            {
                Type_of_question_label.Text = "Logical";
            }
            //Changed.
            if (question_counter<=15)
            {
                richTextBox1.Text = questionsArray[question_counter - 1];
                radioButton1.Text = "A ) " + AnswersA[question_counter - 1];
                radioButton2.Text = "B ) " + AnswersB[question_counter - 1];
                radioButton3.Text = "C ) " + AnswersC[question_counter - 1];
                radioButton4.Text = "D ) " + AnswersD[question_counter - 1];
            }
            else
            {
                //user has answered all of the questions listed.
                for (int i = 1; i <= 15; i++)
                {
                    if (i<=5)
                    {
                        if (Main_programm.quiz_number!="4")
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_of_correct_syntax_questions++;
                            }
                        }
                        else
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_for_first_chapter++;
                            }
                        }
                        
                    }
                    else if (i>5 && i <= 10)
                    {
                        if (Main_programm.quiz_number != "4")
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_of_correct_typographical_questions++;
                            }
                        }
                        else
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_for_second_chapter++;
                            }
                        }
                    }
                    else
                    {
                        if (Main_programm.quiz_number != "4")
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_of_correct_logical_questions++;
                            }
                        }
                        else
                        {
                            if (UserAnswers[i-1] == CorrectAnswers[i-1])
                            {
                                counter_for_third_chapter++;
                            }
                        }
                    }
                    if (UserAnswers[i-1]==CorrectAnswers[i-1])
                    {
                        // finding total correct answers of the user!
                        total_correct_answers++;
                    }
                }
                if (Main_programm.quiz_number!="4")
                {
                    MessageBox.Show("Total correct answers : " + total_correct_answers.ToString() +"\n" +"Correct answers on syntax : "+counter_of_correct_syntax_questions.ToString()+"\n" + "Correct answers on typography : " + counter_of_correct_typographical_questions.ToString() + "\n"+ "Correct answers on logic : " + counter_of_correct_logical_questions.ToString() + "\n");
                }
                else
                {
                    MessageBox.Show("Total correct answers : " + total_correct_answers.ToString() + "\n" + "Correct answers on first chapter : " + counter_for_first_chapter.ToString() + "\n" + "Correct answers on second chapter : " + counter_for_second_chapter.ToString() + "\n" + "Correct answers on third_chapter : " + counter_for_third_chapter.ToString() + "\n");
                }
                // get from database all difficulties for user!
                connection.Open();
                query = "SELECT * FROM User_theories WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command3 = new OleDbCommand(query, connection);
                OleDbDataReader rdr = command3.ExecuteReader();
                while (rdr.Read())
                {
                    OnSyntax1 = rdr.GetString(2);
                    OnSyntax2 = rdr.GetString(3);
                    OnSyntax3 = rdr.GetString(4);
                    OnTypography1 = rdr.GetString(5);
                    OnTypography2 = rdr.GetString(6);
                    OnTypography3 = rdr.GetString(7);
                    OnLogic1 = rdr.GetString(8);
                    OnLogic2 = rdr.GetString(9);
                    OnLogic3 = rdr.GetString(10);
                }
                connection.Close();
                if (Main_programm.quiz_number=="1")
                {
                    if (counter_of_correct_syntax_questions<3)
                    {
                        OnSyntax1 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnSyntax1 = "No";
                    }
                    if (counter_of_correct_typographical_questions<3)
                    {
                        OnTypography1 = "Yes";
                        counter+=3; 
                    }
                    else
                    {
                        OnTypography1 = "No";
                    }
                    if (counter_of_correct_logical_questions<3)
                    {
                        OnLogic1 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic1 = "No";
                    }
                }
                else if (Main_programm.quiz_number=="2")
                {
                    if (counter_of_correct_syntax_questions < 3)
                    {
                        OnSyntax2 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnSyntax2 = "No";
                    }
                    if (counter_of_correct_typographical_questions < 3)
                    {
                        OnTypography2 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnTypography2 = "No";
                    }
                    if (counter_of_correct_logical_questions < 3)
                    {
                        OnLogic2 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic2 = "No";
                    }
                }
                else if (Main_programm.quiz_number == "3")
                {
                    if (counter_of_correct_syntax_questions < 3)
                    {
                        OnSyntax3 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnSyntax3 = "No";
                    }
                    if (counter_of_correct_typographical_questions < 3)
                    {
                        OnTypography3 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnTypography3 = "No";
                    }
                    if (counter_of_correct_logical_questions < 3)
                    {
                        OnLogic3 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic3 = "No";
                    }
                }
                else
                {
                    if (counter_for_first_chapter < 3)
                    {
                        OnLogic1 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic1 = "No";
                    }
                    if (counter_for_second_chapter < 3)
                    {
                        OnLogic2 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic2 = "No";
                    }
                    if (counter_for_third_chapter < 3)
                    {
                        OnLogic3 = "Yes";
                        counter+=3;
                    }
                    else
                    {
                        OnLogic3= "No";
                    }
                }
                connection.Open();
                query1 = "UPDATE User_theories SET ErrorOnSyntax1st='" + OnSyntax1 +"',ErrorOnSyntax2nd='"+  OnSyntax2+ "',ErrorOnSyntax3rd='" + OnSyntax3 + "',ErrorOnTypography1st='" + OnTypography1 + "',ErrorOnTypography2nd='" + OnTypography2 + "',ErrorOnTypography3rd='" + OnTypography3 + "',ErrorOnLogic1st='" + OnLogic1 + "',ErrorOnLogic2nd='" + OnLogic2 + "',ErrorOnLogic3rd='" + OnLogic3 + "' WHERE Username='" + Form1.username_logged_in + "'";
                OleDbCommand command1 = new OleDbCommand(query1, connection);
                command1.ExecuteNonQuery();
                connection.Close();
                if (Main_programm.quiz_number=="1")
                {
                    connection.Open();
                    query1 = "UPDATE User_theories SET Scores_first='" + total_correct_answers + "' WHERE Username='" + Form1.username_logged_in + "'";
                    OleDbCommand command2 = new OleDbCommand(query1, connection);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
                else if (Main_programm.quiz_number == "2")
                {
                    connection.Open();
                    query1 = "UPDATE User_theories SET Scores_second='" + total_correct_answers + "' WHERE Username='" + Form1.username_logged_in + "'";
                    OleDbCommand command2 = new OleDbCommand(query1, connection);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
                else if (Main_programm.quiz_number == "3")
                {
                    connection.Open();
                    query1 = "UPDATE User_theories SET Scores_third='" + total_correct_answers + "' WHERE Username='" + Form1.username_logged_in + "'";
                    OleDbCommand command2 = new OleDbCommand(query1, connection);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    connection.Open();
                    query1 = "UPDATE User_theories SET Scores_fourth='" + total_correct_answers + "' WHERE Username='" + Form1.username_logged_in + "'";
                    OleDbCommand command2 = new OleDbCommand(query1, connection);
                    command2.ExecuteNonQuery();
                    connection.Close();
                }
                Next_question_picturebox.Enabled = false;
                if (OnSyntax1=="Yes" || OnSyntax2=="Yes" || OnSyntax3=="Yes" || OnLogic1=="Yes"||OnLogic2=="Yes"|| OnLogic3=="Yes" || OnTypography1=="Yes"|| OnTypography2=="Yes" || OnTypography3=="Yes")
                {
                    User_failed form = new User_failed();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Well done ! You don't have any difficulties !");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("online-help.html");
            System.Diagnostics.Process.Start("online-help.html");
            System.Diagnostics.Process.Start("online-help.html");
        }
    }
}
