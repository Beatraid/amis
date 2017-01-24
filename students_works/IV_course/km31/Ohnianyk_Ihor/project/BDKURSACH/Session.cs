using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKURSACH
{
    public static class Session
    {
        public static LoginRegistration LR;

        public static int close;

        public static StudentTeacherAdmin STA;

        public static VnzFaciltyGroup VFG;
        public static string student;
        public static string Vnz_name;
        public static string subjectname;
        public static string Faculty_name;
        public static string user;
        public static string Group_name;
    }
    public enum LoginRegistration
    {
        login, registration_student, registration_teacher
    };

    public enum StudentTeacherAdmin
    {
        student, teacher, admin
    };

    public enum VnzFaciltyGroup
    {
        vnz, faculty, group
    }
}
