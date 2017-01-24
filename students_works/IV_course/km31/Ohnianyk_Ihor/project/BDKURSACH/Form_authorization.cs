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
    public partial class Form_authorization : Form
    {
        public Form_authorization()
        {
            InitializeComponent();
            RefreshVNZ();
            if (Session.LR == LoginRegistration.login)
            {
                textBox_name.Visible = false;
                textBox_surname.Visible = false;
                label_name.Visible = false;
                label_surname.Visible = false;
                label_faculty.Visible = false;
                label_group.Visible = false;
                label_vnz.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                buton_exit.Text = "Відміна";
                textBox_login.Location = new Point(228, 156);
                textBox_password.Location = new Point(228, 197);
                radioButton_student.Location = new Point(228, 235);
                radioButton_teacher.Location = new Point(228, 258);
                label_login.Location = new Point(118, 156);
                label_password.Location = new Point(118, 197);
                label_function.Location = new Point(118, 248);





            }

            if (Session.LR == LoginRegistration.registration_student)
            {
                linkLabel_registration.Visible = false;
                button_authorization.Text = "Реєстрація";
                radioButton_student.Visible = false;
                radioButton_teacher.Visible = false;
                label_function.Visible = false;
                lable_authorization.Text = "Реєстрація студента";
                textBox_name.Location = new Point(128, 128);
                textBox_surname.Location = new Point(128, 168);
                textBox_login.Location = new Point(128, 216);
                textBox_password.Location = new Point(128, 257);
                label_name.Location = new Point(18, 128);
                label_surname.Location = new Point(18, 168);
                label_login.Location = new Point(18, 216);
                label_password.Location = new Point(18, 257);
                label_vnz.Location = new Point(337, 150);
                label_faculty.Location = new Point(309, 202);
                label_group.Location = new Point(330, 251);
                comboBox1.Location = new Point(378, 150);
                comboBox3.Location = new Point(378, 202);
                comboBox2.Location = new Point(378, 251);
            }

            if (Session.LR == LoginRegistration.registration_teacher)
            {
                linkLabel_registration.Visible = false;
                button_authorization.Text = "Реєстрація";
                radioButton_student.Visible = false;
                radioButton_teacher.Visible = false;
                label_function.Visible = false;
                lable_authorization.Text = "Реєстрація викладача";
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                label_vnz.Visible = false;
                label_faculty.Visible = false;
                label_group.Visible = false;
                textBox_name.Location = new Point(228, 128);
                textBox_surname.Location = new Point(228, 168);
                textBox_login.Location = new Point(228, 216);
                textBox_password.Location = new Point(228, 257);
                label_name.Location = new Point(118, 128);
                label_surname.Location = new Point(118, 168);
                label_login.Location = new Point(118, 216);
                label_password.Location = new Point(118, 257);
            }
          
        }

        List<VNZ> vnzs;
        List<Faculty> fac;
        List<Groups> gru;

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
                comboBox3.Items.Clear();
                if (value.Count != 0)
                {
                    foreach (Faculty item in value)
                    {
                        comboBox3.Items.Add(item.Faculty_name);
                    }
                    comboBox3.SelectedItem = comboBox3.Items[0];
                }
            }
        }

        internal List<Groups> Gr
        {
            get { return gru; }
            set
            {
                gru = value;
                comboBox2.Items.Clear();
                if (value.Count != 0)
                {
                    foreach (Groups item in value)
                    {
                        comboBox2.Items.Add(item.Group_name);
                    }
                    comboBox2.SelectedItem = comboBox2.Items[0];
                }
            }
        }

        

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
            this.Gr = r.ListOf(comboBox3.Text, comboBox1.Text);
            r.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFaculty();
            RefreshGroup();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroup();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Session.close++;
        }


        private void Form_authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void buton_exit_Click(object sender, EventArgs e)
        {
            if (Session.LR == LoginRegistration.login)
            {
                if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; }
                Application.Exit();
            }
                
            if (Session.LR == LoginRegistration.registration_student)
            {
                Session.LR = LoginRegistration.login;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }
            if (Session.LR == LoginRegistration.registration_teacher)
            {
                Session.LR = LoginRegistration.login;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }
        }

        private void linkLabel_registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton_student.Checked == false && radioButton_teacher.Checked == false)
            {
                MessageBox.Show("Виберіть одне із значень перемикачів!");
                return;
            }

            if (radioButton_student.Checked == true && Session.LR == LoginRegistration.login)
            {
                Session.LR = LoginRegistration.registration_student;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }

            if (radioButton_teacher.Checked == true && Session.LR == LoginRegistration.login)
            {
                Session.LR = LoginRegistration.registration_teacher;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            if (radioButton_student.Checked == false && radioButton_teacher.Checked == false && Session.LR == LoginRegistration.login)
            {
                MessageBox.Show("Виберіть одне із значень перемикачів!");
                return;
            }

            if (radioButton_student.Checked == true && Session.LR == LoginRegistration.login)
            {
                Session.STA = StudentTeacherAdmin.student;
                Student_REP sr = new Student_REP();

                if (textBox_login.Text == string.Empty)
                {
                    MessageBox.Show("Не введено логін!");
                    return;
                }

                if (textBox_password.Text == string.Empty)
                {
                    MessageBox.Show("Не введено пароль!");
                    return;
                }

                if (!sr.CheckStudentExist(textBox_login.Text))
                {
                    MessageBox.Show("Студента з таким логіном не існує!");
                    return;
                }
                
                if (!sr.CheckStudent(textBox_login.Text, DataBase.CalcMD5(textBox_password.Text)))
                {
                    MessageBox.Show("Помилка! Невірний пароль!");
                    return;
                }


                Session.user = textBox_login.Text;
                Form_student s = new Form_student();

                s.Show();
                this.Close();
            }

            if (radioButton_teacher.Checked == true && Session.LR == LoginRegistration.login)
            {
                Session.STA = StudentTeacherAdmin.teacher;
                Teacher_REP tr = new Teacher_REP();

                if (textBox_login.Text == string.Empty)
                {
                    MessageBox.Show("Поле Логін не може бути порожнє!");
                    return;
                }

                if (textBox_password.Text == string.Empty)
                {
                    MessageBox.Show("Поле Пароль не може бути порожнє!");
                    return;
                }

                if (!tr.CheckTeacherExist(textBox_login.Text))
                {
                    MessageBox.Show("Викладача з таким логіном не існує!");
                    return;
                }

                if (!tr.CheckTeacher(textBox_login.Text, DataBase.CalcMD5( textBox_password.Text)))
                {
                    MessageBox.Show("Помилка! Невірний пароль!");
                    return;
                }
                Session.user = textBox_login.Text;

                if (tr.CheckAdmin(textBox_login.Text))
                {
                    Session.STA = StudentTeacherAdmin.admin;
                }

                if (Session.STA == StudentTeacherAdmin.teacher)
                {
                    Form_teacher_subject t = new Form_teacher_subject();
                    t.Show();
                    this.Close();
                }

                if (Session.STA == StudentTeacherAdmin.admin)
                {
                    Form_admin_choice t = new Form_admin_choice();
                    t.Show();
                    this.Close();
                }
            }

            if (Session.LR == LoginRegistration.registration_student)
            {
                Student_REP str = new Student_REP();

                Regex login = new Regex(@"([w-]+)"); 
                Regex l = new Regex(@"(\w+)");
                Regex tx = new Regex(@"^(\w+)$");

                if (textBox_name.Text == string.Empty)
                {
                    MessageBox.Show("Поле Ім'я не може бути порожнє!");
                    return;
                }

                if (!l.IsMatch(textBox_name.Text) && login.IsMatch(textBox_name.Text)) 
                {
                    MessageBox.Show("Введені недопустимі символи в Імені!", "Error", MessageBoxButtons.OK);
                    return; 
                }


                if (textBox_surname.Text == string.Empty)
                {
                    MessageBox.Show("Поле Прізвище не може бути порожнє!");
                    return;
                }

                if (!l.IsMatch(textBox_surname.Text) && login.IsMatch(textBox_surname.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в Прізвищі!", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (textBox_login.Text == string.Empty)
                {
                    MessageBox.Show("Поле Логін не може бути порожнє!");
                    return;
                }

                if (!tx.IsMatch(textBox_login.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в логіні!", "Error", MessageBoxButtons.OK);
                    return;
                }


                if (textBox_password.Text == string.Empty)
                {
                    MessageBox.Show("Поле Пароль не може бути порожнє!");
                    return;
                }

                if (!tx.IsMatch(textBox_password.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в паролі!", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Не вибрано ВНЗ!");
                    return;
                }

                if (comboBox3.Text == string.Empty)
                {
                    MessageBox.Show("Не вибрано Факультет!");
                    return;
                }

                if (comboBox2.Text == string.Empty)
                {
                    MessageBox.Show("Не вибрано Групу!");
                    return;
                }


                Student st = new Student()
                {

                    Student_login = textBox_login.Text,
                    Student_password = DataBase.CalcMD5(textBox_password.Text),
                    Student_name = textBox_name.Text,
                    Student_surname = textBox_surname.Text,
                    Group_name = comboBox2.Text,
                    Faculty_name = comboBox3.Text,
                    Vnz_name = comboBox1.Text

                };

                str.Insert(st);
                str.Dispose();
                Session.LR = LoginRegistration.login;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }

            //Для викладача реєстрація
            if (Session.LR == LoginRegistration.registration_teacher)
            {
                Teacher_REP str = new Teacher_REP();
                Regex tx = new Regex(@"^(\w+)$");
                Regex login = new Regex(@"([w-]+)");
                Regex l = new Regex(@"(\w+)");

                if (textBox_name.Text == string.Empty)
                {
                    MessageBox.Show("Поле Ім'я не може бути порожнє!");
                    return;
                }

                if (!l.IsMatch(textBox_name.Text) && login.IsMatch(textBox_name.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в Імені!", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (!l.IsMatch(textBox_surname.Text) && login.IsMatch(textBox_surname.Text))
                {
                    MessageBox.Show("Поле Прізвище не може бути порожнє!");
                    return;
                }

                if (!tx.IsMatch(textBox_surname.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в Прізвищі!", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (textBox_login.Text == string.Empty)
                {
                    MessageBox.Show("Поле Логін не може бути порожнє!");
                    return;
                }

                if (!tx.IsMatch(textBox_login.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в логіні!", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (str.CheckTeacherExist(textBox_login.Text))
                {
                    MessageBox.Show("Студент з таким логіном вже існує!");
                    return;
                }

                if (textBox_password.Text == string.Empty)
                {
                    MessageBox.Show("Поле Пароль не може бути порожнє!");
                    return;
                }

                if (!tx.IsMatch(textBox_password.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в паролі!", "Error", MessageBoxButtons.OK);
                    return;
                }

                Teacher st = new Teacher()
                {

                    Teacher_login = textBox_login.Text,
                    Teacher_password = DataBase.CalcMD5(textBox_password.Text),
                    Teacher_name = textBox_name.Text,
                    Teacher_surname = textBox_surname.Text,

                };

                str.Insert(st);
                str.Dispose();
                Session.LR = LoginRegistration.login;
                Form_authorization f = new Form_authorization();
                f.Show();
                this.Close();
            }

            
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_student_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
