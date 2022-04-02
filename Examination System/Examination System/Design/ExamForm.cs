using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Design.Model;


namespace Design
{
    public partial class ExamForm : Form
    {
        int cid;
        int exid;
        public int stuid;

        Context db = new Context();
        List<GetExamQu> Qu;
        public ExamForm(int cid)
        {

            InitializeComponent();
            Qu = new List<GetExamQu>();
            this.cid = cid;
            

            
        }
        
        public ExamForm()
        {

            InitializeComponent();
          

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {   
            disExam();

        } 
        public void disExam()
        {
            var exam = (from ch in db.Choices join
                        Q in db.Questions on ch.QId equals Q.QId join
                        cq in db.ExamQuestions on Q.QId equals cq.QId join 
                        ex in db.Exams on cq.ExamId equals ex.ExamId
                        where
                        Q.Cid == cid
                        select ex.ExamId
                         ).FirstOrDefault();

            this.exid = exam;
            var Cid = new SqlParameter("Cid", SqlDbType.Int);
            Cid.Value = exam;

            Qu = db.Database.SqlQuery<GetExamQu>("Exec getExamQuestions @Cid", Cid).ToList();
            int x = 10;
            foreach (var item in Qu)
            {
                CreateQu(item.QDescription, item.answers,x);
                x += 190;
            } 


        }

        public void CreateQu(string decsQu , string QuAns , int y)
        {
            int i = 20;
            
            GroupBox g = new GroupBox();
            g.Location = new Point(0, y);
            g.Width = 1000;
            g.Height = 150;
            
            panel1.Controls.Add(g);

            string [] choices = QuAns.Split(',');
            Label l = new Label();
            l.Text = decsQu.ToString();
            l.Width = 300;
            g.Controls.Add(l);

            int x = 0;
            foreach (var item in choices)
            {
                RadioButton r = new RadioButton();
                if (x == 0)
                {
                    r.Text = "A- "+item;
                }
                else if (x == 1)
                {
                    r.Text = "B- "+item;
                }
                else if(x == 2 )
                {
                    r.Text ="C- "+item;
                }
                else
                {
                    r.Text ="D- "+item;
                }
                
                r.Width = 1000;
                
                r.Location = new Point(0, i);
                
                r.CheckedChanged += new EventHandler((s,e)=>selctAnswerr(s,e,decsQu));
                g.Controls.Add(r);
                i += 30;
                x++;
            }
            panel1.Controls.Add(g);
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            var Eid = new SqlParameter("@Eid", SqlDbType.Int);
            Eid.Value = exid;
            sqlParameters.Add(Eid);

            var sid = new SqlParameter("@stuid", SqlDbType.Int);
            sid.Value = global.Stuid;
            sqlParameters.Add(sid);

            var Cid = new SqlParameter("@Cid", SqlDbType.Int);
            Cid.Value = cid;
            

            
            var ans1 = new SqlParameter("@ans1", SqlDbType.Char);
            if (ans1 == null)
            {
                ans1.Value = ' ';
            }
            else
            {
                ans1.Value = Qu[0].StudentAnswer.ToString();

            }



            var ans2 = new SqlParameter("@ans2", SqlDbType.Char);
            if (ans2 == null)
            {
                ans2.Value = ' ';
            }
            else
            {
                ans2.Value = Qu[1].StudentAnswer.ToString();
            }
            

            var ans3 = new SqlParameter("@ans3", SqlDbType.Char);
            if (ans3 == null)
            {
                ans3.Value = ' ';
            }
            else
            {
                ans3.Value = Qu[2].StudentAnswer.ToString();
            }
           

            var ans4 = new SqlParameter("@ans4", SqlDbType.Char);
            if (ans4 == null)
            {
                ans4.Value = ' ';
            }
            else
            {
                ans4.Value = Qu[3].StudentAnswer.ToString();
            }
            

            var ans5 = new SqlParameter("@ans5", SqlDbType.Char);
            if (ans5 == null)
            {
                ans5.Value = ' ';
            }
            else
            {
                ans5.Value = Qu[4].StudentAnswer.ToString();
            }

            var ans6 = new SqlParameter("@ans6", SqlDbType.Char);
            if (ans6 == null)
            {
                ans6.Value = ' ';
            }
            else
            {
                ans6.Value = Qu[5].StudentAnswer.ToString();
            }


            var ans7 = new SqlParameter("@ans7", SqlDbType.Char);
            if (ans7 == null)
            {
                ans7.Value = ' ';
            }
            else
            {
                ans7.Value = Qu[6].StudentAnswer.ToString();
            }
            

            var ans8 = new SqlParameter("@ans8", SqlDbType.Char);
            if (ans8 == null)
            {
                ans8.Value = ' ';
            }
            else
            {
                ans8.Value = Qu[7].StudentAnswer.ToString();
            }

            var ans9 = new SqlParameter("@ans9", SqlDbType.Char);
            if (ans9 == null)
            {
                ans9.Value = ' ';
            }
            else
            {
                ans9.Value = Qu[8].StudentAnswer.ToString();
            }

            var ans10 = new SqlParameter("@ans10", SqlDbType.Char);
            if (ans10 == null)
            {
                ans10.Value = ' ';
            }
            else
            {
                ans10.Value = Qu[9].StudentAnswer.ToString();
            }
           



            
            //MessageBox.Show(sid);

            db.Database.ExecuteSqlCommand("Exec Exam_Answers @Eid , @stuId , @ans1 , @ans2 , @ans3, @ans4, @ans5, @ans6,@ans7,@ans8,@ans9,@ans10", Eid, sid, ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10);

            db.Database.ExecuteSqlCommand("Exec ExamCorrection @stuid , @Eid , @Cid", sid, Eid, Cid);

            MessageBox.Show("Good Luck ;)");
            this.Hide();


        }

        public void selctAnswerr(object sender, EventArgs e , string Qudesc)
        {
            RadioButton r = sender as RadioButton;
            Qu.Find(item => item.QDescription == Qudesc).StudentAnswer = r.Text[0] ;

            
        }

        private void Cmb_CourseName1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            disExam();

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
