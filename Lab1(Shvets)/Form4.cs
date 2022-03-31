using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Shvets_
{
    public partial class Form4 : Form, IViewF4
    {
        #region Реализация интерфейса
        public List<int> TeorAnswer { get; set; }
        public List<int> PractAnswer { get; set; }
        public int results { get;  set; }
        
        
        public void ShowF(int k)
        {
            this.Text = "Ответ №" + (k);
            this.Show();
        }
        #endregion
        public Form4()
        {
            InitializeComponent();
            
        }
        public void radioButtonsAnswer(List<int> tlist, List<int> plist, int k)
        {
            int NumberOfAnswerPract = k;
            int NumberOfAnswersTeor = NumberOfAnswerPract == 0 ? 0 : NumberOfAnswerPract + NumberOfAnswerPract;
            if (TeorAnswer[NumberOfAnswersTeor] == 1)
            { radioT1.Checked = true; }
            else if (TeorAnswer[NumberOfAnswersTeor] == 2) radioT2.Checked = true;

            else if (TeorAnswer[NumberOfAnswersTeor] == 3) radioT3.Checked = true;

            if (TeorAnswer[NumberOfAnswersTeor + 1] == 1)
            {
                radioA4.Checked = true;
            }
            else if (TeorAnswer[NumberOfAnswersTeor + 1] == 2) radioB5.Checked = true;
            else if (TeorAnswer[NumberOfAnswersTeor + 1] == 3) radioC6.Checked = true;

            if (PractAnswer[NumberOfAnswerPract] == 1) radioButton1.Checked = true;
            else
            {
                radioButton2.Checked = true;
            }
        }
        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (results == 3)
            {
                MessageBox.Show("Ваша оценка 5");
            }
            else if (results == 2)
            {
                MessageBox.Show("Ваша оценка 4");
            }
            else if (results == 1)
            {
                MessageBox.Show("Ваша оценка 3");
            }
            else
            {
                MessageBox.Show("Ваша оценка 2");
            }
        }
    }
}
