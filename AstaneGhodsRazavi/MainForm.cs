using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstaneGhodsRazavi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void اضافهکردنخانوارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Household add_Household = new Add_Household();
            add_Household.Show();
        }

        private void اضافهکردنپزشکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Doctor add_Doctor = new Add_Doctor();
            add_Doctor.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void انبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_To_Depository add_To_Depository = new Add_To_Depository();
            add_To_Depository.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
