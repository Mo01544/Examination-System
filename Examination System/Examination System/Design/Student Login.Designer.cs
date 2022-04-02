namespace Design
{
    partial class Student_Login
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
            this.btn_startExam = new System.Windows.Forms.Button();
            this.btn_showGrades = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_label = new System.Windows.Forms.Label();
            this.txt_Department = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cmb_CourseName1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_startExam
            // 
            this.btn_startExam.BackColor = System.Drawing.Color.Brown;
            this.btn_startExam.FlatAppearance.BorderSize = 0;
            this.btn_startExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_startExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_startExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startExam.ForeColor = System.Drawing.Color.White;
            this.btn_startExam.Location = new System.Drawing.Point(576, 165);
            this.btn_startExam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startExam.Name = "btn_startExam";
            this.btn_startExam.Size = new System.Drawing.Size(201, 52);
            this.btn_startExam.TabIndex = 34;
            this.btn_startExam.Text = "Start Exam";
            this.btn_startExam.UseVisualStyleBackColor = false;
            this.btn_startExam.Click += new System.EventHandler(this.btn_startExam_Click);
            // 
            // btn_showGrades
            // 
            this.btn_showGrades.BackColor = System.Drawing.Color.Brown;
            this.btn_showGrades.FlatAppearance.BorderSize = 0;
            this.btn_showGrades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_showGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_showGrades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showGrades.ForeColor = System.Drawing.Color.White;
            this.btn_showGrades.Location = new System.Drawing.Point(838, 165);
            this.btn_showGrades.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showGrades.Name = "btn_showGrades";
            this.btn_showGrades.Size = new System.Drawing.Size(201, 52);
            this.btn_showGrades.TabIndex = 35;
            this.btn_showGrades.Text = "Show Grades";
            this.btn_showGrades.UseVisualStyleBackColor = false;
            this.btn_showGrades.Click += new System.EventHandler(this.btn_showGrades_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Brown;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(329, 165);
            this.Home.Margin = new System.Windows.Forms.Padding(4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(201, 52);
            this.Home.TabIndex = 36;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.Enter += new System.EventHandler(this.Student_Login_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Controls.Add(this.txt_Department);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 499);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id_label.Location = new System.Drawing.Point(15, 358);
            this.id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(0, 25);
            this.id_label.TabIndex = 48;
            // 
            // txt_Department
            // 
            this.txt_Department.AutoSize = true;
            this.txt_Department.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Department.Location = new System.Drawing.Point(147, 303);
            this.txt_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(0, 25);
            this.txt_Department.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Department :";
            // 
            // txt_username
            // 
            this.txt_username.AutoSize = true;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Location = new System.Drawing.Point(140, 239);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(0, 25);
            this.txt_username.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Name :";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Design.Properties.Resources.kisspng_computer_icons_user_ios_7_profile_5ab91694cef9e0_2240064815220793808478_ccexpress;
            this.panel2.Location = new System.Drawing.Point(44, 7);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 124);
            this.panel2.TabIndex = 42;
            // 
            // SNameLabel
            // 
            this.SNameLabel.AutoSize = true;
            this.SNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SNameLabel.Location = new System.Drawing.Point(91, 170);
            this.SNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SNameLabel.Name = "SNameLabel";
            this.SNameLabel.Size = new System.Drawing.Size(0, 25);
            this.SNameLabel.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Cmb_CourseName1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(307, 224);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 354);
            this.panel3.TabIndex = 42;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Cmb_CourseName1
            // 
            this.Cmb_CourseName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName1.FormattingEnabled = true;
            this.Cmb_CourseName1.Location = new System.Drawing.Point(311, 51);
            this.Cmb_CourseName1.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_CourseName1.Name = "Cmb_CourseName1";
            this.Cmb_CourseName1.Size = new System.Drawing.Size(145, 24);
            this.Cmb_CourseName1.TabIndex = 43;
            this.Cmb_CourseName1.SelectionChangeCommitted += new System.EventHandler(this.Cmb_CourseName1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(128, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Course Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImage = global::Design.Properties.Resources.iti_logo_ccexpress1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1139, 123);
            this.panel5.TabIndex = 32;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(84, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Institute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(80, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Information Technology  ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Brown;
            this.panel6.ForeColor = System.Drawing.Color.Brown;
            this.panel6.Location = new System.Drawing.Point(1107, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(27, 123);
            this.panel6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(528, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "ONLINE EXAMINATION SYSTEM";
            // 
            // Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_showGrades);
            this.Controls.Add(this.btn_startExam);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Login";
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.Student_Login_Load);
            this.Enter += new System.EventHandler(this.Student_Login_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_startExam;
        private System.Windows.Forms.Button btn_showGrades;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SNameLabel;
        private System.Windows.Forms.Label txt_username;
        private System.Windows.Forms.Label txt_Department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Cmb_CourseName1;
        private System.Windows.Forms.Label label3;
    }
}