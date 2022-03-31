using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Shvets_
{
    public class ModelF1
    {
        /*//нумерация бланков с заданиями и бланков с ответами
        //будет меняться в зависимости от колличества открытых форм с формы1 или других
        private int i = 1, j = 1, k = 1;

        public int I { get { return i; } set { i = value; } }
        public int J { get { return j; } set { j = value; } }
        public int K { get { return k; } set { k = value; } }
        
        private int checkTeorAnswer, checkPracticAnswer; //проверка на наличие данных в списках
        private bool checkLists;
        public bool CheckLists { get { return checkLists; } set { checkLists = value; } }

        //списки, которые мы будем читать, проверять и отправлять
        private List<int> plist = new List<int>();
        private List<int> tlist = new List<int>();
        public List<int> Plist { get { return plist; } set { plist = value; checkPracticAnswer++;  } }
        public List<int> Tlist { get { return tlist; } set { tlist = value; checkTeorAnswer++; } }


      

       /* private List<int> CheckedAnswer()
        {
            if (checkPracticAnswer > 0 && checkTeorAnswer > 0)
            {               
                
                checkPracticAnswer--;
                checkTeorAnswer--;
            }
        }*/
    }
}
