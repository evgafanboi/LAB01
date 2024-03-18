using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1
{
    class Student
    {
        private string Name;
        List<float> ScoreArr;
        public Student(string Name = "")
        {
            this.Name = Name;
            ScoreArr = new List<float>();
        }

        public void SetName(string Name)
        {
            foreach (char i in Name)
            {
                if (!char.IsLetter(i))
                    return;
            }
            this.Name = Name;
        }

        public void AddScore(float Score)
        {
            this.ScoreArr.Add(Score);
        }

        public string ReadName()
        {
            return Name;
        }

        public float ReadScore(int index)
        {
            return ScoreArr[index];
        }
    }
}
