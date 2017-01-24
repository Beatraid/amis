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
    public partial class Form_mark : Form
    {
        public Form_mark()
        {
            InitializeComponent();
        }

        private void Form_mark_Load(object sender, EventArgs e)
        {
           
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 60 && numericUpDown1.Value > 100)
            {
                MessageBox.Show("Оцінку можна поставити [60 - 100]!");
                return;
            }

            Mark m = new Mark() { Mark_value = (int)numericUpDown1.Value, Subject_name = Session.subjectname, Student_login = Session.student };
            Mark_REP rep = new Mark_REP();
            if(!rep.CheckExists(m.Student_login, m.Subject_name))
                rep.Insert(m);
            
            Student_REP srep = new Student_REP();
            float a = rep.AvMark(Session.student);
            srep.UpdateAvrg(Session.student, a);
            srep.Dispose();
            rep.Dispose();
            this.Close();
        }
    }
}
