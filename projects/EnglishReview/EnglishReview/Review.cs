/// <summary>
///  English Review
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.02  16-Apr-2016  Nacho: Read data from Welcome Screen and use it
   0.01  15-Apr-2016  Adrian Navarro y Ruben Blanco
                      First Approach: skeleton for the review window
 ---------------------------------------------------- */

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
        List<string> englishWords = new List<string> () { "To Code","To Print","To Walk","To Write","To Read"};
        List<string> spanishWords = new List<string>() { "Programar", "Imprimir", "Andar", "Escribir", "Leer" };
        List<string> typeOfWords = new List<string>() { "Verb", "Verb", "Verb", "Verb", "Verb" };
        int counter = 0;

        public English_Aplication()
        {
            InitializeComponent();
        }

        public void SetListOfWords(List<string> english, 
            List<string> spanish)
        {
            englishWords = english;
            spanishWords = spanish;
            counter = -1;
            DisplayNextWord(); 
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
            DisplayNextWord();
        }

        private void DisplayNextWord()
        {
            if (counter < englishWords.Count - 1)
                counter++;
            else
                counter = 0;

            lbEnglish.Text = englishWords[counter];
            lbSpanish.Text = "";
            lbProgress.Text = "" + (counter + 1) + " of " +
                englishWords.Count;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            lbSpanish.Text = spanishWords[counter];
        }
    }
}
