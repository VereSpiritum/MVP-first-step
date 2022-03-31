using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class PresenterF3
    {
        private ModelF3 modelF3;
        private IViewF3 viewF3;
        public int flagP = 0;
        public int NumberOfBlunk;
        public event EventHandler OpenThisForm3;
        public event EventHandler SaveRes;
        
        public PresenterF3(IViewF3 v, ModelF3 m)
        {
            viewF3 = v;
            modelF3 = m;
            viewF3.SaveResults += ViewF3_SaveResults;
            viewF3.OpenThisForm += ViewF3_OpenThisForm;
        }

        private void ViewF3_OpenThisForm(object sender, EventArgs e)
        {
            if(OpenThisForm3 != null)
            {
                OpenThisForm3(this, EventArgs.Empty);
            }
        }

        public void ViewF3_SaveResults(object sender, EventArgs e)
        {
            flagP++;
            modelF3.RadioButtonPractic = viewF3.RadioButtonsPractic;
            modelF3.AddInfoPractic();
            if(SaveRes != null)
            {
                SaveRes(this, EventArgs.Empty);
            }
            
            
        }
        
        public List<int> SentResults()
        {
            List<int> Results = new List<int>();
            Results = modelF3.PracticList;
            return Results;
        }

        public void OpenForm3(int j)
        {   
            viewF3.ShowF(j);
        }
    }
}
