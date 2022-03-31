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
    public partial class Form2 : Form, IViewF2
    {
        int radioButtonsTheory1;
        int radioButtonsTheory2;
        public Form2()
        {
            InitializeComponent();
        }
     
        #region  Реализация интерфейса
       
        public int RadioButtonsTheory1 
        {
            get { return radioButtonsTheory1; }
        }
        public int RadioButtonsTheory2
        {
            get { return radioButtonsTheory2; }
        }
     
        new public void ShowF(int i)
        {
            
            this.Text = "Теоретический вопрос №" + (i+1);
        
            this.Show();
        }

        public event EventHandler SaveResults;
        public event EventHandler OpenThisForm;

        #endregion
        
        //кнопка сохранения результатов
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(OpenThisForm != null)
            {
                OpenThisForm(this, EventArgs.Empty);
            }
        }

        //кнопка открытия той же формы
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(radioButtonsTheory1 > 0 && radioButtonsTheory2 > 0)
            {
                if (SaveResults != null)
                {
                    SaveResults(this, EventArgs.Empty);
                }
                MessageBox.Show("Результаты сохранены");
                
            }
        }
        
        private void radioT1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonsTheory1 = radioT1.Checked ? 1 : radioT2.Checked ? 2 : radioT3.Checked ? 3 : 0;
          
        }
        private void radioT2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonsTheory2 = radioA4.Checked ? 1 : radioB5.Checked ? 2 : radioC6.Checked ? 3 : 0;
            
        }
      

    }
}
 