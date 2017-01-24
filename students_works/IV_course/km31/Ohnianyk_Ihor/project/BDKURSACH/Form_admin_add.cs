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
    public partial class Form_admin_add : Form
    {
        public Form_admin_add()
        {
            InitializeComponent();
            if (Session.VFG == VnzFaciltyGroup.vnz)
            {
                label1.Text = "Введіть назву ВНЗ";
            }

            if (Session.VFG == VnzFaciltyGroup.faculty)
            {
                label1.Text = "Введіть назву факультета";
            }

            if (Session.VFG == VnzFaciltyGroup.group)
            {
                label1.Text = "Введіть назву  групи";
            }
        }

        private void linkLabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Form_authorization f = new Form_authorization();
            f.Show();
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (Session.VFG == VnzFaciltyGroup.vnz)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Поле не може бути порожнє!");
                    return;
                }

                Regex tx = new Regex(@"^(\w+)$");
                if (!tx.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в назві ВНЗ!", "Error", MessageBoxButtons.OK);
                    return;
                }

                VNZ v = new VNZ() { Vnz_name = textBox1.Text };
                VNZ_REP r = new VNZ_REP();
                if(r.CheckVNZName(v.Vnz_name))
                {
                    MessageBox.Show("Введена назва існує!");
                    return;
                }
                r.Insert(v);
                this.Close();
            }


            if (Session.VFG == VnzFaciltyGroup.faculty)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Поле не може бути порожнє!");
                    return;
                }

                Regex tx = new Regex(@"^(\w+)$");
                if (!tx.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("Введені недопустимі символи в назві Факультета!", "Error", MessageBoxButtons.OK);
                    return;
                }

                Faculty v = new Faculty() { Faculty_name = textBox1.Text , Vnz_name=Session.Vnz_name};
                Faculty_REP r = new Faculty_REP();
                if (r.CheckFacultyName(v.Faculty_name, v.Vnz_name))
                {
                    MessageBox.Show("Введена назва існує!");
                    return;
                }
                r.Insert(v);
                this.Close();
            }

            if (Session.VFG == VnzFaciltyGroup.group)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Поле не може бути порожнє!");
                    return;
                }

                Regex group = new Regex(@"^([A-Z]{2}-[0-9]{2})$"); 
                Regex l = new Regex(@"^([А-Я]{2}-[0-9]{2})$");
                if (!group.IsMatch(textBox1.Text) && !l.IsMatch(textBox1.Text)) 
                {
                    MessageBox.Show("Введено некоректну назву групу! Введіть в форматі: АА-11", "Error", MessageBoxButtons.OK);
                    return;
                }

                Groups v = new Groups() { Group_name = textBox1.Text, Vnz_name = Session.Vnz_name, Faculty_name = Session.Faculty_name };
                Groups_REP r = new Groups_REP();
                if (r.CheckGroupName(v.Group_name,  v.Faculty_name, v.Vnz_name))
                {
                    MessageBox.Show("Введена назва існує!");
                    return;
                }
                r.Insert(v);
                this.Close();
            }


            this.Close();
        }

        private void button_abolition_Click(object sender, EventArgs e)
        {
            Form_admin_choice ac = new Form_admin_choice();
            ac.Show();
            this.Close();
        }

        private void Form_admin_add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void Form_admin_add_Load(object sender, EventArgs e)
        {
            Session.close++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
