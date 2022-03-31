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
    public partial class Form3 : Form, IViewF3
    {
        private int radioButtonAnswer;
      
        public Form3()
        {
            InitializeComponent();          
        }

        #region  Реализация интерфейса
       
        public int RadioButtonsPractic
        {
            get { return radioButtonAnswer; }
        }
        
        new public void ShowF(int j)
        {
            this.Text = "Практический вопрос №" + (j + 1);
           
            this.Show();
        }
        public event EventHandler SaveResults;
        public event EventHandler OpenThisForm;
        #endregion

        private void radioButtonCheckedChanged(object sender, EventArgs e)
        {
            radioButtonAnswer = radioButton1.Checked ? 1 : radioButton2.Checked ? 2 : 0;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OpenThisForm != null)
            {
                OpenThisForm(this, EventArgs.Empty);
            }
                
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (radioButtonAnswer > 0)
            {
                if (SaveResults != null)
                {
                    SaveResults(this, EventArgs.Empty);
                }
                MessageBox.Show("Результаты сохранены");
               
            }
            
        }
    }
}
