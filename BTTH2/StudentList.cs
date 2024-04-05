using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    [Serializable]
    class StudentList
    {
        //contains a list of students
        private List<Student> List;

        public StudentList()
        {
            List = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            List.Add(student);
        }

        //method to remove a student from the list with index
        public void RemoveStudent(int index)
        {
            List.RemoveAt(index);
        }

        // method to read a student from the list with index
        public Student ReadStudent(int index)
        {
            return List[index];
        }

        //method to return the numbers of student
        public int NumberOfStudent()
        {
            return List.Count();
        }
                  

    }

    
}
