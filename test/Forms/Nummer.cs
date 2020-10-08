using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test.Forms
{
    public partial class NummerKode : Form
    {
        public NummerKode()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputNumre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InputText_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Translate_Click(object sender, EventArgs e)
        {
            if (InputText.Checked == true && InputNumre.Checked == false)
            {
                textOutput.Text = TilNummer(textInput.Text.ToLower());
            }
            if (InputNumre.Checked == true && InputText.Checked == false)
            {
                textOutput.Text = TilText(textInput.Text.ToLower());
            }
            if (InputText.Checked == true && InputNumre.Checked == true)
            {
                MessageBox.Show("Du må kun vælge ét input");
            }
            if (InputText.Checked == false && InputNumre.Checked == false)
            {
                MessageBox.Show("Du skal vælge ét input");
            }
        }

        public static string TilNummer(string InputText)
        {
            string OutputText = "";

            List<string> Rows = new List<string> { "afkpuz", "bglqvæ", "chmrwø", "dinsxå", "ejoty" };

            for (int i = 0; i < InputText.Length; i++)
            {
                if (Rows[0].Contains(InputText[i]))
                {
                    string text = Rows[0];
                    OutputText += 1;
                    if (text[0] == InputText[i])
                    {
                        OutputText += 1;
                    }
                    if (text[1] == InputText[i])
                    {
                        OutputText += 2;
                    }
                    if (text[2] == InputText[i])
                    {
                        OutputText += 3;
                    }
                    if (text[3] == InputText[i])
                    {
                        OutputText += 4;
                    }
                    if (text[4] == InputText[i])
                    {
                        OutputText += 5;
                    }
                    if (text[5] == InputText[i])
                    {
                        OutputText += 6;
                    }
                    OutputText += "-";
                }
                if (Rows[1].Contains(InputText[i]))
                {
                    string text = Rows[1];
                    OutputText += 2;
                    if (text[0] == InputText[i])
                    {
                        OutputText += 1;
                    }
                    if (text[1] == InputText[i])
                    {
                        OutputText += 2;
                    }
                    if (text[2] == InputText[i])
                    {
                        OutputText += 3;
                    }
                    if (text[3] == InputText[i])
                    {
                        OutputText += 4;
                    }
                    if (text[4] == InputText[i])
                    {
                        OutputText += 5;
                    }
                    if (text[5] == InputText[i])
                    {
                        OutputText += 6;
                    }
                    OutputText += "-";
                }
                if (Rows[2].Contains(InputText[i]))
                {
                    string text = Rows[2];
                    OutputText += 3;
                    if (text[0] == InputText[i])
                    {
                        OutputText += 1;
                    }
                    if (text[1] == InputText[i])
                    {
                        OutputText += 2;
                    }
                    if (text[2] == InputText[i])
                    {
                        OutputText += 3;
                    }
                    if (text[3] == InputText[i])
                    {
                        OutputText += 4;
                    }
                    if (text[4] == InputText[i])
                    {
                        OutputText += 5;
                    }
                    if (text[5] == InputText[i])
                    {
                        OutputText += 6;
                    }
                    OutputText += "-";
                }
                if (Rows[3].Contains(InputText[i]))
                {
                    string text = Rows[3];
                    OutputText += 4;
                    if (text[0] == InputText[i])
                    {
                        OutputText += 1;
                    }
                    if (text[1] == InputText[i])
                    {
                        OutputText += 2;
                    }
                    if (text[2] == InputText[i])
                    {
                        OutputText += 3;
                    }
                    if (text[3] == InputText[i])
                    {
                        OutputText += 4;
                    }
                    if (text[4] == InputText[i])
                    {
                        OutputText += 5;
                    }
                    if (text[5] == InputText[i])
                    {
                        OutputText += 6;
                    }
                    OutputText += "-";
                }
                if (Rows[4].Contains(InputText[i]))
                {
                    string text = Rows[4];
                    OutputText += 5;
                    if (text[0] == InputText[i])
                    {
                        OutputText += 1;
                    }
                    if (text[1] == InputText[i])
                    {
                        OutputText += 2;
                    }
                    if (text[2] == InputText[i])
                    {
                        OutputText += 3;
                    }
                    if (text[3] == InputText[i])
                    {
                        OutputText += 4;
                    }
                    if (text[4] == InputText[i])
                    {
                        OutputText += 5;
                    }
                    OutputText += "-";
                }
                if (InputText[i] == ' ' || i == InputText.Length - 1)
                {
                    OutputText = OutputText.Remove(OutputText.Length - 1);
                    OutputText += " ";
                }
            }
            return OutputText;
        }

        public static string TilText(string inputText)
        {
            string outputText = "";

            List<string> Rows = new List<string> { "afkpuz", "bglqvæ", "chmrwø", "dinsxå", "ejoty" };

            int i = 0;

            while (i < inputText.Length)
            {
                if (inputText[i] == '1')
                {
                    i++;
                    if (inputText[i] == '1')
                    {
                        i++;
                        outputText += 'a';
                    }
                    if (inputText[i] == '2')
                    {
                        i++;
                        outputText += 'f';
                    }
                    if (inputText[i] == '3')
                    {
                        i++;
                        outputText += 'k';
                    }
                    if (inputText[i] == '4')
                    {
                        i++;
                        outputText += 'p';
                    }
                    if (inputText[i] == '5')
                    {
                        i++;
                        outputText += 'u';
                    }
                    if (inputText[i] == '6')
                    {
                        i++;
                        outputText += 'z';
                    }
                }
                if (inputText[i] == '2')
                {
                    i++;
                    if (inputText[i] == '1')
                    {
                        i++;
                        outputText += 'b';
                    }
                    if (inputText[i] == '2')
                    {
                        i++;
                        outputText += 'g';
                    }
                    if (inputText[i] == '3')
                    {
                        i++;
                        outputText += 'l';
                    }
                    if (inputText[i] == '4')
                    {
                        i++;
                        outputText += 'q';
                    }
                    if (inputText[i] == '5')
                    {
                        i++;
                        outputText += 'v';
                    }
                    if (inputText[i] == '6')
                    {
                        i++;
                        outputText += 'æ';
                    }
                }
                if (inputText[i] == '3')
                {
                    i++;
                    if (inputText[i] == '1')
                    {
                        i++;
                        outputText += 'c';
                    }
                    if (inputText[i] == '2')
                    {
                        i++;
                        outputText += 'h';
                    }
                    if (inputText[i] == '3')
                    {
                        i++;
                        outputText += 'm';
                    }
                    if (inputText[i] == '4')
                    {
                        i++;
                        outputText += 'r';
                    }
                    if (inputText[i] == '5')
                    {
                        i++;
                        outputText += 'w';
                    }
                    if (inputText[i] == '6')
                    {
                        i++;
                        outputText += 'ø';
                    }
                }
                if (inputText[i] == '4')
                {
                    i++;
                    if (inputText[i] == '1')
                    {
                        i++;
                        outputText += 'd';
                    }
                    if (inputText[i] == '2')
                    {
                        i++;
                        outputText += 'i';
                    }
                    if (inputText[i] == '3')
                    {
                        i++;
                        outputText += 'n';
                    }
                    if (inputText[i] == '4')
                    {
                        i++;
                        outputText += 's';
                    }
                    if (inputText[i] == '5')
                    {
                        i++;
                        outputText += 'x';
                    }
                    if (inputText[i] == '6')
                    {
                        i++;
                        outputText += 'å';
                    }
                }
                if (inputText[i] == '5')
                {
                    i++;
                    if (inputText[i] == '1')
                    {
                        i++;
                        outputText += 'e';
                    }
                    if (inputText[i] == '2')
                    {
                        i++;
                        outputText += 'j';
                    }
                    if (inputText[i] == '3')
                    {
                        i++;
                        outputText += 'o';
                    }
                    if (inputText[i] == '4')
                    {
                        i++;
                        outputText += 't';
                    }
                    if (inputText[i] == '5')
                    {
                        i++;
                        outputText += 'y';
                    }
                }
                if (inputText[i] == ' ')
                {
                    outputText += ' ';
                    i++;
                }
                try
                {
                    if (inputText[i] == '-')
                    {
                        i++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
            return outputText;
        }
    }
}
