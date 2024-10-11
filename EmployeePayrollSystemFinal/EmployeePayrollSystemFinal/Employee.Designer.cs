namespace EmployeePayrollSystemFinal
{
    partial class Employee
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
            panel1 = new Panel();
            EmpDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpGenCb = new ComboBox();
            EmpDob = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            EmpEduCb = new ComboBox();
            EmpPosCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            EmpPhoneTb = new TextBox();
            label5 = new Label();
            EmpAddTb = new TextBox();
            label4 = new Label();
            EmpNameTb = new TextBox();
            label3 = new Label();
            EmpIdTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EmpDGV);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(EmpDob);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmpEduCb);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(EmpNameTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(EmpIdTb);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 563);
            panel1.TabIndex = 0;
            // 
            // EmpDGV
            // 
            EmpDGV.BackgroundColor = Color.White;
            EmpDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmpDGV.Location = new Point(625, 42);
            EmpDGV.Name = "EmpDGV";
            EmpDGV.RowHeadersWidth = 51;
            EmpDGV.Size = new Size(765, 464);
            EmpDGV.TabIndex = 23;
            EmpDGV.CellContentClick += EmpDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.OrangeRed;
            button4.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(450, 442);
            button4.Name = "button4";
            button4.Size = new Size(132, 64);
            button4.TabIndex = 22;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(312, 442);
            button3.Name = "button3";
            button3.Size = new Size(132, 64);
            button3.TabIndex = 21;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(174, 442);
            button2.Name = "button2";
            button2.Size = new Size(132, 64);
            button2.TabIndex = 20;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 442);
            button1.Name = "button1";
            button1.Size = new Size(132, 64);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmpGenCb
            // 
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "Male", "Female" });
            EmpGenCb.Location = new Point(36, 388);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(239, 28);
            EmpGenCb.TabIndex = 18;
            // 
            // EmpDob
            // 
            EmpDob.Location = new Point(339, 389);
            EmpDob.Name = "EmpDob";
            EmpDob.Size = new Size(261, 27);
            EmpDob.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(339, 346);
            label9.Name = "label9";
            label9.Size = new Size(133, 29);
            label9.TabIndex = 16;
            label9.Text = "Birth Day";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(36, 346);
            label8.Name = "label8";
            label8.Size = new Size(229, 29);
            label8.TabIndex = 15;
            label8.Text = "Employee Gender";
            // 
            // EmpEduCb
            // 
            EmpEduCb.FormattingEnabled = true;
            EmpEduCb.Items.AddRange(new object[] { "BTech", "MTech", "BBA", "BCA", "MBA", "BCom", "MCom" });
            EmpEduCb.Location = new Point(339, 300);
            EmpEduCb.Name = "EmpEduCb";
            EmpEduCb.Size = new Size(261, 28);
            EmpEduCb.TabIndex = 14;
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "Manager", "Senior Developper", "Junior Developper", "Accountant", "Receptionist" });
            EmpPosCb.Location = new Point(36, 300);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(239, 28);
            EmpPosCb.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(36, 268);
            label7.Name = "label7";
            label7.Size = new Size(239, 29);
            label7.TabIndex = 12;
            label7.Text = "Employee Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(339, 268);
            label6.Name = "label6";
            label6.Size = new Size(261, 29);
            label6.TabIndex = 11;
            label6.Text = "Employee Education";
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Location = new Point(36, 228);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(564, 27);
            EmpPhoneTb.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(36, 196);
            label5.Name = "label5";
            label5.Size = new Size(216, 29);
            label5.TabIndex = 9;
            label5.Text = "Employee Phone";
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(36, 166);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(564, 27);
            EmpAddTb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(36, 134);
            label4.Name = "label4";
            label4.Size = new Size(242, 29);
            label4.TabIndex = 7;
            label4.Text = "Employee Address";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(36, 104);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(564, 27);
            EmpNameTb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(36, 72);
            label3.Name = "label3";
            label3.Size = new Size(209, 29);
            label3.TabIndex = 5;
            label3.Text = "Employee Name";
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(36, 42);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(564, 27);
            EmpIdTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(36, 10);
            label2.Name = "label2";
            label2.Size = new Size(166, 29);
            label2.TabIndex = 2;
            label2.Text = "Employee ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OrangeRed;
            label1.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(328, 42);
            label1.TabIndex = 3;
            label1.Text = "Manage Employee";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.OrangeRed;
            label10.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1361, 29);
            label10.Name = "label10";
            label10.Size = new Size(45, 42);
            label10.TabIndex = 4;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(1418, 662);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmpDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox EmpAddTb;
        private Label label4;
        private TextBox EmpNameTb;
        private Label label3;
        private TextBox EmpIdTb;
        private Label label7;
        private Label label6;
        private TextBox EmpPhoneTb;
        private Label label5;
        private Label label8;
        private ComboBox EmpEduCb;
        private ComboBox EmpPosCb;
        private ComboBox EmpGenCb;
        private DateTimePicker EmpDob;
        private Label label9;
        private Button button1;
        private DataGridView EmpDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label10;
    }
}