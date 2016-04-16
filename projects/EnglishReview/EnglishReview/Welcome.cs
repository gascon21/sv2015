/// <summary>
///  English Review
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.02  16-Apr-2016  Nacho: Read data from file and send it to Review
   0.01  15-Apr-2016  Adrian Navarro y Ruben Blanco
                      First Approach: skeleton for the welcome window
 ---------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EnglishAplication
{
    public partial class Form1 : Form
    {
        English_Aplication secondWindow;
        List<string> englishWords;
        List<string> spanishWords;
        List<string> categories;
        List<string> usedCategories;

        public Form1()
        {
            InitializeComponent();
            secondWindow = new English_Aplication();
            englishWords = new List<string>();
            spanishWords = new List<string>();
            categories = new List<string>();
            usedCategories = new List<string>();
            LoadDataFile();
        }

        private void LoadDataFile()
        {
            string name = "review.txt";
            if (File.Exists(name))
            {
                try
                {
                    StreamReader f = new StreamReader(name);
                    string line = f.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains(";"))
                        { 
                            string[] parts = line.Split(';');
                            englishWords.Add(parts[0]);
                            spanishWords.Add(parts[1]);
                            categories.Add(parts[2]);
                            if (!usedCategories.Contains(parts[2]))
                                usedCategories.Add(parts[2]);
                        }
                        line = f.ReadLine();
                    }
                    f.Close();
                    if (usedCategories.Count > 0)
                    {
                        comboBox1.Items.Clear();
                        usedCategories.Sort();
                        foreach (string c in usedCategories)
                            comboBox1.Items.Add(c);
                    }
                }
                catch (Exception)
                {
                    // Do nothing... so far
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> englishToShow = new List<string>();
            List<string> spanishToShow = new List<string>();
            for (int i = 0; i < englishWords.Count; i++)
            {
                if (categories[i] == comboBox1.Text)
                {
                    englishToShow.Add(englishWords[i]);
                    spanishToShow.Add(spanishWords[i]);
                }
            }
            secondWindow.SetListOfWords(englishToShow, spanishToShow);
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
