using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Shvets_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*frmParent form1 = new frmParent();
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            
            ModelF1 modelF1 = new ModelF1();
            ModelF2 modelF2 = new ModelF2();
            ModelF3 modelF3 = new ModelF3();
           
            PresenterF1 f1 = new PresenterF1(form1, modelF1);
            PresenterF2 f2 = new PresenterF2(form2, modelF2);
            PresenterF3 f3 = new PresenterF3(form3, modelF3);*/
           
            //AplicationController ac = new AplicationController(f1, f2, f3);
            AplicationController ac = new AplicationController();
            ac.Run();
        }
    }
}
