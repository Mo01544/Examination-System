namespace Design
{
    partial class ShowGrades
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
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Grage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_CourseName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.OK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Grage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cmb_CourseName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 343);
            this.panel1.TabIndex = 35;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Brown;
            this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OK.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(183, 221);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(116, 33);
            this.OK.TabIndex = 37;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Grade :";
            // 
            // txt_Grage
            // 
            this.txt_Grage.Font = new System.Drawing.Font("News706 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Grage.Location = new System.Drawing.Point(192, 131);
            this.txt_Grage.Multiline = true;
            this.txt_Grage.Name = "txt_Grage";
            this.txt_Grage.Size = new System.Drawing.Size(76, 46);
            this.txt_Grage.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Course Name :";
            // 
            // Cmb_CourseName
            // 
            this.Cmb_CourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_CourseName.FormattingEnabled = true;
            this.Cmb_CourseName.Location = new System.Drawing.Point(192, 42);
            this.Cmb_CourseName.Name = "Cmb_CourseName";
            this.Cmb_CourseName.Size = new System.Drawing.Size(121, 21);
            this.Cmb_CourseName.TabIndex = 32;
            // 
            // ShowGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "ShowGrades";
            this.Size = new System.Drawing.Size(449, 356);
            this.Load += new System.EventHandler(this.ShowGrades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Grage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_CourseName;
    }
}
