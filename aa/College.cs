using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class College
    {
        public string Name { get; set; }
        public int StudentCount { get; set; }
        public int ClassroomCount { get; set; }
        public int TeacherCount { get; set; }

        public static bool operator <(College a, College b)
        {
            if (a.StudentCount == b.StudentCount)
                return a.ClassroomCount < b.ClassroomCount;
            return a.StudentCount < b.StudentCount;
        }

        public static bool operator >(College a, College b)
        {
            if (a.StudentCount == b.StudentCount)
                return a.ClassroomCount > b.ClassroomCount;
            return a.StudentCount > b.StudentCount;
        }
    }

    public static class Standard
    {
        public static int StudentCount = 100;
        public static int TeacherCount = 10;

        //проверка соответствия стандартам
        public static bool CheckStandards(College college)
        {
            return college.StudentCount >= StudentCount && college.TeacherCount >= TeacherCount;
        }
    }
}
