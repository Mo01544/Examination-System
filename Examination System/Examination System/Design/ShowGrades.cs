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
    public partial class ShowGrades : UserControl
    {
        Context db = new Context();
        public ShowGrades()
        {
            InitializeComponent();
        }
        public int Value { get; set; }
        private void OK_Click(object sender, EventArgs e)
        {
            int id = Value;

            // txt_Grage.Text = Value.ToString();
            txt_Grage.Text = db.GradeStudentCourses.Where(n => n.SId == id && n.CId == (int)Cmb_CourseName.SelectedValue).Select(n => n.Grade).SingleOrDefault().ToString();

        }

        private void ShowGrades_Load(object sender, EventArgs e)
        {

            var q = db.Courses.ToList();
            Cmb_CourseName.DisplayMember = "CName";
            Cmb_CourseName.ValueMember = "CId";
            Cmb_CourseName.DataSource = q;
        }
    }
}
