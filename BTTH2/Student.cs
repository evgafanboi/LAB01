using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    [Serializable]
    internal class Student
    {
        private string Name;
        private string ID;
        private string PhoneNum;
        private List<float> ScoreArr;
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

        public int NumberOfScore()
        {
            return this.ScoreArr.Count();
        }

        public float MaxScore()
        {
            return ScoreArr.Max();
        }

        public float MinScore()
        {
            return ScoreArr.Min();
        }

        public void SetPhoneNum(string _PhoneNum)
        {
            this.PhoneNum = _PhoneNum;
        }

        public void SetID(string _ID)
        {
            this.ID = _ID;
        }

        public string ReadID()
        {
            return ID;
        }

        public string ReadPhoneNum()
        {
            return PhoneNum;
        }

        public float AvgScore()
        {
            float SumScore = 0;
            foreach (float i in ScoreArr)
                SumScore = SumScore + i;
            return ((float)SumScore / ScoreArr.Count());
        }

        //public int NumPassingScores()
        //{
        //    int Num = 0;
        //    foreach (float i in ScoreArr)
        //        if (i >= 5)
        //            Num++;
        //    return Num;
        //}

        //public int NumFailedScores()
        //{
        //    return (ScoreArr.Count() - this.NumPassingScores());
        //}

        //public int GradeStudent()
        //{
        //    float Avg = this.AvgScore();
        //    bool MeetCondition = true;
        //    if (Avg >= 8)
        //    {
        //        foreach (float i in ScoreArr)
        //            if (i < 6.5)
        //                MeetCondition = false;
        //        if (MeetCondition)
        //            return 4;
        //    }
        //    MeetCondition = true;
        //    if (Avg >= 6.5)
        //    {
        //        foreach (float i in ScoreArr)
        //            if (i < 5)
        //                MeetCondition = false;
        //        if (MeetCondition)
        //            return 3;
        //    }
        //    MeetCondition = true;
        //    if (Avg >= 5)
        //    {
        //        foreach (float i in ScoreArr)
        //            if (i < 3.5)
        //                MeetCondition = false;
        //        if (MeetCondition)
        //            return 2;
        //    }
        //    MeetCondition = true;
        //    if (Avg >= 3.5)
        //    {
        //        foreach (float i in ScoreArr)
        //            if (i < 2)
        //                MeetCondition = false;
        //        if (MeetCondition)
        //            return 1;
        //    }
        //    // Kem
        //    return 0;
        //}
    }
}
