using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKURSACH
{
    class Subject
    {
        string subject_name;
        string group_name;
        string teacher_login;
        string faculty_name;
        string vnz_name;
        
        public string Faculty_name
        {
            get { return faculty_name; }
            set { faculty_name = value; }
        }
        


        public string Vnz_name
        {
            get { return vnz_name; }
            set { vnz_name = value; }
        }

        

        public string Subject_name
        {
            get { return subject_name; }
            set { subject_name = value; }
        }

        

        public string Group_name
        {
            get { return group_name; }
            set { group_name = value; }
        }

        public string Teacher_login
        {
            get { return teacher_login; }
            set { teacher_login = value; }
        }
    }
}
