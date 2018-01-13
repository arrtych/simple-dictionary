using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        //array of dictionaries paths
        string[] dictionaries = {

            "dictionaries/French.txt",
            "dictionaries/German.txt",
            "dictionaries/Italian.txt",
            "dictionaries/Latin.txt",
            "dictionaries/Portuguese.txt",
            "dictionaries/Spanish.txt",
        };
        public Form1()
        {
            InitializeComponent();
           
        }

        //while form on load create new values of dictionaries and put it to combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dictionaries.Length; i++)
            {
                dictionarySource.Items.Add(dictionaries[i]);
            }
        }

        //Translate word while clicking the go button
        private void goBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string currentresult = "";
                string wordToSearh = translateWord.Text;
                string[] lines = System.IO.File.ReadAllLines(dictionarySource.SelectedItem.ToString());
                foreach (string line in lines)
                {
                    //if word not found
                    if (!line.StartsWith(wordToSearh)){
                        currentresult = "Not found";
                        translateResult.Text = currentresult;                        
                    }
                    //if founded print line to texbox
                    else
                    {
                        currentresult = line;                        
                        translateResult.Text = currentresult;
                        //end cycle
                        break;
                    }

                }


            }
            //if file not found
            catch (System.IO.FileNotFoundException)
            {
                translateResult.Text = "Cannot open directory";
            }
            catch (System.NullReferenceException)
            {
                translateResult.Text = "Cannot open directory";
            }
        }


    }
}
