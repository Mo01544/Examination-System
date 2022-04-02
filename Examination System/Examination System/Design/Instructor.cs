using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design.Model;

namespace Design
{
    public partial class Instructor : Form
    {
        Context db = new Context();
        public Instructor()
        {
            InitializeComponent();
        }

        InstructorCreateQuestion ICQ = new InstructorCreateQuestion();
        instructorGenerateTopic IGT = new instructorGenerateTopic();
        InstructorGenerateExam IGE = new InstructorGenerateExam();
       
        private void Instructor_Load(object sender, EventArgs e)
         {
          


        }

        private void btn_GQuestions_Click(object sender, EventArgs e)
        {
            MainDisplayPanel.Controls.Add(ICQ);   
            ICQ.BringToFront();
        }
        private void btn_GTopic_Click(object sender, EventArgs e)
        {
            MainDisplayPanel.Controls.Add(IGT);
            IGT.BringToFront();
           
        }
        private void btn_GExam_Click(object sender, EventArgs e)
        {
            MainDisplayPanel.Controls.Add(IGE);
            IGE.BringToFront();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
