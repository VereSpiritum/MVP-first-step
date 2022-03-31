using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class PresenterF1
    {
        private ModelF1 modelF1 = new ModelF1();
        private IViewF1 viewF1;

        public event EventHandler OpenTeor;
        public event EventHandler OpenPract;
        public event EventHandler OpenFormWithAnswer;
        public int numberOfAnswer;
        public PresenterF1(IViewF1 v, ModelF1 m)
        {
            viewF1 = v;
            modelF1 = m;
            viewF1.OpenTeorTest += ViewF1_OpenTeorTest;
            viewF1.OpenPracticTest += ViewF1_OpenPracticTest;
            viewF1.OpenFormWithAnswer += ViewF1_OpenFormWithAnswer;
        }

        private void ViewF1_OpenFormWithAnswer(object sender, EventArgs e)
        {
            numberOfAnswer = viewF1.numberOfFormWithAnswer;
            if(OpenFormWithAnswer != null)
            {
                OpenFormWithAnswer(this, EventArgs.Empty);
            }
        }

        public void Run()
        {
            viewF1.Run();
        }
        private void ViewF1_OpenPracticTest(object sender, EventArgs e)
        {
            if (OpenPract != null)
            { 
                OpenPract(this, EventArgs.Empty); 
            }   
        }
        private void ViewF1_OpenTeorTest(object sender, EventArgs e)
        {
            if(OpenTeor != null)
            {
                OpenTeor(this, EventArgs.Empty);
            }
        }

        public void ViewF1_CreateComponent(int k)
        {
            viewF1.CreateMenuStrip(k);
        }
    }
}
