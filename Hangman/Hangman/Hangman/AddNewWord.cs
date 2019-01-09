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

namespace Hangman
{
    public partial class AddNewWord : Form
    {
        List<string> words = new List<string>();
        string fileName = "wordsGuess.txt";
        string isWord = "";
        int index = -1;

        public AddNewWord()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string word = tbWord.Text.Trim();
            isWord = tbWord.Text.Trim();


            if (String.IsNullOrEmpty(word))
            {
                MessageBox.Show("Въведи дума");
            }
            else if (!IsAllLetters(isWord))
            {
                MessageBox.Show("Само букви!");
            }
            else
            {
                if (words.Contains(word))
                {
                    MessageBox.Show("Тази дума вече съществува");
                    tbWord.Clear();
                    return;
                }

                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(word);
                    words.Add(word);
                    lbWords.Items.Add(word);
                }
                MessageBox.Show("Успешно добавихте думата: "  + word + ".");
                tbWord.Clear();
            }
            
        }

        private void AddNewWord_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string dbWord = sr.ReadLine();
                        words.Add(dbWord);
                        lbWords.Items.Add(dbWord);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                index = lbWords.SelectedIndex;
                string word = lbWords.SelectedItem.ToString();
                lbWords.Items.RemoveAt(index);
                words.Remove(word);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Първо изберете коя дума искате да махнете");
            }
            finally
            {
                UpdateFile();
            }
           
        }
        public static bool IsAllLetters(string isWord)
        {
            foreach (char c in isWord)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void UpdateFile()
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        sw.WriteLine(words[i]);
                    }
                }
            }
        }
    }
}
