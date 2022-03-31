using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    //получает информацию, заносит ее в список, возвращает список
    public class ModelF2
    {
        private int radioButtonsTheory1 = 0;
        private int radioButtonsTheory2 = 0;
       
        private List<int> theoryList = new List<int>();

        
        public int RadioButtonsTheory1 { set { radioButtonsTheory1 = value; } }
        public int RadioButtonsTheory2 { set { radioButtonsTheory2 = value; } }
        public List<int> TheoryList { get { return theoryList; } set { theoryList = value; } }

        public void AddInfo()
        {
            theoryList = new List<int>();
            theoryList.Add(radioButtonsTheory1);
            theoryList.Add(radioButtonsTheory2);
            
        }
    }
}
