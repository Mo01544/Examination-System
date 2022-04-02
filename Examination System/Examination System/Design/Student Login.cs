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
    public partial class Student_Login : Form
    {
        int crid;
        Context db = new Context();
        int selectedCrId;
        public Student_Login()
        {
            InitializeComponent();
            
          
        }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public int SID { get; set; }

        private void btn_startExam_Click(object sender, EventArgs e)
        {
            crid = int.Parse(Cmb_CourseName1.SelectedValue.ToString());
            var q1 = db.GradeStudentCourses.Where(n => n.CId == crid && n.SId == global.Stuid).Select(n =>n.Grade).FirstOrDefault();

            
                ExamForm EF = new ExamForm(selectedCrId);
                EF.Show();
           

            
                //MessageBox.Show("U already take this exam");
            
            
            
        }
        private void btn_showGrades_Click(object sender, EventArgs e)
        {
           ShowGrades ShG = new ShowGrades();
            panel3.Controls.Add(ShG);
            ShG.BringToFront();
            ShG.Value = SID;


        }

        public void Student_Login_Load(object sender, EventArgs e)
        {


            var cr = db.Courses.ToList();
            Cmb_CourseName1.ValueMember = "CId";
            Cmb_CourseName1.DisplayMember = "CName";
            Cmb_CourseName1.DataSource = cr;

            SNameLabel.Text = Name.ToString();
            txt_username.Text = UserName.ToString();
            txt_Department.Text = Department.ToString();
            id_label.Text = SID.ToString();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Student_Login_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cmb_CourseName1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cm = (ComboBox)sender;

            selectedCrId = (int)cm.SelectedValue;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
