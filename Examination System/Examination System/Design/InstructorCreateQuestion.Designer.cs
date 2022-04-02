namespace Design
{
    partial class InstructorCreateQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbtn_TF = new System.Windows.Forms.RadioButton();
            this.Rbtn_Mcq = new System.Windows.Forms.RadioButton();
            this.GboxTF = new System.Windows.Forms.GroupBox();
            this.MAforTF = new System.Windows.Forms.ComboBox();
            this.SubmitTF = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.NQforTF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GBoxMCQ = new System.Windows.Forms.GroupBox();
            this.MAforMCQ = new System.Windows.Forms.ComboBox();
            this.SubmitMCQ = new System.Windows.Forms.Button();
            this.txt_Char2 = new System.Windows.Forms.TextBox();
            this.txt_Char4 = new System.Windows.Forms.TextBox();
            this.txt_Char3 = new System.Windows.Forms.TextBox();
            this.txt_Char1 = new System.Windows.Forms.TextBox();
            this.txt_description1 = new System.Windows.Forms.TextBox();
            this.txt_description2 = new System.Windows.Forms.TextBox();
            this.txt_description3 = new System.Windows.Forms.TextBox();
            this.txt_description4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NQForMCQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_CourseName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GboxTF.SuspendLayout();
            this.GBoxMCQ.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbtn_TF);
            this.groupBox1.Controls.Add(this.Rbtn_Mcq);
            this.groupBox1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(437, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Type";
            // 
            // Rbtn_TF
            // 
            this.Rbtn_TF.AutoSize = true;
            this.Rbtn_TF.Location = new System.Drawing.Point(30, 58);
            this.Rbtn_TF.Name = "Rbtn_TF";
            this.Rbtn_TF.Size = new System.Drawing.Size(54, 23);
            this.Rbtn_TF.TabIndex = 28;
            this.Rbtn_TF.Text = "T/F";
            this.Rbtn_TF.UseVisualStyleBackColor = true;
            this.Rbtn_TF.CheckedChanged += new System.EventHandler(this.Rbtn_TF_CheckedChanged);
            // 
            // Rbtn_Mcq
            // 
            this.Rbtn_Mcq.AutoSize = true;
            this.Rbtn_Mcq.Location = new System.Drawing.Point(30, 25);
            this.Rbtn_Mcq.Name = "Rbtn_Mcq";
            this.Rbtn_Mcq.Size = new System.Drawing.Size(68, 23);
            this.Rbtn_Mcq.TabIndex = 27;
            this.Rbtn_Mcq.Text = "MCQ";
            this.Rbtn_Mcq.UseVisualStyleBackColor = true;
            this.Rbtn_Mcq.CheckedChanged += new System.EventHandler(this.Rbtn_Mcq_CheckedChanged);
            // 
            // GboxTF
            // 
            this.GboxTF.Controls.Add(this.MAforTF);
            this.GboxTF.Controls.Add(this.SubmitTF);
            this.GboxTF.Controls.Add(this.label12);
            this.GboxTF.Controls.Add(this.NQforTF);
            this.GboxTF.Controls.Add(this.label9);
            this.GboxTF.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxTF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GboxTF.Location = new System.Drawing.Point(422, 227);
            this.GboxTF.Name = "GboxTF";
            this.GboxTF.Size = new System.Drawing.Size(417, 147);
            this.GboxTF.TabIndex = 33;
            this.GboxTF.TabStop = false;
            this.GboxTF.Text = "True/False Questions";
            // 
            // MAforTF
            // 
            this.MAforTF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MAforTF.FormattingEnabled = true;
            this.MAforTF.Items.AddRange(new object[] {
            "T",
            "F"});
            this.MAforTF.Location = new System.Drawing.Point(152, 77);
            this.MAforTF.Name = "MAforTF";
            this.MAforTF.Size = new System.Drawing.Size(36, 27);
            this.MAforTF.TabIndex = 22;
            // 
            // SubmitTF
            // 
            this.SubmitTF.BackColor = System.Drawing.Color.Brown;
            this.SubmitTF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SubmitTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitTF.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitTF.ForeColor = System.Drawing.Color.White;
            this.SubmitTF.Location = new System.Drawing.Point(194, 77);
            this.SubmitTF.Name = "SubmitTF";
            this.SubmitTF.Size = new System.Drawing.Size(215, 31);
            this.SubmitTF.TabIndex = 21;
            this.SubmitTF.Text = "Insert";
            this.SubmitTF.UseVisualStyleBackColor = false;
            this.SubmitTF.Click += new System.EventHandler(this.SubmitTF_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(14, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "New Question";
            // 
            // NQforTF
            // 
            this.NQforTF.Location = new System.Drawing.Point(194, 30);
            this.NQforTF.Name = "NQforTF";
            this.NQforTF.Size = new System.Drawing.Size(215, 27);
            this.NQforTF.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(15, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Model Answer";
            // 
            // GBoxMCQ
            // 
            this.GBoxMCQ.Controls.Add(this.MAforMCQ);
            this.GBoxMCQ.Controls.Add(this.SubmitMCQ);
            this.GBoxMCQ.Controls.Add(this.txt_Char2);
            this.GBoxMCQ.Controls.Add(this.txt_Char4);
            this.GBoxMCQ.Controls.Add(this.txt_Char3);
            this.GBoxMCQ.Controls.Add(this.txt_Char1);
            this.GBoxMCQ.Controls.Add(this.txt_description1);
            this.GBoxMCQ.Controls.Add(this.txt_description2);
            this.GBoxMCQ.Controls.Add(this.txt_description3);
            this.GBoxMCQ.Controls.Add(this.txt_description4);
            this.GBoxMCQ.Controls.Add(this.label4);
            this.GBoxMCQ.Controls.Add(this.label5);
            this.GBoxMCQ.Controls.Add(this.label8);
            this.GBoxMCQ.Controls.Add(this.label6);
            this.GBoxMCQ.Controls.Add(this.label7);
            this.GBoxMCQ.Controls.Add(this.NQForMCQ);
            this.GBoxMCQ.Controls.Add(this.label1);
            this.GBoxMCQ.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxMCQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GBoxMCQ.Location = new System.Drawing.Point(7, 228);
            this.GBoxMCQ.Name = "GBoxMCQ";
            this.GBoxMCQ.Size = new System.Drawing.Size(409, 295);
            this.GBoxMCQ.TabIndex = 32;
            this.GBoxMCQ.TabStop = false;
            this.GBoxMCQ.Text = "Choicees Questions";
            // 
            // MAforMCQ
            // 
            this.MAforMCQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MAforMCQ.FormattingEnabled = true;
            this.MAforMCQ.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.MAforMCQ.Location = new System.Drawing.Point(152, 250);
            this.MAforMCQ.Name = "MAforMCQ";
            this.MAforMCQ.Size = new System.Drawing.Size(30, 27);
            this.MAforMCQ.TabIndex = 21;
            // 
            // SubmitMCQ
            // 
            this.SubmitMCQ.BackColor = System.Drawing.Color.Brown;
            this.SubmitMCQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SubmitMCQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitMCQ.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitMCQ.ForeColor = System.Drawing.Color.White;
            this.SubmitMCQ.Location = new System.Drawing.Point(188, 250);
            this.SubmitMCQ.Name = "SubmitMCQ";
            this.SubmitMCQ.Size = new System.Drawing.Size(206, 30);
            this.SubmitMCQ.TabIndex = 20;
            this.SubmitMCQ.Text = "Insert";
            this.SubmitMCQ.UseVisualStyleBackColor = false;
            this.SubmitMCQ.Click += new System.EventHandler(this.SubmitMCQ_Click);
            // 
            // txt_Char2
            // 
            this.txt_Char2.Enabled = false;
            this.txt_Char2.Location = new System.Drawing.Point(152, 115);
            this.txt_Char2.Name = "txt_Char2";
            this.txt_Char2.Size = new System.Drawing.Size(30, 27);
            this.txt_Char2.TabIndex = 19;
            this.txt_Char2.Text = "B";
            // 
            // txt_Char4
            // 
            this.txt_Char4.Enabled = false;
            this.txt_Char4.Location = new System.Drawing.Point(152, 201);
            this.txt_Char4.Name = "txt_Char4";
            this.txt_Char4.Size = new System.Drawing.Size(30, 27);
            this.txt_Char4.TabIndex = 18;
            this.txt_Char4.Text = "D";
            // 
            // txt_Char3
            // 
            this.txt_Char3.Enabled = false;
            this.txt_Char3.Location = new System.Drawing.Point(152, 159);
            this.txt_Char3.Name = "txt_Char3";
            this.txt_Char3.Size = new System.Drawing.Size(30, 27);
            this.txt_Char3.TabIndex = 17;
            this.txt_Char3.Text = "C";
            // 
            // txt_Char1
            // 
            this.txt_Char1.Enabled = false;
            this.txt_Char1.Location = new System.Drawing.Point(152, 73);
            this.txt_Char1.Name = "txt_Char1";
            this.txt_Char1.Size = new System.Drawing.Size(30, 27);
            this.txt_Char1.TabIndex = 16;
            this.txt_Char1.Text = "A";
            // 
            // txt_description1
            // 
            this.txt_description1.Location = new System.Drawing.Point(188, 73);
            this.txt_description1.Name = "txt_description1";
            this.txt_description1.Size = new System.Drawing.Size(206, 27);
            this.txt_description1.TabIndex = 6;
            // 
            // txt_description2
            // 
            this.txt_description2.Location = new System.Drawing.Point(188, 115);
            this.txt_description2.Name = "txt_description2";
            this.txt_description2.Size = new System.Drawing.Size(206, 27);
            this.txt_description2.TabIndex = 7;
            // 
            // txt_description3
            // 
            this.txt_description3.Location = new System.Drawing.Point(188, 162);
            this.txt_description3.Name = "txt_description3";
            this.txt_description3.Size = new System.Drawing.Size(206, 27);
            this.txt_description3.TabIndex = 8;
            // 
            // txt_description4
            // 
            this.txt_description4.Location = new System.Drawing.Point(188, 201);
            this.txt_description4.Name = "txt_description4";
            this.txt_description4.Size = new System.Drawing.Size(206, 27);
            this.txt_description4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choice1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choice2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(21, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Model Answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(21, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Choice3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(21, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choice4";
            // 
            // NQForMCQ
            // 
            this.NQForMCQ.Location = new System.Drawing.Point(152, 33);
            this.NQForMCQ.Name = "NQForMCQ";
            this.NQForMCQ.Size = new System.Drawing.Size(242, 27);
            this.NQForMCQ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Course Name";
            // 
            // Cmb_CourseName
            // 
            this.Cmb_CourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName.FormattingEnabled = true;
            this.Cmb_CourseName.Location = new System.Drawing.Point(124, 102);
            this.Cmb_CourseName.Name = "Cmb_CourseName";
            this.Cmb_CourseName.Size = new System.Drawing.Size(121, 21);
            this.Cmb_CourseName.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 100);
            this.panel2.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Brown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-5, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 68);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generate Questions";
            // 
            // InstructorCreateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GboxTF);
            this.Controls.Add(this.GBoxMCQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_CourseName);
            this.Name = "InstructorCreateQuestion";
            this.Size = new System.Drawing.Size(889, 584);
            this.Load += new System.EventHandler(this.InstructorCreateQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GboxTF.ResumeLayout(false);
            this.GboxTF.PerformLayout();
            this.GBoxMCQ.ResumeLayout(false);
            this.GBoxMCQ.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbtn_TF;
        private System.Windows.Forms.RadioButton Rbtn_Mcq;
        private System.Windows.Forms.GroupBox GboxTF;
        private System.Windows.Forms.ComboBox MAforTF;
        private System.Windows.Forms.Button SubmitTF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NQforTF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GBoxMCQ;
        private System.Windows.Forms.ComboBox MAforMCQ;
        private System.Windows.Forms.Button SubmitMCQ;
        private System.Windows.Forms.TextBox txt_Char2;
        private System.Windows.Forms.TextBox txt_Char4;
        private System.Windows.Forms.TextBox txt_Char3;
        private System.Windows.Forms.TextBox txt_Char1;
        private System.Windows.Forms.TextBox txt_description1;
        private System.Windows.Forms.TextBox txt_description2;
        private System.Windows.Forms.TextBox txt_description3;
        private System.Windows.Forms.TextBox txt_description4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NQForMCQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_CourseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}
