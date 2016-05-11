using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAccountingWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void añadirTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionViewer tv = new TransactionViewer();
            tv.ShowDialog();
        }

        private void últimasTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsListViewer tv = new TransactionsListViewer();
            tv.ShowDialog();
        }

        private void nocionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpScreen h = new HelpScreen();
            h.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsScreen c = new CreditsScreen();
            c.ShowDialog();
        }
    }
}
