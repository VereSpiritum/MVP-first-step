using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class PresenterF2
    {
        private ModelF2 model = new ModelF2();
        private IViewF2 viewF2;

        public int flagT = 0;
        
        public event EventHandler OpenThisForm2;
        public event EventHandler SaveRes;
        public PresenterF2(IViewF2 view, ModelF2 m)
        {
            viewF2 = view;
            model = m;
            viewF2.SaveResults += ViewF2_SaveResults;
            viewF2.OpenThisForm += ViewF2_OpenThisForm;
        }

        private void ViewF2_OpenThisForm(object sender, EventArgs e)
        {
            if(OpenThisForm2 != null)
            {
                OpenThisForm2(this, EventArgs.Empty);
            }
        }

        public void ViewF2_SaveResults(object sender, EventArgs e)
        {
            model.RadioButtonsTheory1 = viewF2.RadioButtonsTheory1;
            model.RadioButtonsTheory2 = viewF2.RadioButtonsTheory2;
            model.AddInfo();
            flagT++;
            if (SaveRes != null)
            {
                SaveRes(this, EventArgs.Empty);
            }
            
        }

      
        public List<int> SentResults()
        {
            List<int> Results = new List<int>();
            
            Results = model.TheoryList;
            return Results;
        }
        public void OpenForm2(int i)
        {
            viewF2.ShowF(i);
        }
        
    }
}
