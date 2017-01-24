using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKURSACH
{
    class Mark
    {
        int mark_value;
        string student_login;
        string subject_name;

        public int Mark_value
        {
            get { return mark_value; }
            set { mark_value = value; }
        }

        public string Student_login
        {
            get { return student_login; }
            set { student_login = value; }
        }

        public string Subject_name
        {
            get { return subject_name; }
            set { subject_name = value; }
        }
    }
}
