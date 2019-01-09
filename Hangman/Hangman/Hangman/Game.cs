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
    public partial class Game : Form
    {   
        public int score {get; set;}
        string w = "";
        List<Label> labels = new List<Label>();
        List<char> guessedLetter = new List<char>();
        int missed = -1;
        string fileName = "wordsGuess.txt";
        int attemptsLeft = 7;
        bool sameSymbol = false;

        enum bparts
        {
            Besilo, Glava, Teniska, Pantaloni, Race, Kraka, Obesen
        }

        void DrawBodyParts(bparts bp)
        {
            if (bp == bparts.Besilo)
                pbHangMan.Image = Image.FromFile("man1.png");

            else if (bp == bparts.Glava)
                pbHangMan.Image = Image.FromFile("man2.png");


            else if (bp == bparts.Teniska)
                pbHangMan.Image = Image.FromFile("man3.png");


            else if (bp == bparts.Pantaloni)
                pbHangMan.Image = Image.FromFile("man4.png");


            else if (bp == bparts.Race)
                pbHangMan.Image = Image.FromFile("man5.png");

            else if (bp == bparts.Kraka)
                pbHangMan.Image = Image.FromFile("man6.png");

            else if (bp == bparts.Obesen)
                pbHangMan.Image = Image.FromFile("man7.png");
        }

        public void makelabels()
        {
            w = getRandomWords().ToLower();
            w.Replace(" ", "");
            char[] ch = w.ToCharArray();
            int space = 550 / ch.Length - 1;
           
            for (int i = 0; i < ch.Length - 1; i++)
            {
                labels.Add(new Label());
                labels[i].Location = new Point((i * space) + 10, 109);
                labels[i].Parent = gbInformation;
                labels[i].Text = "__";
                labels[i].BringToFront();
                labels[i].CreateControl();
            }
            lblLength.Text = "Length: " + (ch.Length - 1).ToString();
        }

        string getRandomWords()
        {           
            string list = "";
            list = System.IO.File.ReadAllText(fileName);
            string[] words = list.Split('\n');
            Random rand = new Random();
            return words[rand.Next(0, words.Length - 1)];
        }

        public void newgame()
        {
            pbAnswer.Image = null;
            getRandomWords();
            makelabels();
            lblMissed.Text = "m i s s e d: ";
            tbInsertChar.Text = "";
            missed = -1;
            pbHangMan.Image = Image.FromFile("man1.png");
            attemptsLeft = 7;
            lblAttemptsLeft.Text = "Attempts left: " + attemptsLeft.ToString();
            guessedLetter.Clear();
            sameSymbol = false;
        }

        public Game()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            try
            {
                char letter = tbInsertChar.Text.ToLower().ToCharArray()[0];
                
                
                if (!char.IsLetter(letter))
                {
                    MessageBox.Show("Само буква!");
                }

                tbInsertChar.Text = "";

                if (w.Contains(letter))
                {
                    char[] LS = w.ToLower().ToCharArray();
                    for (int i = 0; i < LS.Length; i++)
                    {
                        if (LS[i] == letter)
                        {
                            labels[i].Text = letter.ToString();
                            pbAnswer.Image = Image.FromFile("okay.png");
                        }
                    }

                    foreach (Label l in labels)
                        if (l.Text == "__")
                        {
                            return;
                        }                          
                    MessageBox.Show("Познахте думата и спасихте човека.");
                    newgame();
                    score++;
                    lblScore.Text = "Score: " + score.ToString();
                }
                else
                {
                    for (int i = 0; i < guessedLetter.Count; i++)
                    {
                        if (guessedLetter[i] == letter)
                        {
                            MessageBox.Show("Вече имате такова предположение.");
                            sameSymbol = true;
                        }           
                    }

                    if (sameSymbol==false)
                    {
                        guessedLetter.Add(letter);
                        pbAnswer.Image = Image.FromFile("wrong.png");
                        lblMissed.Text += " " + letter.ToString() + " |";
                        attemptsLeft--;
                        lblAttemptsLeft.Text = "Attempts left: " + attemptsLeft.ToString();
                        missed++;
                        DrawBodyParts((bparts)missed);
                    }

                   
                    if (missed == 6)
                    {
                        MessageBox.Show("Нямате късмет и не познахте думата :).\n\n Думата е: " + w);
                        newgame();
                    }
                    sameSymbol = false;
                }
                
        }

        catch(Exception)
            {
        MessageBox.Show("Въведете буква.");
            } 
       }

        private void tbInsertChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (!Char.IsLetter(key))
            {
                e.Handled = true;
            }
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            getRandomWords();
            makelabels();

        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            getRandomWords();
            makelabels();
            guessedLetter.Clear();
        }

    }
}

