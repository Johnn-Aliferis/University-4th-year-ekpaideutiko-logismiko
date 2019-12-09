namespace Ekpaideutiko_logismiko_v1
{
    partial class Quiz_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Learning_python_label = new System.Windows.Forms.Label();
            this.Quiz_label = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Next_question_picturebox = new System.Windows.Forms.PictureBox();
            this.Back_picturebox = new System.Windows.Forms.PictureBox();
            this.Exit_picturebox = new System.Windows.Forms.PictureBox();
            this.Logo_picturebox = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Type_of_question_label = new System.Windows.Forms.Label();
            this.question_number_label = new System.Windows.Forms.Label();
            this.answers_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Next_question_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picturebox)).BeginInit();
            this.answers_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Learning_python_label
            // 
            this.Learning_python_label.AutoSize = true;
            this.Learning_python_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Learning_python_label.ForeColor = System.Drawing.Color.White;
            this.Learning_python_label.Location = new System.Drawing.Point(93, 21);
            this.Learning_python_label.Name = "Learning_python_label";
            this.Learning_python_label.Size = new System.Drawing.Size(182, 28);
            this.Learning_python_label.TabIndex = 24;
            this.Learning_python_label.Text = "Learning Python";
            // 
            // Quiz_label
            // 
            this.Quiz_label.AutoSize = true;
            this.Quiz_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Quiz_label.ForeColor = System.Drawing.Color.White;
            this.Quiz_label.Location = new System.Drawing.Point(359, 73);
            this.Quiz_label.Name = "Quiz_label";
            this.Quiz_label.Size = new System.Drawing.Size(79, 28);
            this.Quiz_label.TabIndex = 25;
            this.Quiz_label.Text = "Quiz #";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.richTextBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(98, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(616, 188);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // Next_question_picturebox
            // 
            this.Next_question_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_question_picturebox.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.icons8_Arrow_75px;
            this.Next_question_picturebox.Location = new System.Drawing.Point(713, 363);
            this.Next_question_picturebox.Name = "Next_question_picturebox";
            this.Next_question_picturebox.Size = new System.Drawing.Size(75, 75);
            this.Next_question_picturebox.TabIndex = 29;
            this.Next_question_picturebox.TabStop = false;
            this.toolTip1.SetToolTip(this.Next_question_picturebox, "Advance");
            this.Next_question_picturebox.Click += new System.EventHandler(this.Next_question_picturebox_Click);
            // 
            // Back_picturebox
            // 
            this.Back_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_picturebox.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.icons8_Exit_Sign_75px;
            this.Back_picturebox.Location = new System.Drawing.Point(12, 363);
            this.Back_picturebox.Name = "Back_picturebox";
            this.Back_picturebox.Size = new System.Drawing.Size(75, 75);
            this.Back_picturebox.TabIndex = 28;
            this.Back_picturebox.TabStop = false;
            this.toolTip1.SetToolTip(this.Back_picturebox, "Go back");
            this.Back_picturebox.Click += new System.EventHandler(this.Back_picturebox_Click);
            // 
            // Exit_picturebox
            // 
            this.Exit_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_picturebox.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.exit_white;
            this.Exit_picturebox.Location = new System.Drawing.Point(765, 1);
            this.Exit_picturebox.Name = "Exit_picturebox";
            this.Exit_picturebox.Size = new System.Drawing.Size(34, 35);
            this.Exit_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_picturebox.TabIndex = 27;
            this.Exit_picturebox.TabStop = false;
            this.toolTip1.SetToolTip(this.Exit_picturebox, "Close application");
            this.Exit_picturebox.Click += new System.EventHandler(this.Exit_picturebox_Click);
            this.Exit_picturebox.MouseEnter += new System.EventHandler(this.Exit_picturebox_MouseEnter);
            this.Exit_picturebox.MouseLeave += new System.EventHandler(this.Exit_picturebox_MouseLeave);
            // 
            // Logo_picturebox
            // 
            this.Logo_picturebox.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.Python;
            this.Logo_picturebox.Location = new System.Drawing.Point(12, 12);
            this.Logo_picturebox.Name = "Logo_picturebox";
            this.Logo_picturebox.Size = new System.Drawing.Size(50, 50);
            this.Logo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_picturebox.TabIndex = 1;
            this.Logo_picturebox.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(4, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(4, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 20);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(3, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 20);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(3, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 20);
            this.radioButton4.TabIndex = 33;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Type_of_question_label
            // 
            this.Type_of_question_label.AutoSize = true;
            this.Type_of_question_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Type_of_question_label.ForeColor = System.Drawing.Color.White;
            this.Type_of_question_label.Location = new System.Drawing.Point(564, 95);
            this.Type_of_question_label.Name = "Type_of_question_label";
            this.Type_of_question_label.Size = new System.Drawing.Size(189, 28);
            this.Type_of_question_label.TabIndex = 34;
            this.Type_of_question_label.Text = "Type_of_question";
            // 
            // question_number_label
            // 
            this.question_number_label.AutoSize = true;
            this.question_number_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.question_number_label.ForeColor = System.Drawing.Color.White;
            this.question_number_label.Location = new System.Drawing.Point(720, 122);
            this.question_number_label.Name = "question_number_label";
            this.question_number_label.Size = new System.Drawing.Size(63, 28);
            this.question_number_label.TabIndex = 35;
            this.question_number_label.Text = "1/15";
            // 
            // answers_panel
            // 
            this.answers_panel.Controls.Add(this.radioButton1);
            this.answers_panel.Controls.Add(this.radioButton4);
            this.answers_panel.Controls.Add(this.radioButton2);
            this.answers_panel.Controls.Add(this.radioButton3);
            this.answers_panel.Location = new System.Drawing.Point(172, 320);
            this.answers_panel.Name = "answers_panel";
            this.answers_panel.Size = new System.Drawing.Size(522, 118);
            this.answers_panel.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.icons8_Help_40px;
            this.pictureBox1.Location = new System.Drawing.Point(725, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Close application");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quiz_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answers_panel);
            this.Controls.Add(this.question_number_label);
            this.Controls.Add(this.Type_of_question_label);
            this.Controls.Add(this.Next_question_picturebox);
            this.Controls.Add(this.Back_picturebox);
            this.Controls.Add(this.Exit_picturebox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Quiz_label);
            this.Controls.Add(this.Learning_python_label);
            this.Controls.Add(this.Logo_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quiz_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz_Form";
            this.Load += new System.EventHandler(this.Quiz_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Next_question_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_picturebox)).EndInit();
            this.answers_panel.ResumeLayout(false);
            this.answers_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo_picturebox;
        private System.Windows.Forms.Label Learning_python_label;
        private System.Windows.Forms.Label Quiz_label;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox Exit_picturebox;
        private System.Windows.Forms.PictureBox Back_picturebox;
        private System.Windows.Forms.PictureBox Next_question_picturebox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Type_of_question_label;
        private System.Windows.Forms.Label question_number_label;
        private System.Windows.Forms.Panel answers_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}