using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStringArreyMethod
{
    public class Group
    {
        public int No { get; set; }
        public int StudentLimit  { get; set; }
        public int StudentCount { get; set; }

        
        Student[] students;
       
        public void AddStudent(Student student)
        {
            if (StudentCount < StudentLimit)
            {
                Student[StudentCount] = student;
                StudentCount++;
            }
            else
            {
                Console.WriteLine("Telebe Limiti Asildi");
            }
        }
    }
}
