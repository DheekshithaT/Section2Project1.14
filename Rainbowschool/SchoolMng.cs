using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbowschool;
public class SchoolMng
{
    static List<Students> students = new List<Students>()
    {
    new Students(){RollNumber=1,FirstName="Ravi",LastName="Kumar",DOB=new DateTime(2001, 2, 6)},
    new Students(){RollNumber=2,FirstName="Sneha",LastName="Sharma",DOB=new DateTime(1999, 8, 1)},
    new Students(){RollNumber=3,FirstName="Amit",LastName="Patel",DOB=new DateTime(2000, 6, 12)}
    };

    static List<Teachers> teachList = new List<Teachers>()
    {
        new Teachers(){Tid=1,TeacherName="Sanvi"},
        new Teachers(){Tid=2,TeacherName="Taee"},
        new Teachers(){Tid=3,TeacherName="Jayyykayy"},
        new Teachers(){Tid=4,TeacherName="Lavanya"}
    };
    static List<Subjects> SubList = new List<Subjects>()
    {
        new Subjects(){SubjectId=1012,SubjectName="Music"},
        new Subjects(){SubjectId=2012,SubjectName="Social Studies"},
        new Subjects(){SubjectId=1291,SubjectName="Science" },
        new Subjects(){SubjectId=1234,SubjectName="English Literature"}
    };
    public static List<Students> AllStudents()
    {
        return students;
    }
    public static List<Students> EmpById(int id)
    {
        List<Students> emp = students.FindAll(e => e.RollNumber == id);
        return emp;
    }
    public static List<Teachers> allTeacher()
    {
        return teachList;
    }
    public static List<Subjects> AllSubs()
    {
        return SubList;
    }
}