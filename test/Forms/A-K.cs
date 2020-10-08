using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace test.Forms
{
    public partial class A_K : Form
    {
        public A_K()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputText_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InputKode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (InputText.Checked == true && InputKode.Checked == false)
            {
                textOutput.Text = TilBogstav(textInput.Text, 'k');
            }
            if (InputText.Checked == false && InputKode.Checked == true)
            {
                textOutput.Text = FraBogstav(textInput.Text, 'k');
            }
            if (InputText.Checked == true && InputKode.Checked == true)
            {
                MessageBox.Show("Du må kun vælge ét input");
            }
            if (InputText.Checked == false && InputKode.Checked == false)
            {
                MessageBox.Show("Du skal vælge ét input");
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