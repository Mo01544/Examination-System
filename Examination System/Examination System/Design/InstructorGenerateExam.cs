using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design.Model;
namespace Design
{
    public partial class InstructorGenerateExam : UserControl
    {
        Context db = new Context();

        public InstructorGenerateExam()
        {
            InitializeComponent();
            
        }

        private void InstructorGenerateExam_Load(object sender, EventArgs e)
        {
            

            var q1 = db.Courses.ToList();
            Cmb_CourseName.ValueMember = "CId";
            Cmb_CourseName.DisplayMember = "CName";
            Cmb_CourseName.DataSource = q1;
        }
        private void txt_num_mcq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)|| txt_num_mcq.Text.Length>10)  
             { e.Handled = true; }
           
        }

        private void txt_num_TF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txt_num_TF.Text.Length > 10)
            { e.Handled = true; }
        }

        private void SubmitGenerateExam_Click(object sender, EventArgs e)
        {
            var Cid = new SqlParameter("Cid", SqlDbType.Int);
            Cid.Value = Cmb_CourseName.SelectedValue;

            var MCQ = new SqlParameter("MCQ", SqlDbType.Int);
            MCQ.Value = Cmb_CourseName.SelectedValue;

            var TorF = new SqlParameter("TorF", SqlDbType.Int);
            TorF.Value = Cmb_CourseName.SelectedValue;
            db.Database.ExecuteSqlCommand("Exec generateExam @Cid , @MCQ , @TorF", Cid, MCQ, TorF);
            MessageBox.Show("Done ;)");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
