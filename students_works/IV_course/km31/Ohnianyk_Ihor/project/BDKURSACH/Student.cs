using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKURSACH
{
    class Student
    {
        string student_login;
        string student_password;
        string student_name;
        string student_surname;
        float average;
        string group_name;
        string faculty_name;
        string vnz_name;

        public string Vnz_name
        {
            get { return vnz_name; }
            set { vnz_name = value; }
        }

        public string Faculty_name
        {
            get { return faculty_name; }
            set { faculty_name = value; }
        }




        public string Student_login
        {
            get { return student_login; }
            set { student_login = value; }
        }

        public string Student_password
        {
            get { return student_password; }
            set { student_password = value; }
        }

        public string Student_name
        {
            get { return student_name; }
            set { student_name = value; }
        }

        public string Student_surname
        {
            get { return student_surname; }
            set { student_surname = value; }
        }

        public float Average
        {
            get { return average; }
            set { average = value; }
        }

        public string Group_name
        {
            get { return group_name; }
            set { group_name = value; }
        }

       
    }
}
