//Adrian Navarro y Ruben Blanco
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAplication
{
    public partial class Form1 : Form
    {
        English_Aplication secondWindow;
        public Form1()
        {
            InitializeComponent();
            secondWindow = new English_Aplication();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondWindow.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
