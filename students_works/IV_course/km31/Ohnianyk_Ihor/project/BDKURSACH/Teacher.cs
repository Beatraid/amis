using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKURSACH
{
    class Teacher
    {
        string teacher_login;
        string teacher_password;
        string teacher_name;
        string teacher_surname;
        bool is_admin;

        public bool Is_admin
        {
            get { return is_admin; }
            set { is_admin = value; }
        }

        public string Teacher_login
        {
            get { return  teacher_login; }
            set {  teacher_login = value; }
        }

        public string Teacher_password
        {
            get { return teacher_password; }
            set { teacher_password = value; }
        }

        public string Teacher_name
        {
            get { return teacher_name; }
            set { teacher_name = value; }
        }

        public string Teacher_surname
        {
            get { return teacher_surname; }
            set { teacher_surname = value; }
        }
    }
}
