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
    public partial class Form_teacher_subject : Form
    {
        List<Subject> list;

        internal List<Subject> List
        {
            get { return list; }
            set
            {
                list = value;
                dataGridView_marks.Rows.Clear();
                foreach(Subject item in value)
                {
                    dataGridView_marks.Rows.Add(item.Subject_name, item.Vnz_name, item.Faculty_name, item.Group_name);
                }
            }
        }

        public Form_teacher_subject()
        {
            InitializeComponent();
            Teacher_REP t = new Teacher_REP();
            Teacher s = t.GetTeacherByLogin(Session.user);
            label_name_teacher.Text = s.Teacher_name + " " + s.Teacher_surname;
            RefreshSubjects();
        }

        private void Form_teacher_subject_Load(object sender, EventArgs e)
        {
            Session.close++;
        }

        private void dataGridView_marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Form_authorization f = new Form_authorization();
            f.Show();
            this.Close();
        }

        private void Form_teacher_subject_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void button_admin_next_Click(object sender, EventArgs e)
        {

            string vnz_name = String.Empty;
            string faculty_name = String.Empty;
            string group_name = String.Empty;
            string subj = String.Empty;

            if (dataGridView_marks.Rows.Count != 0)
            {
                vnz_name = dataGridView_marks[1, dataGridView_marks.CurrentRow.Index].Value.ToString();
                faculty_name = dataGridView_marks[2, dataGridView_marks.CurrentRow.Index].Value.ToString();
                group_name = dataGridView_marks[3, dataGridView_marks.CurrentRow.Index].Value.ToString();
                subj = dataGridView_marks[0, dataGridView_marks.CurrentRow.Index].Value.ToString();
            }

            if (vnz_name == String.Empty)
            {
                MessageBox.Show("Не вибраний предмет!");
                return;
            }

            Session.Faculty_name = faculty_name;
            Session.Group_name = group_name;
            Session.Vnz_name = vnz_name;
            Session.subjectname = subj;

            Form_teacher_mark tm = new Form_teacher_mark();
            tm.Show();
            this.Close();
        }

        private void button_abolition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 
            
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void button_add_sabject_Click(object sender, EventArgs e)
        {
            Form_add_subject ad = new Form_add_subject();
            ad.Show();
            this.Close();
        }

        public void RefreshSubjects()
        {

            Subject_REP rep = new Subject_REP();
            this.List = rep.ListOf(Session.user);
            rep.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Subject sub = new Subject();
            string name_subject = String.Empty;
            string vnz_name = String.Empty;
            string faculty_name = String.Empty;
            string group_name = String.Empty;

            if (dataGridView_marks.Rows.Count != 0)
            {
                name_subject = dataGridView_marks[0, dataGridView_marks.CurrentRow.Index].Value.ToString();
                vnz_name = dataGridView_marks[1, dataGridView_marks.CurrentRow.Index].Value.ToString();
                faculty_name = dataGridView_marks[2, dataGridView_marks.CurrentRow.Index].Value.ToString();
                group_name = dataGridView_marks[3, dataGridView_marks.CurrentRow.Index].Value.ToString();
            }

            if(name_subject == String.Empty)
            {
                MessageBox.Show("Не вибраний студент!");
                return;
            }
            if (name_subject != String.Empty)
            {
                if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            sub.Subject_name = name_subject;
            sub.Vnz_name = vnz_name;
            sub.Faculty_name = faculty_name;
            sub.Group_name = group_name;
            sub.Teacher_login = Session.user;

            Subject_REP rep = new Subject_REP();
            if(rep.CheckSubjectExist(sub))
                rep.Delete(sub);
            else
            {
                MessageBox.Show("Такого студента не існує!");
                return;
            }
            rep.Dispose();
            RefreshSubjects();

        }

        private void label_name_teacher_Click(object sender, EventArgs e)
        {

        }
    }
}
