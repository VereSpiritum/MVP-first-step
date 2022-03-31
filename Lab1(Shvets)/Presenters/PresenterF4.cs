using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class PresenterF4
    {
        private ModelF4 modelF4;
        private IViewF4 viewF4;
        
        public PresenterF4(IViewF4 v, ModelF4 m)
        {
            viewF4 = v;
            modelF4 = m;
        }
        public void OpenForm4(int k)
        {
            viewF4.ShowF(k);
       
        }
        public void OpenResults(List<int> tlist, List<int> plist, int numberOfAnswer)
        {
            modelF4.Tlist = tlist;
            modelF4.Plist = plist;
            modelF4.Answers(tlist, plist, numberOfAnswer);
            viewF4.TeorAnswer = modelF4.Tlist;
            viewF4.PractAnswer = modelF4.Plist;
            viewF4.results = modelF4.Result;
            viewF4.radioButtonsAnswer(tlist, plist, numberOfAnswer);
        }
    }
}
