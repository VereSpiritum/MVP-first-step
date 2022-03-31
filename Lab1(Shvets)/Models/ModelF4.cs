using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class ModelF4
    {
        private List<int> tlist = new List<int>();
        private List<int> plist = new List<int>();
        private int result = 0;

        public List<int> Tlist
        {
            get { return tlist; }
            set { tlist = value; }
        }
        public List<int> Plist
        {
            get { return plist; }
            set { plist = value; }
        }
        public int Result
        {
            get { return result; }
            set { result = value; }
        }
        //k - number of answer
        public void Answers(List<int> tlist, List<int> plist, int k)
        {
            int NumberOfAnswerPract = k;
            int NumberOfAnswersTeor = NumberOfAnswerPract == 0 ? 0 : NumberOfAnswerPract + NumberOfAnswerPract;

            if (tlist[NumberOfAnswersTeor] == 1) result++;
            if (tlist[NumberOfAnswersTeor + 1] == 1) result++;

            if (plist[NumberOfAnswerPract] == 2) result++;
        }
    }
}
