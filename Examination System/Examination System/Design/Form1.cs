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
    public partial class Form1 : Form
    {
        Context db = new Context();
        public Form1()
        {
            InitializeComponent();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
          
                
              if(db.C_User.Where(n => n.userName == txt_userName.Text && n.Password==txt_Password.Text).Select(n=>n.UserType).SingleOrDefault()=="s")
                {
                var q=db.C_User.Where(n => n.userName == txt_userName.Text && n.Password == txt_Password.Text).Select(n => n.UID).SingleOrDefault();
                    
                var q2 = db.C_User.Where(n => n.userName == txt_userName.Text && n.Password == txt_Password.Text).Select(n => n.FName+n.LName).SingleOrDefault();
                var q3 = db.C_User.Where(n => n.userName == txt_userName.Text && n.Password == txt_Password.Text).Select(n => n.userName).SingleOrDefault();
                var q4 = db.Students.Where(n => n.StID == q).Select(n => n.Deptid.Value).SingleOrDefault();
                var q5 = db.Departments.Where(n => n.DeptID == q4).Select(n => n.DeptName).SingleOrDefault();

                var q6 = db.C_User.Where(n => n.userName == txt_userName.Text && n.Password == txt_Password.Text).Select(n => n.UID).SingleOrDefault();

               



                Student_Login SL = new Student_Login();
                SL.SID = q6;
                SL.Name = q2.ToString();
                SL.UserName = q3.ToString();
                SL.Department = q5.ToString();
                SL.Show();
                this.Hide();



                

                global.Stuid = q6;
                
                

            }
            else if(db.C_User.Where(n => n.userName == txt_userName.Text && n.Password == txt_Password.Text).Select(n => n.UserType).SingleOrDefault() == "i")
                {
                    Instructor ins = new Instructor();
                    ins.Show();
                    this.Hide();
                }
            else
            {
                MessageBox.Show("Invalid Username OR Password ", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructor ins = new Instructor();
            ins.Show();
            this.Hide();

        }

        private void Submit_MouseHover(object sender, EventArgs e)
        {
         //  Submit.BackColor = Color.IndianRed;
        }

        private void Submit_Leave(object sender, EventArgs e)
        {
           // Submit.BackColor = Color.IndianRed;

        }

        private void Submit_MouseLeave(object sender, EventArgs e)
        {
            //Submit.BackColor = Color.Brown;

        }
    }
}
