using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public interface IViewF1
    {
        event EventHandler OpenTeorTest;
        event EventHandler OpenPracticTest;
        event EventHandler OpenFormWithAnswer;
        int numberOfFormWithAnswer { get; set; }
        void CreateMenuStrip(int k);
        void Run();
    }
}
