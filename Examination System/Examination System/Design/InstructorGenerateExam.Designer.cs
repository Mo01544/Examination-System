namespace Design
{
    partial class InstructorGenerateExam
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
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_CourseName = new System.Windows.Forms.ComboBox();
            this.txt_num_mcq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitGenerateExam = new System.Windows.Forms.Button();
            this.txt_num_TF = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(51, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Course Name";
            // 
            // Cmb_CourseName
            // 
            this.Cmb_CourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName.FormattingEnabled = true;
            this.Cmb_CourseName.Location = new System.Drawing.Point(246, 17);
            this.Cmb_CourseName.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_CourseName.Name = "Cmb_CourseName";
            this.Cmb_CourseName.Size = new System.Drawing.Size(145, 24);
            this.Cmb_CourseName.TabIndex = 39;
            // 
            // txt_num_mcq
            // 
            this.txt_num_mcq.Location = new System.Drawing.Point(337, 114);
            this.txt_num_mcq.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_mcq.Multiline = true;
            this.txt_num_mcq.Name = "txt_num_mcq";
            this.txt_num_mcq.Size = new System.Drawing.Size(54, 41);
            this.txt_num_mcq.TabIndex = 41;
            this.txt_num_mcq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_mcq_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(51, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Number Of MCQ Questions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(51, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Number Of T/F Questions";
            // 
            // SubmitGenerateExam
            // 
            this.SubmitGenerateExam.BackColor = System.Drawing.Color.Brown;
            this.SubmitGenerateExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SubmitGenerateExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitGenerateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitGenerateExam.ForeColor = System.Drawing.Color.White;
            this.SubmitGenerateExam.Location = new System.Drawing.Point(56, 294);
            this.SubmitGenerateExam.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitGenerateExam.Name = "SubmitGenerateExam";
            this.SubmitGenerateExam.Size = new System.Drawing.Size(278, 46);
            this.SubmitGenerateExam.TabIndex = 45;
            this.SubmitGenerateExam.Text = "Insert";
            this.SubmitGenerateExam.UseVisualStyleBackColor = false;
            this.SubmitGenerateExam.Click += new System.EventHandler(this.SubmitGenerateExam_Click);
            // 
            // txt_num_TF
            // 
            this.txt_num_TF.Location = new System.Drawing.Point(337, 194);
            this.txt_num_TF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_TF.Multiline = true;
            this.txt_num_TF.Name = "txt_num_TF";
            this.txt_num_TF.Size = new System.Drawing.Size(54, 41);
            this.txt_num_TF.TabIndex = 46;
            this.txt_num_TF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_TF_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitGenerateExam);
            this.panel1.Controls.Add(this.txt_num_TF);
            this.panel1.Controls.Add(this.Cmb_CourseName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_num_mcq);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 123);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 385);
            this.panel1.TabIndex = 47;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 123);
            this.panel2.TabIndex = 48;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Brown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(12, 84);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(26, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Generate Exam";
            // 
            // InstructorGenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InstructorGenerateExam";
            this.Size = new System.Drawing.Size(1027, 636);
            this.Load += new System.EventHandler(this.InstructorGenerateExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_CourseName;
        private System.Windows.Forms.TextBox txt_num_mcq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitGenerateExam;
        private System.Windows.Forms.TextBox txt_num_TF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
    }
}
