using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListForm form = new CustomerListForm();
            form.ShowDialog();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemListForm form = new ItemListForm();
            form.ShowDialog();
        }
    }
}
