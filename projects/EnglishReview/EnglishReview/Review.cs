//Adrian Navarro y Ruben Blanco
using System;
using System.IO;
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
    public partial class English_Aplication : Form
    {

        int numberQuestions;
        string[] englishWords =  {"To Code","To Print","To Walk","To Write","To Read"};
        string[] spanishWords =  {"Programar", "Imprimir", "Andar", "Escribir", "Leer" };
        string[] typeOfWords =   { "Verb", "Verb", "Verb", "Verb", "Verb" };
        int counter = 0;
        public English_Aplication()
        {
            InitializeComponent();
        }

        public void SetNumberOfQuestions(int numQuest)
        {
            numberQuestions = numQuest;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (counter < englishWords.Length-1)
                counter++;
            else
                counter = 0;

            lbEnglish.Text = englishWords[counter];
            lbSpanish.Text = spanishWords[counter];
        }
//-------------------------------------------------------------------
        //NO TOCAR
        private void label3_Click(object sender, EventArgs e)
        {
           
        }
//-------------------------------------------------------------------
    }
}
