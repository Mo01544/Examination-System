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
    public partial class InstructorCreateQuestion : UserControl
    {
        Context db = new Context();
        public InstructorCreateQuestion()
        {
            InitializeComponent();
        }

        private void InstructorCreateQuestion_Load(object sender, EventArgs e)
        {
            GBoxMCQ.Visible = false;
            GboxTF.Visible = false;

            var q1 = db.Courses.ToList();
            Cmb_CourseName.ValueMember = "CId";
            Cmb_CourseName.DisplayMember = "CName";
            Cmb_CourseName.DataSource = q1;


        }

        private void Rbtn_Mcq_CheckedChanged(object sender, EventArgs e)
        {
            GBoxMCQ.Visible = true;
            GboxTF.Visible = false;
        }

        private void Rbtn_TF_CheckedChanged(object sender, EventArgs e)
        {
            GboxTF.Visible = true;
            GBoxMCQ.Visible = false;
        }

        private void SubmitMCQ_Click(object sender, EventArgs e)
        {
            if (NQForMCQ.Text != "" && MAforMCQ.Text != "")
            {
                Question q = new Question()
                {
                    QDescription = NQForMCQ.Text,
                    QType = "MCQ",
                    Model_Answer = MAforMCQ.Text,
                    Cid = (int)Cmb_CourseName.SelectedValue

                };
                int qid = q.QId;
                Choice c1 = new Choice()
                {
                    QId = qid,
                    Choice1 = "A",
                    Description = txt_description1.Text,
                };
                Choice c2 = new Choice()
                {
                    QId = qid,
                    Choice1 = "B",
                    Description = txt_description2.Text,
                }; 
                Choice c3 = new Choice()
                {
                    QId = qid,
                    Choice1 = "C",
                    Description = txt_description3.Text,
                }; 
                Choice c4 = new Choice()
                {
                    QId = qid,
                    Choice1 = "D",
                    Description = txt_description4.Text,
                };

                db.Questions.Add(q);


                db.Choices.Add(c1);
                db.Choices.Add(c2);
                db.Choices.Add(c3);
                db.Choices.Add(c4);

                db.SaveChanges();
                MessageBox.Show("all information about the Question Added Successfully ", "Success", MessageBoxButtons.OK);
                NQForMCQ.Text = MAforMCQ.Text = txt_description1.Text = txt_description2.Text = txt_description3.Text = txt_description4.Text = "";

            }
            else
            {
                MessageBox.Show("Complete all information about the Question", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SubmitTF_Click(object sender, EventArgs e)
        {
            if (NQforTF.Text != "" && MAforTF.Text != "")
            {
                Question q = new Question()
                {
                    QDescription = NQforTF.Text,
                    QType = "T/F",
                    Model_Answer = MAforTF.Text,
                    Cid = (int)Cmb_CourseName.SelectedValue

                };
                int qid = q.QId;
                Choice c1 = new Choice()
                {
                    QId = qid,
                    Choice1 = "T",
                    Description = ""
                };
                Choice c2 = new Choice()
                {
                    QId = qid,
                    Choice1 = "F",
                    Description = ""
                };

                db.Questions.Add(q);
                db.Choices.Add(c1);
                db.Choices.Add(c2);
                db.SaveChanges();
                MessageBox.Show("all information about the Question Added Successfully ", "Success", MessageBoxButtons.OK);
                NQforTF.Text = MAforTF.Text = "";
            }
            else
            {
                MessageBox.Show("Complete all information about the Question", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }




   










}
