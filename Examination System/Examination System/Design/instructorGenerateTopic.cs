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
    public partial class instructorGenerateTopic : UserControl
    {
        Context db = new Context();
        public instructorGenerateTopic()
        {
            InitializeComponent();
        }

        private void instructorGenerateTopic_Load(object sender, EventArgs e)
        {
            var q1 = db.Courses.ToList();
            Cmb_CourseName2.ValueMember = "CId";
            Cmb_CourseName2.DisplayMember = "CName";
            Cmb_CourseName2.DataSource = q1;
        }

        private void SubmitAddTopic_Click(object sender, EventArgs e)
        {
            if (txt_TopicName.Text!="") {
                Topic t = new Topic()
                {
                    TopicName = txt_TopicName.Text,
                    CId = (int)Cmb_CourseName2.SelectedValue,

                };
                db.Topics.Add(t);
                db.SaveChanges();
                txt_TopicName.Text = "";
                MessageBox.Show("all information about the Topic Added Successfully ", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Complete all information about the Question", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
