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
    public partial class Form_teacher_mark : Form
    {

        List<Student> list;

        internal List<Student> List
        {
            get { return list; }
            set
            {
                list = value;
                dataGridView_marks.Rows.Clear();
                if (value.Count != 0)
                {
                    foreach (Student s in value)
                    {
                        Mark_REP rep = new Mark_REP();
                        dataGridView_marks.Rows.Add(s.Student_name, s.Student_surname, rep.GetMarkStudent(s.Student_login, Session.subjectname));
                        rep.Dispose();
                    }
                }
            }
        }
        public Form_teacher_mark()
        {
            InitializeComponent();
            Teacher_REP t = new Teacher_REP();
            Teacher s = t.GetTeacherByLogin(Session.user);
            label_name_student.Text = s.Teacher_name + " " + s.Teacher_surname;
            label_faculty.Text = Session.Faculty_name;
            label_group.Text = Session.Group_name;
            label_vnz.Text = Session.Vnz_name;
            lblSubj.Text = Session.subjectname;
            RefresMarks();
        }


        private void linkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Form_authorization f = new Form_authorization();
            f.Show();
            this.Close();
        }

        private void button_abolition_Click(object sender, EventArgs e)
        {
            Form_teacher_subject ts = new Form_teacher_subject();
            ts.Show();
            this.Close();
        }

        private void button_mark_Click(object sender, EventArgs e)
        {
            Form_mark fm = new Form_mark();
            Student_REP rep = new Student_REP();
            string name = String.Empty;
            string surname = String.Empty;

            if (dataGridView_marks.Rows.Count != 0)
            {
                name = dataGridView_marks[0, dataGridView_marks.CurrentRow.Index].Value.ToString();
                surname = dataGridView_marks[1, dataGridView_marks.CurrentRow.Index].Value.ToString();
            }
            if(name == String.Empty)
            {
                MessageBox.Show("Ви не вибрали студента!");
                return;
            }

            Session.student = rep.GetLogin(name, surname);


            fm.ShowDialog();
            RefresMarks();
        }

        private void Form_teacher_mark_Load(object sender, EventArgs e)
        {
            Session.close++;
        }

        private void Form_teacher_mark_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void RefresMarks()
        {
            Student_REP s = new Student_REP();
            this.List = s.ListOf(Session.Vnz_name, Session.Faculty_name, Session.Group_name);
            s.Dispose();
        }
    }
}
