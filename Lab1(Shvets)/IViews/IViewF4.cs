using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Shvets_
{
    public interface IViewF4
    {
        List<int> TeorAnswer { get;  set; }
        List<int> PractAnswer { get;  set; }

        void radioButtonsAnswer(List<int> tlist, List<int> plist, int k);
        int results { get; set; }
        void ShowF(int k);
    }
}
