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
    public partial class Form_admin_edit : Form
    {
        List<Student> list;
        string vnz_name;
        string faculty_name;
        string group_name;

        internal List<Student> List
        {
          get { return list; }
          set 
          {
              list = value;
              dataGridView_student.Rows.Clear();
              if (value.Count != 0)
              {
                  foreach (Student s in value)
                  {
                      dataGridView_student.Rows.Add(s.Student_name, s.Student_surname, s.Student_login);
                  }
              }
          }

        }

        



        public Form_admin_edit(string vnz_name, string faculty, string group)
        {
            this.vnz_name = vnz_name;
            this.faculty_name = faculty;
            this.group_name = group;
            InitializeComponent();
           
            
            //RefresStudent();
        }

        private void linkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Form_authorization f = new Form_authorization();
            f.Show();
            this.Close();
        }

        private void Form_admin_edit_Load(object sender, EventArgs e)
        {

            label_faculty.Text = faculty_name;
            label_group.Text = group_name;
            label_vnz.Text =vnz_name;
            RefresStudent();
            Session.close++;
        }

        private void Form_admin_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void button_admin_back_Click(object sender, EventArgs e)
        {
            Form_admin_choice ac = new Form_admin_choice();
            ac.Show();
            this.Close();
        }

        private void RefresStudent()
        {
            Student_REP s = new Student_REP();
            this.List = s.ListOf(vnz_name, faculty_name, group_name);
            s.Dispose();
        }

        private void linkLabel_delete_student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string student_login;
            
            if (dataGridView_student.Rows.Count < 1)
            {
                MessageBox.Show("Не вибраний студент!");
                return;
            }
            student_login = dataGridView_student[2, dataGridView_student.CurrentRow.Index].Value.ToString();

            Student_REP sr = new Student_REP();
            Student s = sr.GetStudentByLogin(student_login);
            sr.Delete(s);
            sr.Dispose();
            RefresStudent();

            if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 


        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
