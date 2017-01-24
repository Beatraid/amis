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
    public partial class Form_admin_choice : Form
    {
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


        public Form_admin_choice()
        {
            InitializeComponent();
            RefreshVNZ();
            RefreshFaculty();
            RefreshGroup();
            
        }
        private void Form_admin_choice_Load(object sender, EventArgs e)
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

        private void button_admin_next_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Не вибраний ВНЗ");
                return;
            }

            if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Не вибраний Факультет");
                return;
            }

            if (comboBox3.Text == string.Empty)
            {
                MessageBox.Show("Не вибрана Група");
                return;
            }

            Form_admin_edit ae = new Form_admin_edit(comboBox1.Text, comboBox2.Text, comboBox3.Text);
            ae.Show();
            this.Close();
        }

        private void linkLabel_add_vnz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.VFG = VnzFaciltyGroup.vnz;
            Form_admin_add aa = new Form_admin_add();
            aa.ShowDialog();
            RefreshVNZ();
        }

        private void linkLabel_add_faculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.VFG = VnzFaciltyGroup.faculty;

            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Не вибрано ВНЗ!");
                return;
            }            

            Session.Vnz_name = comboBox1.Text;

            Form_admin_add aa = new Form_admin_add();
            aa.ShowDialog();
            RefreshFaculty();       
        }

        private void linkLabel_add_group_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.VFG = VnzFaciltyGroup.group;

            if (comboBox1.Text == string.Empty || comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Не вибрано ВНЗ або Факультет!");
                return;
            }

            Session.Vnz_name = comboBox1.Text;
            Session.Faculty_name = comboBox2.Text;

            Form_admin_add aa = new Form_admin_add();
            aa.ShowDialog();
            RefreshGroup();     
        }

        private void Form_admin_choice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.close--;
            if (Session.close == 0)
                Application.Exit();
        }

        private void button_abolition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте вийти?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 

            Session.close--;
            if (Session.close == 0)
                Application.Exit();
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
            this.Gr = r.ListOf(comboBox2.Text, comboBox1.Text);
            r.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFaculty();
            RefreshGroup();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroup();
        }

        private void linkLabel_delete_vnz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Не вибраний ВНЗ");
                return;
            }
            if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 
            VNZ v = new VNZ()
            {
                Vnz_name = comboBox1.Text
            };

            VNZ_REP vr = new VNZ_REP();
            if (vr.CheckVNZName(v.Vnz_name))
            {
                vr.Delete(v);

                RefreshVNZ();
                RefreshFaculty();
                RefreshGroup();
            }
            else
            {
                MessageBox.Show("Такого вуза не існує!");
            }
        }

        private void linkLabel_delete_faculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Не вибраний Факультет");
                return;
            }

            if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 


            Faculty v = new Faculty()
            {
                Faculty_name = comboBox2.Text,
                Vnz_name = comboBox1.Text
            };

            Faculty_REP vr = new Faculty_REP();
            if (vr.CheckFacultyName(v.Faculty_name, v.Vnz_name))
            {
                vr.Delete(v);

                RefreshFaculty();
                RefreshGroup();
            }
            else
            {
                MessageBox.Show("Такого факультета не існує!");
            }
        }

        private void linkLabel_delete_group_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox3.Text == string.Empty)
            {
                MessageBox.Show("Не вибрана Група");
                return;
            }

            if (MessageBox.Show("Ви дійсно бажаєте видалити?", "Вікно підтвердження", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) { return; } 


            Groups v = new Groups()
            {
                Group_name = comboBox3.Text,
                Faculty_name = comboBox2.Text,
                Vnz_name = comboBox1.Text
            };

            Groups_REP gr = new Groups_REP();
            if (gr.CheckGroupName(v.Group_name, v.Faculty_name, v.Vnz_name))
            {
                gr.Delete(v);

                RefreshGroup();
            }
            else
            {
                MessageBox.Show("Такої групи не існує!");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_vnz_name_Click(object sender, EventArgs e)
        {

        }

    }
}
