using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public interface IViewF2
    {
        int RadioButtonsTheory1 { get; }
        int RadioButtonsTheory2 { get; }
     
        event EventHandler SaveResults;
        event EventHandler OpenThisForm;
        void ShowF(int i);
    }
}
