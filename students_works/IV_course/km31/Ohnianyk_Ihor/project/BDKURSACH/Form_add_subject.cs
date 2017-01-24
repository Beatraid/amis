using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace BDKURSACH
{
    public partial class Form_add_subject : Form
    {
        public Form_add_subject()
        {
            InitializeComponent();
            Teacher_REP t = new Teacher_REP();
            Teacher s = t.GetTeacherByLogin(Session.user);
            label_name_student.Text = s.Teacher_name + " " + s.Teacher_surname;
            RefreshVNZ();
        }

        List<VNZ> vnzs;
        List<Faculty> fac;
        List<Groups> gru;
        List<Subject> sub;

        internal List<VNZ> Vnzs
        {
            get { return vnzs; }
            set
            {
                vnzs = value;
                comboBox1.Items.Clear();
                if (value.Count != 0)
                {
                    foreach (VNZ item in value)
                    {
                        comboBox1.Items.Add(item.Vnz_name);
                    }
                    comboBox1.SelectedItem = comboBox1.Items[0];
                }
            }
        }

        internal List<Faculty> Fac
        {
            get { return fac; }
            set
            {
                fac = value;
                comboBox2.Items.Clear();
                if (value.Count != 0)
                {
                    foreach (Faculty item in value)
                    {
                        comboBox2.Items.Add(item.Faculty_name);
                    }
                    comboBox2.SelectedItem = comboBox2.Items[0];
                }
            }
        }

        internal List<Groups> Gr
        {
            get { return gru; }
            set
            {
                gru = value;
                comboBox3.Items.Clear();
                if (value.Count != 0)
                {
                    foreach (Groups item in value)
                    {
                        comboBox3.Items.Add(item.Group_name);
                    }
                    comboBox3.SelectedItem = comboBox3.Items[0];
                }
            }
        }

        //internal List<Subject> Sub
        //{
        //    get { return sub; }
        //    set
        //    {
        //        sub = value;
        //        textBox1.Items.Clear();
        //        if (value.Count != 0)
        //        {
        //            foreach (Subject item in value)
        //            {
        //                textBox1.Items.Add(item.Subject_name);
        //            }
        //            textBox1.SelectedItem = textBox1.Items[0];
        //        }
        //    }
        //}

        private void RefreshVNZ()
        {
            VNZ_REP r = new VNZ_REP();
            this.Vnzs = r.ListOf();
            r.Dispose();
        }

        private void RefreshFaculty()
        {
            Faculty_REP r = new Faculty_REP();
            this.Fac = r.ListOf(comboBox1.Text);
            r.Dispose();
        }

        private void RefreshGroup()
        {
            Groups_REP r = new Groups_REP();
            this.Gr = r.ListOf(comboBox2.Text, comboBox1.Text);
            r.Dispose();
        }

        //private void RefreshSubject()
        //{
        //    Subject_REP r = new Subject_REP();
        //    this.Sub = r.ListOf(comboBox3.Text, comboBox2.Text, comboBox1.Text);
        //    r.Dispose();
        //}

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

        private void button_add_Click(object sender, EventArgs e)
        {
            Subject_REP str = new Subject_REP();

            Regex tx = new Regex(@"^(\w+)$");

            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Поле ВНЗ не може бути порожнім!");
                return;
            }

            if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Поле Факультет не може бути порожнім!");
                return;
            }

            if (comboBox3.Text == string.Empty)
            {
                MessageBox.Show("Поле Група не може бути порожнім!");
                return;
            }

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Поле Предмет не може бути порожнім!");
                return;
            }

            if (!tx.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Введені недопустимі символи в назві предмета!", "Error", MessageBoxButtons.OK);
                return;
            }

            Subject sub = new Subject() { Subject_name = textBox1.Text, Group_name = comboBox3.Text, Faculty_name = comboBox2.Text, Vnz_name = comboBox1.Text, Teacher_login = Session.user };
            if (str.CheckSubjectExist(sub))
            {
                MessageBox.Show("Такий предмет вже існує!");
                return;
            }

            str.Insert(sub);
            str.Dispose();

            Form_teacher_subject ts = new Form_teacher_subject();
            ts.Show();
            this.Close();
        }

        private void Form_add_subject_Load(object sender, EventArgs e)
        {
            Session.close++;

        }

        private void Form_add_subject_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFaculty();
            RefreshGroup();
            //RefreshSubject();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroup();
         //   RefreshSubject();

        }

        private void textBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RefreshSubject();

        }

        private void label_name_student_Click(object sender, EventArgs e)
        {

        }
    }
}
