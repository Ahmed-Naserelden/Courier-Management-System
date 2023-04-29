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
            this.backBtn = new System.Windows.Forms.Button();
            this.showcomplBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComplaineBtn
            // 
            this.ComplaineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComplaineBtn.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaineBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ComplaineBtn.Location = new System.Drawing.Point(405, 391);
            this.ComplaineBtn.Name = "ComplaineBtn";
            this.ComplaineBtn.Size = new System.Drawing.Size(277, 47);
            this.ComplaineBtn.TabIndex = 0;
            this.ComplaineBtn.Text = "Complaine";
            this.ComplaineBtn.UseVisualStyleBackColor = false;
            this.ComplaineBtn.Click += new System.EventHandler(this.ComplaineBtn_Click);
            // 
            // orderId
            // 
            this.orderId.BackColor = System.Drawing.SystemColors.Info;
            this.orderId.Location = new System.Drawing.Point(120, 91);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(266, 22);
            this.orderId.TabIndex = 1;
            // 
            // customerEmail
            // 
            this.customerEmail.BackColor = System.Drawing.SystemColors.Info;
            this.customerEmail.Location = new System.Drawing.Point(403, 91);
            this.customerEmail.Name = "customerEmail";
            this.customerEmail.Size = new System.Drawing.Size(279, 22);
            this.customerEmail.TabIndex = 2;
            // 
            // complainTitle
            // 
            this.complainTitle.BackColor = System.Drawing.SystemColors.Info;
            this.complainTitle.Location = new System.Drawing.Point(120, 142);
            this.complainTitle.Name = "complainTitle";
            this.complainTitle.Size = new System.Drawing.Size(562, 22);
            this.complainTitle.TabIndex = 3;
            // 
            // complainDescription
            // 
            this.complainDescription.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.complainDescription.Location = new System.Drawing.Point(123, 195);
            this.complainDescription.Name = "complainDescription";
            this.complainDescription.Size = new System.Drawing.Size(558, 148);
            this.complainDescription.TabIndex = 4;
            this.complainDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 36);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // showcomplBtn
            // 
            this.showcomplBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showcomplBtn.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcomplBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.showcomplBtn.Location = new System.Drawing.Point(123, 391);
            this.showcomplBtn.Name = "showcomplBtn";
            this.showcomplBtn.Size = new System.Drawing.Size(276, 47);
            this.showcomplBtn.TabIndex = 13;
            this.showcomplBtn.Text = "Show Coplainments";
            this.showcomplBtn.UseVisualStyleBackColor = false;
            this.showcomplBtn.Click += new System.EventHandler(this.showcomplBtn_Click);
            // 
            // MakeComplainmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showcomplBtn);
            this.Controls.Add(this.backBtn);
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
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button showcomplBtn;
    }
}