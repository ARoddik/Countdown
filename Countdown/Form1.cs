using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        private LetterContainer _letters;
        private WordChecker _wordChecker;
        private Dictionary _dictionary;
        private List<TextBox> _textBoxes = new List<TextBox>();

        public Form1(LetterContainer letters, WordChecker wordChecker, Dictionary dictionary)
        {
            InitializeComponent();
            _letters = letters;
            _wordChecker = wordChecker;
            _dictionary = dictionary;
        }

        private void vowelButton_Click(object sender, EventArgs e)
        {
            if (ChooseTextBox() != null)
            {
                char vowel = Vowel.GetRandomVowel();
                ChooseTextBox().Text = vowel.ToString();
                _letters.AddLetter(vowel);
                CheckLetterAmount();
            }
            else ;
        }


        private void consonantButton_Click(object sender, EventArgs e)
        {
            if (ChooseTextBox() != null)
            {
                char consonant = Consonant.GetRandomConsonant();
                ChooseTextBox().Text = consonant.ToString();
                _letters.AddLetter(consonant);
                CheckLetterAmount();
            }
            else ;
        }

        private void wordCheckButton_Click(object sender, EventArgs e)
        {
            // testWordBox.Text = _wordChecker.GetWords(_letters.GetLetterList(), _dictionary.GetDictionary())[0];
            player1Points.Text =
                Convert.ToString(_wordChecker.CheckWord(player1Word.Text, _dictionary.GetDictionary()));
            player2Points.Text =
                Convert.ToString(_wordChecker.CheckWord(player2Word.Text, _dictionary.GetDictionary()));
            wordCheckButton.Enabled = false;
            if (Convert.ToInt32(player1Points.Text) > Convert.ToInt32(player2Points.Text))
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else if (Convert.ToInt32(player1Points.Text) < Convert.ToInt32(player2Points.Text))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else if (Convert.ToInt32(player1Points.Text) == Convert.ToInt32(player2Points.Text))
            {
                MessageBox.Show("It's a draw!");
            }
            newGameButton.Enabled = true;

        }

        private void CheckLetterAmount()
        {
            wordCheckButton.Enabled = _letters.GetLetterList().Count == 10;
        }

        private List<TextBox> GetTextBoxes()
        {
            _textBoxes.Add(letter1Box);
            _textBoxes.Add(letter2Box);
            _textBoxes.Add(letter3Box);
            _textBoxes.Add(letter4Box);
            _textBoxes.Add(letter5Box);
            _textBoxes.Add(letter6Box);
            _textBoxes.Add(letter7Box);
            _textBoxes.Add(letter8Box);
            _textBoxes.Add(letter9Box);
            _textBoxes.Add(letter10Box);

            return _textBoxes;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            foreach (var box in GetTextBoxes())
            {
                box.ResetText();
            }
            player1Word.ResetText();
            player1Points.ResetText();
            player2Word.ResetText();
            player2Points.ResetText();
            wordCheckButton.Enabled = true;
        }

        private TextBox ChooseTextBox()
        {
            TextBox emptyBox;

            if (string.IsNullOrWhiteSpace(letter1Box.Text))
            {
                emptyBox = letter1Box;
            }
            else if (string.IsNullOrWhiteSpace(letter2Box.Text))
            {
                emptyBox = letter2Box;
            }
            else if (string.IsNullOrWhiteSpace(letter3Box.Text))
            {
                emptyBox = letter3Box;
            }
            else if (string.IsNullOrWhiteSpace(letter4Box.Text))
            {
                emptyBox = letter4Box;
            }
            else if (string.IsNullOrWhiteSpace(letter5Box.Text))
            {
                emptyBox = letter5Box;
            }
            else if (string.IsNullOrWhiteSpace(letter6Box.Text))
            {
                emptyBox = letter6Box;
            }
            else if (string.IsNullOrWhiteSpace(letter7Box.Text))
            {
                emptyBox = letter7Box;
            }
            else if (string.IsNullOrWhiteSpace(letter8Box.Text))
            {
                emptyBox = letter8Box;
            }
            else if (string.IsNullOrWhiteSpace(letter9Box.Text))
            {
                emptyBox = letter9Box;
            }
            else if (string.IsNullOrWhiteSpace(letter10Box.Text))
            {
                emptyBox = letter10Box;
            }
            else
            {
                emptyBox = null;
            }

            return emptyBox;
        }

    }
}
