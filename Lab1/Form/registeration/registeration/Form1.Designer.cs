namespace registeration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.dept = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dose1 = new System.Windows.Forms.CheckBox();
            this.dose2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reg No.:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone No:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(105, 164);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(47, 17);
            this.male.TabIndex = 6;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(158, 164);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(56, 17);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // dept
            // 
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "ICT",
            "CSE",
            "ECE",
            "BIO"});
            this.dept.Location = new System.Drawing.Point(102, 214);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(121, 21);
            this.dept.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department:";
            // 
            // dose1
            // 
            this.dose1.AutoSize = true;
            this.dose1.Location = new System.Drawing.Point(102, 268);
            this.dose1.Name = "dose1";
            this.dose1.Size = new System.Drawing.Size(60, 17);
            this.dose1.TabIndex = 11;
            this.dose1.Text = "Dose 1";
            this.dose1.UseVisualStyleBackColor = true;
            // 
            // dose2
            // 
            this.dose2.AutoSize = true;
            this.dose2.Location = new System.Drawing.Point(102, 291);
            this.dose2.Name = "dose2";
            this.dose2.Size = new System.Drawing.Size(60, 17);
            this.dose2.TabIndex = 12;
            this.dose2.Text = "Dose 2";
            this.dose2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vaccination:";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(297, 68);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 14;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(367, 262);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date of Arrival";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 372);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dose2);
            this.Controls.Add(this.dose1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.female);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Registeration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox dose1;
        private System.Windows.Forms.CheckBox dose2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
    }
}

