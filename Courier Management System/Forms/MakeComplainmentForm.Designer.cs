namespace Courier_Management_System
{
    partial class MakeComplainmentForm
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
            this.ComplaineBtn = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.TextBox();
            this.customerEmail = new System.Windows.Forms.TextBox();
            this.complainTitle = new System.Windows.Forms.TextBox();
            this.complainDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showcomplBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComplaineBtn
            // 
            this.ComplaineBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ComplaineBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaineBtn.ForeColor = System.Drawing.Color.Black;
            this.ComplaineBtn.Location = new System.Drawing.Point(405, 391);
            this.ComplaineBtn.Name = "ComplaineBtn";
            this.ComplaineBtn.Size = new System.Drawing.Size(277, 47);
            this.ComplaineBtn.TabIndex = 0;
            this.ComplaineBtn.Text = "Complain";
            this.ComplaineBtn.UseVisualStyleBackColor = false;
            this.ComplaineBtn.Click += new System.EventHandler(this.ComplaineBtn_Click);
            // 
            // orderId
            // 
            this.orderId.BackColor = System.Drawing.Color.Gainsboro;
            this.orderId.Location = new System.Drawing.Point(120, 91);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(266, 22);
            this.orderId.TabIndex = 1;
            this.orderId.TextChanged += new System.EventHandler(this.orderId_TextChanged);
            // 
            // customerEmail
            // 
            this.customerEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.customerEmail.Location = new System.Drawing.Point(403, 91);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(279, 22);
            this.customerEmail.TabIndex = 2;
            // 
            // complainTitle
            // 
            this.complainTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.complainTitle.Location = new System.Drawing.Point(120, 142);
            this.complainTitle.Name = "complainTitle";
            this.complainTitle.Size = new System.Drawing.Size(562, 22);
            this.complainTitle.TabIndex = 3;
            // 
            // complainDescription
            // 
            this.complainDescription.BackColor = System.Drawing.Color.Gainsboro;
            this.complainDescription.Location = new System.Drawing.Point(120, 196);
            this.complainDescription.Name = "complainDescription";
            this.complainDescription.Size = new System.Drawing.Size(285, 170);
            this.complainDescription.TabIndex = 4;
            this.complainDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(116, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // showcomplBtn
            // 
            this.showcomplBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showcomplBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcomplBtn.ForeColor = System.Drawing.Color.Black;
            this.showcomplBtn.Location = new System.Drawing.Point(120, 391);
            this.showcomplBtn.Name = "showcomplBtn";
            this.showcomplBtn.Size = new System.Drawing.Size(276, 47);
            this.showcomplBtn.TabIndex = 13;
            this.showcomplBtn.Text = "Show Coplainments";
            this.showcomplBtn.UseVisualStyleBackColor = false;
            this.showcomplBtn.Click += new System.EventHandler(this.showcomplBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(509, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(505, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "compliant category";
            // 
            // MakeComplainmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.showcomplBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complainDescription);
            this.Controls.Add(this.complainTitle);
            this.Controls.Add(this.customerEmail);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.ComplaineBtn);
            this.Name = "MakeComplainmentForm";
            this.Text = "ComplainmentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComplainmentForm_FormClosing);
            this.Load += new System.EventHandler(this.ComplainmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComplaineBtn;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.TextBox customerEmail;
        private System.Windows.Forms.TextBox complainTitle;
        private System.Windows.Forms.RichTextBox complainDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showcomplBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}