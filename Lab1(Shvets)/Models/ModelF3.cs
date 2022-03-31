using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class ModelF3
    {
        private int radioButtonPractic;
        private List<int> practicList = new List<int>();

        public int RadioButtonPractic { set { radioButtonPractic = value; } }
        public List<int> PracticList { get { return practicList; } set { practicList = value; } }

        public List<int> AddInfoPractic()
        {
            practicList = new List<int>();
            practicList.Add(radioButtonPractic);
            return practicList;
        }
    }
}
