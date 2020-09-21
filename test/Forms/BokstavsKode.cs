using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.Forms
{
    public partial class BogstavsKode : Form
    {
        string textInput;
        char startBogstav;


        public BogstavsKode()
        {
            InitializeComponent();
        }

        private void BogstavsKode_Load(object sender, EventArgs e)
        {

        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartBogstavTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkTilKode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkFraKode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TranslateBtn_Click(object sender, EventArgs e)
        {
            textInput = InputTextBox.Text;
            try
            {
                startBogstav = char.Parse(StartBogstavTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Du skal skrive et bogstav i forskydningsfeltet", "Fejl", MessageBoxButtons.OK);
            }
            startBogstav = char.Parse(startBogstav.ToString().ToLower());

            if (checkTilKode.Checked == true && checkFraKode.Checked == false)
            {
                OutputTextBox.Text = TilBogstav(textInput, startBogstav);
            }
            if (checkFraKode.Checked == true && checkTilKode.Checked == false)
            {
                OutputTextBox.Text = FraBogstav(textInput, startBogstav);
            }
            if (checkFraKode.Checked == true && checkTilKode.Checked == true)
            {
                OutputTextBox.Text = "Du må kun krydse af i én checkbox";
            }
            if (checkFraKode.Checked == false && checkTilKode.Checked == false)
            {
                OutputTextBox.Text = "Du skal krydse af i én af checkboxene";
            }
        }

        static string TilBogstav(string input, char startBogstav)
        {
            string output = "";

            List<char> alfabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };

            int forskydning = alfabet.IndexOf(startBogstav);

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                {
                    output += ch;
                }
                else
                {
                    try
                    {
                        output += alfabet[(alfabet.IndexOf(ch) + forskydning)];
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        output += alfabet[((alfabet.IndexOf(ch) + forskydning) - alfabet.Count)];
                    }

                }
            }
            return output;
        }

        static string FraBogstav(string input, char startBogstav)
        {
            string output = "";
            List<char> alfabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'æ', 'ø', 'å' };

            int forskydning = alfabet.IndexOf(startBogstav);

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                {
                    output += ch;
                }
                else
                {
                    try
                    {
                        output += alfabet[(alfabet.IndexOf(ch) - forskydning)];
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        output += alfabet[((alfabet.IndexOf(ch) - forskydning) + alfabet.Count)];
                    }

                }
            }
            return output;
        }
        
    }
}
