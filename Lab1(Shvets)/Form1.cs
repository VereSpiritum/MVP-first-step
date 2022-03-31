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
    public partial class frmParent : Form, IViewF1
    {
        #region Реализация интерфейса

        public event EventHandler OpenTeorTest;
        public event EventHandler OpenPracticTest;
        public event EventHandler OpenFormWithAnswer;

        public int numberOfFormWithAnswer { get; set; }
        public void CreateMenuStrip(int k)
        {
            ToolStripMenuItem results = new ToolStripMenuItem();
            results.Text = "Ответ №" + Convert.ToString(++k);
            results.Click += Results_Click;
            ответыToolStripMenuItem.DropDownItems.Add(results);        
        }
        public void Run()
        {
            Application.Run(this);
        }
        #endregion
      
        public frmParent()
        {
            InitializeComponent();
        }
        
        private void Results_Click(object sender, EventArgs e)
        {
            string name = sender.ToString();
            char[] nameAnswer = new char[name.Length];
            nameAnswer = name.ToCharArray();
            numberOfFormWithAnswer = nameAnswer[nameAnswer.Length - 1] - '0';
            if (OpenFormWithAnswer != null)
            {
                OpenFormWithAnswer(this, EventArgs.Empty);
            }

        }
        private void теоретическиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(OpenTeorTest != null)
           {
               OpenTeorTest(this, EventArgs.Empty);
           }
        }

        private void практическиеВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenPracticTest != null)
            {
                OpenPracticTest(this, EventArgs.Empty);
            }
        }
    }
}
