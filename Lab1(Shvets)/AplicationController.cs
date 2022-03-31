using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public class AplicationController
    {
        public List<PresenterF2> f2s = new List<PresenterF2>();
        public List<PresenterF3> f3s = new List<PresenterF3>();
        public List<PresenterF4> f4s = new List<PresenterF4>();

        public PresenterF1 F1 { get; set; }
        public PresenterF2 F2 { get; set; }
        public PresenterF3 F3 { get; set; }
        public PresenterF4 F4 { get; set; }

        frmParent form1 = new frmParent();
        ModelF1 f1 = new ModelF1();
        ModelF2 f2 = new ModelF2();
        ModelF3 f3 = new ModelF3();

        List<int> tlist = new List<int>();
        List<int> plist = new List<int>();
        private int i = 0, j = 0, k = 0;
        private int numberOfBlunkT = 0, numberOfBlunkP = 0, BlunkT = 0, BlunkP = 0;

        public AplicationController()
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();

            form2.MdiParent = form1;
            form3.MdiParent = form1;

            F1 = new PresenterF1(form1, f1);
            F2 = new PresenterF2(form2, f2);
            F3 = new PresenterF3(form3, f3);

            F1.OpenPract += F1_OpenPract;
            F1.OpenTeor += OpenTeor;
            F1.OpenFormWithAnswer += F1_OpenFormWithAnswer;

            F2.OpenThisForm2 += F2_OpenForm;
            F2.SaveRes += SaveResF2;

            F3.OpenThisForm3 += F3_OpenThisForm3;
            F3.SaveRes += SaveResF3;

        }


        private void F1_OpenFormWithAnswer(object sender, EventArgs e)
        {     
            ModelF4 modelF4 = new ModelF4();
            Form4 form4 = new Form4();
            form4.MdiParent = form1;
            PresenterF4 f4 = new PresenterF4(form4, modelF4);
            
            f4.OpenResults(tlist, plist, F1.numberOfAnswer-1);
            f4.OpenForm4(F1.numberOfAnswer);
        }

        private void SaveResF2(object sender, EventArgs e)
        {
            for (int i = 0; i < f2s.Count; i++)
            {
                if (f2s[i].flagT > 0) numberOfBlunkT = i;
            }
            
            List<int> temp = new List<int>();
            temp = f2s[numberOfBlunkT].SentResults();
            
            for(int i = 0; i < temp.Count; i++)
            {
                tlist.Add(temp[i]);
            }
            BlunkT++;
            SaveRes();
        }
        private void SaveResF3(object sender, EventArgs e)
        {
            for (int j = 0; j < f3s.Count; j++)
            {
                if (f3s[j].flagP > 0) numberOfBlunkP = j;
            }
            List<int> temp = new List<int>();
            temp = f3s[numberOfBlunkP].SentResults();
            for(int i = 0; i < temp.Count; i++)
            {
                plist.Add(temp[i]);
            }
            BlunkP++;
            SaveRes();
        }
        private void SaveRes()
        {
            if(BlunkT > 0 && BlunkP > 0)
            {         
                F1.ViewF1_CreateComponent(k);
                k++;
                BlunkT--; BlunkP--;
            }     
        }

        private void F3_OpenThisForm3(object sender, EventArgs e)
        {
            OpenForms3();
        }

        private void F2_OpenForm(object sender, EventArgs e)
        {
            OpenForms2();
        }

        public void Run()
        {
            F1.Run();
        }


        private void OpenForms2()
        {
            ModelF2 modelF2 = new ModelF2();
            Form2 form2 = new Form2();
            form2.MdiParent = form1;
            PresenterF2 f2 = new PresenterF2(form2, modelF2);
            f2.OpenThisForm2 += F2_OpenForm;
            f2.SaveRes += SaveResF2;
            f2s.Add(f2);
            f2s[i].OpenForm2(i);
            i++;
        }
        private void OpenForms3()
        {
            ModelF3 modelF3 = new ModelF3(); 
            Form3 form3 = new Form3();
            form3.MdiParent = form1;
            PresenterF3 f3 = new PresenterF3(form3, modelF3);
            f3.OpenThisForm3 += F3_OpenThisForm3;
            f3.SaveRes += SaveResF3;
            f3s.Add(f3);
            f3s[j].OpenForm3(j);
            j++;
        }
        private void F1_OpenPract(object sender, EventArgs e)
        {
            OpenForms3();
        }
        private void OpenTeor(object sender, EventArgs e)
        {
            OpenForms2();
        }

    }
}
