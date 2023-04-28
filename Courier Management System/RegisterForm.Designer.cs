namespace Courier_Management_System
{
    partial class RegisterForm
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
            this.First_name_lable = new System.Windows.Forms.Label();
            this.Last_name_lable = new System.Windows.Forms.Label();
            this.Email_lable = new System.Windows.Forms.Label();
            this.Address_lable = new System.Windows.Forms.Label();
            this.Password_lable = new System.Windows.Forms.Label();
            this.First_name_textbox = new System.Windows.Forms.TextBox();
            this.Last_name_textbox = new System.Windows.Forms.TextBox();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Register_button = new System.Windows.Forms.Button();
            this.Register_lable = new System.Windows.Forms.Label();
            this.Phone_lable = new System.Windows.Forms.Label();
            this.Phone_textbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MajorcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RepeatPassword_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passnotequal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.credit_card_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // First_name_lable
            // 
            this.First_name_lable.AutoSize = true;
            this.First_name_lable.Location = new System.Drawing.Point(150, 100);
            this.First_name_lable.Name = "First_name_lable";
            this.First_name_lable.Size = new System.Drawing.Size(74, 17);
            this.First_name_lable.TabIndex = 0;
            this.First_name_lable.Text = "First name";
            this.First_name_lable.Click += new System.EventHandler(this.First_name_lable_Click);
            // 
            // Last_name_lable
            // 
            this.Last_name_lable.AutoSize = true;
            this.Last_name_lable.Location = new System.Drawing.Point(410, 100);
            this.Last_name_lable.Name = "Last_name_lable";
            this.Last_name_lable.Size = new System.Drawing.Size(74, 17);
            this.Last_name_lable.TabIndex = 1;
            this.Last_name_lable.Text = "Last name";
            this.Last_name_lable.Click += new System.EventHandler(this.Last_name_lable_Click);
            // 
            // Email_lable
            // 
            this.Email_lable.AutoSize = true;
            this.Email_lable.Location = new System.Drawing.Point(150, 149);
            this.Email_lable.Name = "Email_lable";
            this.Email_lable.Size = new System.Drawing.Size(42, 17);
            this.Email_lable.TabIndex = 2;
            this.Email_lable.Text = "Email";
            this.Email_lable.Click += new System.EventHandler(this.Email_lable_Click);
            // 
            // Address_lable
            // 
            this.Address_lable.AutoSize = true;
            this.Address_lable.Location = new System.Drawing.Point(410, 149);
            this.Address_lable.Name = "Address_lable";
            this.Address_lable.Size = new System.Drawing.Size(60, 17);
            this.Address_lable.TabIndex = 3;
            this.Address_lable.Text = "Address";
            this.Address_lable.Click += new System.EventHandler(this.Address_lable_Click);
            // 
            // Password_lable
            // 
            this.Password_lable.AutoSize = true;
            this.Password_lable.Location = new System.Drawing.Point(150, 200);
            this.Password_lable.Name = "Password_lable";
            this.Password_lable.Size = new System.Drawing.Size(69, 17);
            this.Password_lable.TabIndex = 4;
            this.Password_lable.Text = "Password";
            this.Password_lable.Click += new System.EventHandler(this.Password_lable_Click);
            // 
            // First_name_textbox
            // 
            this.First_name_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.First_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_name_textbox.Location = new System.Drawing.Point(153, 119);
            this.First_name_textbox.Name = "First_name_textbox";
            this.First_name_textbox.Size = new System.Drawing.Size(210, 22);
            this.First_name_textbox.TabIndex = 5;
            // 
            // Last_name_textbox
            // 
            this.Last_name_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Last_name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Last_name_textbox.Location = new System.Drawing.Point(413, 119);
            this.Last_name_textbox.Name = "Last_name_textbox";
            this.Last_name_textbox.Size = new System.Drawing.Size(210, 22);
            this.Last_name_textbox.TabIndex = 6;
            // 
            // Email_textbox
            // 
            this.Email_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_textbox.Location = new System.Drawing.Point(153, 168);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(210, 22);
            this.Email_textbox.TabIndex = 7;
            // 
            // Address_textbox
            // 
            this.Address_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Address_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address_textbox.Location = new System.Drawing.Point(413, 168);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(210, 22);
            this.Address_textbox.TabIndex = 8;
            // 
            // Password_textbox
            // 
            this.Password_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textbox.Location = new System.Drawing.Point(153, 219);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.Size = new System.Drawing.Size(210, 27);
            this.Password_textbox.TabIndex = 9;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Password_textbox_TextChanged);
            // 
            // Register_button
            // 
            this.Register_button.BackColor = System.Drawing.Color.CadetBlue;
            this.Register_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_button.Location = new System.Drawing.Point(320, 392);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(119, 46);
            this.Register_button.TabIndex = 10;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = false;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Register_lable
            // 
            this.Register_lable.AutoSize = true;
            this.Register_lable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_lable.Location = new System.Drawing.Point(292, 9);
            this.Register_lable.Name = "Register_lable";
            this.Register_lable.Size = new System.Drawing.Size(224, 55);
            this.Register_lable.TabIndex = 11;
            this.Register_lable.Text = "Register";
            // 
            // Phone_lable
            // 
            this.Phone_lable.AutoSize = true;
            this.Phone_lable.Location = new System.Drawing.Point(410, 204);
            this.Phone_lable.Name = "Phone_lable";
            this.Phone_lable.Size = new System.Drawing.Size(49, 17);
            this.Phone_lable.TabIndex = 12;
            this.Phone_lable.Text = "Phone";
            this.Phone_lable.Click += new System.EventHandler(this.Phone_lable_Click);
            // 
            // Phone_textbox
            // 
            this.Phone_textbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Phone_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_textbox.Location = new System.Drawing.Point(413, 224);
            this.Phone_textbox.Name = "Phone_textbox";
            this.Phone_textbox.Size = new System.Drawing.Size(210, 22);
            this.Phone_textbox.TabIndex = 13;
            // 
            // MajorcomboBox1
            // 
            this.MajorcomboBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MajorcomboBox1.FormattingEnabled = true;
            this.MajorcomboBox1.Location = new System.Drawing.Point(274, 351);
            this.MajorcomboBox1.Name = "MajorcomboBox1";
            this.MajorcomboBox1.Size = new System.Drawing.Size(210, 24);
            this.MajorcomboBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Major";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RepeatPassword_textBox1
            // 
            this.RepeatPassword_textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.RepeatPassword_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepeatPassword_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_textBox1.Location = new System.Drawing.Point(153, 268);
            this.RepeatPassword_textBox1.Name = "RepeatPassword_textBox1";
            this.RepeatPassword_textBox1.PasswordChar = '*';
            this.RepeatPassword_textBox1.Size = new System.Drawing.Size(210, 27);
            this.RepeatPassword_textBox1.TabIndex = 17;
            this.RepeatPassword_textBox1.TextChanged += new System.EventHandler(this.RepeatPassword_textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Repeat Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(652, 421);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 20);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I have an  acount";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passnotequal
            // 
            this.passnotequal.AutoSize = true;
            this.passnotequal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passnotequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passnotequal.ForeColor = System.Drawing.Color.Red;
            this.passnotequal.Location = new System.Drawing.Point(150, 298);
            this.passnotequal.Name = "passnotequal";
            this.passnotequal.Size = new System.Drawing.Size(153, 17);
            this.passnotequal.TabIndex = 19;
            this.passnotequal.Text = "password not matching";
            this.passnotequal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Credit Card";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // credit_card_textBox
            // 
            this.credit_card_textBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.credit_card_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.credit_card_textBox.Location = new System.Drawing.Point(413, 273);
            this.credit_card_textBox.Name = "credit_card_textBox";
            this.credit_card_textBox.Size = new System.Drawing.Size(210, 22);
            this.credit_card_textBox.TabIndex = 21;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credit_card_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passnotequal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.RepeatPassword_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MajorcomboBox1);
            this.Controls.Add(this.Phone_textbox);
            this.Controls.Add(this.Phone_lable);
            this.Controls.Add(this.Register_lable);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Address_textbox);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Last_name_textbox);
            this.Controls.Add(this.First_name_textbox);
            this.Controls.Add(this.Password_lable);
            this.Controls.Add(this.Address_lable);
            this.Controls.Add(this.Email_lable);
            this.Controls.Add(this.Last_name_lable);
            this.Controls.Add(this.First_name_lable);
            this.Name = "RegisterForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label First_name_lable;
        private System.Windows.Forms.Label Last_name_lable;
        private System.Windows.Forms.Label Email_lable;
        private System.Windows.Forms.Label Address_lable;
        private System.Windows.Forms.Label Password_lable;
        private System.Windows.Forms.TextBox First_name_textbox;
        private System.Windows.Forms.TextBox Last_name_textbox;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label Register_lable;
        private System.Windows.Forms.Label Phone_lable;
        private System.Windows.Forms.TextBox Phone_textbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox MajorcomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RepeatPassword_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label passnotequal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox credit_card_textBox;
    }
}