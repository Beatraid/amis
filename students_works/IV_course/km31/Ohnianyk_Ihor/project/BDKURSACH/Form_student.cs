using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDKURSACH
{
    public partial class Form_student : Form
    {
        List<Mark> subs;

        internal List<Mark> Subs
        {
            get { return subs; }
            set
            {
                subs = value;
                dataGridView_marks.Rows.Clear();
                if(value.Count!=0)
                {
                    foreach(Mark s in value)
                    {
                        dataGridView_marks.Rows.Add(s.Subject_name, s.Mark_value);
                    }
                }
            }
        }


        public Form_student()
        {
            InitializeComponent();
            Student_REP r = new Student_REP();
            Student s = r.GetStudentByLogin(Session.user);
            Mark_REP mr = new Mark_REP();
            label_average.Text = "Середній бал: " + mr.AvMark(Session.user); ;
            label_faculty.Text = s.Faculty_name;
            label_group.Text = s.Group_name;
            label_vnz.Text = s.Vnz_name;
            label_name_student.Text = s.Student_name + " " + s.Student_surname;
            string a = (s.Average >= 75) ? "Так" : "Ні";
            label_many.Text = "Нарахування стипендії: " + a;
            RefreshMarks();
        }


        private void Form_student_Load(object sender, EventArgs e)
        {
            Session.close++;
        }

        private void linkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Form_authorization f = new Form_authorization();
            f.Show();
            this.Close();
        }

        private void label_vnz_Click(object sender, EventArgs e)
        {

        }

        private void label_faculty_Click(object sender, EventArgs e)
        {

        }

        private void label_name_student_Click(object sender, EventArgs e)
        {

        }

        private void label_many_Click(object sender, EventArgs e)
        {

        }

        private void Form_student_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void button_abolition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void RefreshMarks()
        {
            Mark_REP m = new Mark_REP();
            this.Subs = m.ListOf(Session.user);
            m.Dispose();
        }

        private void label_average_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
