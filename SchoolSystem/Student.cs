using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Student : Person
    {
        int[] marks = new int[4];

        String GetMarks()
        {
            //Console.WriteLine(string.Join(", ", marks));
            /*string temp = "";
            for (int i = 0; i < marks.Length; i++)
                temp = temp + marks[i] + ",";
                */
            //return temp;
            return string.Join(", ", marks);
        }
        public Student(int iId, string iSurn, float iPay)
            : base(iId, iSurn, iPay)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter mark {0}: ", i + 1);
                string temp = Console.ReadLine();
                marks[i] = Int32.Parse(temp);
            }
        }

        public override string GetData()
        {
            return "Student:\n\tMarks: [" + GetMarks() + "], " + base.GetData();
        }

        public override float GetSalary()
        {
            float avg = 0;
            for (int i = 0; i < marks.Length; i++)
                avg += marks[i];
            avg = avg / marks.Length;

            if (avg >= 50)
                return Pay;
            else
                return 0;
        }
    }
}
