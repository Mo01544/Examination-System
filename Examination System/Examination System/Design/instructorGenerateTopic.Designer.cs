namespace Design
{
    partial class instructorGenerateTopic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitAddTopic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TopicName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_CourseName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_CourseName2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cmb_CourseName2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SubmitAddTopic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_TopicName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cmb_CourseName);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 470);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SubmitAddTopic
            // 
            this.SubmitAddTopic.BackColor = System.Drawing.Color.Brown;
            this.SubmitAddTopic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SubmitAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitAddTopic.ForeColor = System.Drawing.Color.White;
            this.SubmitAddTopic.Location = new System.Drawing.Point(77, 358);
            this.SubmitAddTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitAddTopic.Name = "SubmitAddTopic";
            this.SubmitAddTopic.Size = new System.Drawing.Size(278, 46);
            this.SubmitAddTopic.TabIndex = 41;
            this.SubmitAddTopic.Text = "Insert";
            this.SubmitAddTopic.UseVisualStyleBackColor = false;
            this.SubmitAddTopic.Click += new System.EventHandler(this.SubmitAddTopic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Topic Name :";
            // 
            // txt_TopicName
            // 
            this.txt_TopicName.Location = new System.Drawing.Point(144, 131);
            this.txt_TopicName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TopicName.Multiline = true;
            this.txt_TopicName.Name = "txt_TopicName";
            this.txt_TopicName.Size = new System.Drawing.Size(277, 30);
            this.txt_TopicName.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Course Name";
            // 
            // Cmb_CourseName
            // 
            this.Cmb_CourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName.FormattingEnabled = true;
            this.Cmb_CourseName.Location = new System.Drawing.Point(144, 10);
            this.Cmb_CourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_CourseName.Name = "Cmb_CourseName";
            this.Cmb_CourseName.Size = new System.Drawing.Size(277, 24);
            this.Cmb_CourseName.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 123);
            this.panel2.TabIndex = 38;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Brown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(12, 84);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Generate  Topic";
            // 
            // Cmb_CourseName2
            // 
            this.Cmb_CourseName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName2.FormattingEnabled = true;
            this.Cmb_CourseName2.Location = new System.Drawing.Point(210, 232);
            this.Cmb_CourseName2.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_CourseName2.Name = "Cmb_CourseName2";
            this.Cmb_CourseName2.Size = new System.Drawing.Size(145, 24);
            this.Cmb_CourseName2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Course Name";
            // 
            // instructorGenerateTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "instructorGenerateTopic";
            this.Size = new System.Drawing.Size(1106, 674);
            this.Load += new System.EventHandler(this.instructorGenerateTopic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SubmitAddTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TopicName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_CourseName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_CourseName2;
        private System.Windows.Forms.Label label4;
    }
}
