namespace Ekpaideutiko_logismiko_v1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Username_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.New_account_label = new System.Windows.Forms.Label();
            this.Title_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_picturebox = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_textbox
            // 
            this.Username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Username_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Username_textbox.HintText = "";
            this.Username_textbox.isPassword = false;
            this.Username_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Username_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Username_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Username_textbox.LineThickness = 3;
            this.Username_textbox.Location = new System.Drawing.Point(31, 96);
            this.Username_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(326, 33);
            this.Username_textbox.TabIndex = 2;
            this.Username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username_textbox.OnValueChanged += new System.EventHandler(this.Username_textbox_OnValueChanged);
            this.Username_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_textbox_KeyPress);
            // 
            // Password_textbox
            // 
            this.Password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Password_textbox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Password_textbox.HintText = "";
            this.Password_textbox.isPassword = false;
            this.Password_textbox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Password_textbox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Password_textbox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Password_textbox.LineThickness = 3;
            this.Password_textbox.Location = new System.Drawing.Point(31, 169);
            this.Password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(326, 31);
            this.Password_textbox.TabIndex = 3;
            this.Password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_textbox.OnValueChanged += new System.EventHandler(this.Password_textbox_OnValueChanged);
            this.Password_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_textbox_KeyPress);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Username_label.ForeColor = System.Drawing.Color.White;
            this.Username_label.Location = new System.Drawing.Point(17, 73);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(87, 19);
            this.Username_label.TabIndex = 5;
            this.Username_label.Text = "Username :";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Password_label.ForeColor = System.Drawing.Color.White;
            this.Password_label.Location = new System.Drawing.Point(17, 146);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(85, 19);
            this.Password_label.TabIndex = 6;
            this.Password_label.Text = "Password :";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.SeaGreen;
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.FlatAppearance.BorderSize = 0;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(31, 236);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(326, 40);
            this.Login_button.TabIndex = 8;
            this.Login_button.Text = "Log in ";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // New_account_label
            // 
            this.New_account_label.AutoSize = true;
            this.New_account_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_account_label.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.New_account_label.ForeColor = System.Drawing.Color.LightBlue;
            this.New_account_label.Location = new System.Drawing.Point(191, 279);
            this.New_account_label.Name = "New_account_label";
            this.New_account_label.Size = new System.Drawing.Size(166, 20);
            this.New_account_label.TabIndex = 9;
            this.New_account_label.Text = "Create a new account";
            this.New_account_label.Click += new System.EventHandler(this.New_account_label_Click);
            this.New_account_label.MouseEnter += new System.EventHandler(this.New_account_label_MouseEnter);
            this.New_account_label.MouseLeave += new System.EventHandler(this.New_account_label_MouseLeave);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(12, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(86, 28);
            this.Title_label.TabIndex = 11;
            this.Title_label.Text = "Sing in ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.icons8_Help_25px;
            this.pictureBox1.Location = new System.Drawing.Point(342, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Exit_picturebox
            // 
            this.Exit_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_picturebox.Image = global::Ekpaideutiko_logismiko_v1.Properties.Resources.exit_white;
            this.Exit_picturebox.Location = new System.Drawing.Point(373, 3);
            this.Exit_picturebox.Name = "Exit_picturebox";
            this.Exit_picturebox.Size = new System.Drawing.Size(25, 25);
            this.Exit_picturebox.TabIndex = 10;
            this.Exit_picturebox.TabStop = false;
            this.Exit_picturebox.Click += new System.EventHandler(this.Exit_picturebox_Click);
            this.Exit_picturebox.MouseEnter += new System.EventHandler(this.Exit_picturebox_MouseEnter);
            this.Exit_picturebox.MouseLeave += new System.EventHandler(this.Exit_picturebox_MouseLeave);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Log in ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(32, 506);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(544, 63);
            this.bunifuFlatButton1.TabIndex = 7;
            this.bunifuFlatButton1.Text = "Log in ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(400, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Exit_picturebox);
            this.Controls.Add(this.New_account_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Username_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox Username_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_textbox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label New_account_label;
        private System.Windows.Forms.PictureBox Exit_picturebox;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

