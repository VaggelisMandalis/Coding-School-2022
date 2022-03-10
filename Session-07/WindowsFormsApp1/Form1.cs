using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //this.textEdit1.EditValue
        }

        private void calcEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.calcEdit1.EditValue = 2.0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.spinEdit1.Properties.MaxValue = 1000;
            this.spinEdit1.Properties.MinValue = 0;
            this.spinEdit1.Properties.Increment = 2;
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            if( ofd.ShowDialog() == DialogResult.OK)
                this.buttonEdit1.EditValue=ofd.FileName;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
