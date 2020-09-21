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
    public partial class FormMorse : Form
    {
        string FejlText = "Fejl. Tjek dinne input";

        public FormMorse()
        {
            InitializeComponent();
        }

        private void FormMorse_Load(object sender, EventArgs e)
        {

        }

        // Checks for morse
        private void InputMorse_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Checks for text
        private void InputText_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Input textfield
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Translate btn
        private void Translate_Click(object sender, EventArgs e)
        {
            if (InputText.Checked == true && InputMorse.Checked == false)
            {
                textBox3.Text = TilMorse(textBox1.Text);
            }
            if (InputText.Checked == false && InputMorse.Checked == true)
            {
                textBox3.Text = FraMorse(textBox1.Text);
            }
            if (InputText.Checked == true && InputMorse.Checked == true)
            {
                textBox3.Text = FejlText;
            }
            if (InputText.Checked == false && InputMorse.Checked == false)
            {
                textBox3.Text = FejlText;
            }
        }

        // Output textfield
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Translates Text to Morsecode
        public static string TilMorse(string text)
        {
            text = text.ToLower(); // Sets the text to lowercase

            // Replaces the letters with the corresponding morsecode
            text = text.Replace("ch", "----/");
            text = text.Replace("e", "./");
            text = text.Replace("t", "-/");
            text = text.Replace("i", "../");
            text = text.Replace("a", ".-/");
            text = text.Replace("n", "-./");
            text = text.Replace("m", "--/");
            text = text.Replace("s", ".../");
            text = text.Replace("u", "..-/");
            text = text.Replace("r", ".-./");
            text = text.Replace("w", ".--/");
            text = text.Replace("d", "-../");
            text = text.Replace("k", "-.-/");
            text = text.Replace("g", "--./");
            text = text.Replace("o", "---/");
            text = text.Replace("h", "..../");
            text = text.Replace("v", "...-/");
            text = text.Replace("f", "..-./");
            text = text.Replace("*", "..--/");
            text = text.Replace("l", ".-../");
            text = text.Replace("æ", ".-.-/");
            text = text.Replace("p", ".--./");
            text = text.Replace("j", ".---/");
            text = text.Replace("b", "-.../");
            text = text.Replace("x", "-..-/");
            text = text.Replace("c", "-.-./");
            text = text.Replace("y", "-.--/");
            text = text.Replace("z", "--../");
            text = text.Replace("q", "--.-/");
            text = text.Replace("ø", "---./");
            text = text.Replace("å", ".--.-/");
            text = text.Replace("5", "...../");
            text = text.Replace("4", "....-/");
            text = text.Replace("3", "...--/");
            text = text.Replace("2", "..---/");
            text = text.Replace("1", ".----/");
            text = text.Replace("6", "-..../");
            text = text.Replace("7", "--.../");
            text = text.Replace("8", "---../");
            text = text.Replace("9", "----./");
            text = text.Replace("0", "-----/");
            text = text.Replace(" ", "/");

            return text;
        }

        // Translates Morsecode to Plane text
        static public string FraMorse(string text)
        {
            // Replaces the letters with the corresponding morsecode
            text = text.Replace(".--.-/", "å");
            text = text.Replace("...../", "5");
            text = text.Replace("....-/", "4");
            text = text.Replace("...--/", "3");
            text = text.Replace("..---/", "2");
            text = text.Replace(".----/", "1");
            text = text.Replace("-..../", "6");
            text = text.Replace("--.../", "7");
            text = text.Replace("---../", "8");         
            text = text.Replace("-----/", "0");
            text = text.Replace("----./", "9");
            text = text.Replace("----/", "ch");
            text = text.Replace("..../", "h");
            text = text.Replace("...-/", "v");
            text = text.Replace("..-./", "f");
            text = text.Replace("..--/", "*");
            text = text.Replace(".-../", "l");
            text = text.Replace(".-.-/", "æ");
            text = text.Replace(".--./", "p");
            text = text.Replace(".---/", "j");
            text = text.Replace("-.../", "b");
            text = text.Replace("-..-/", "x");
            text = text.Replace("-.-./", "c");
            text = text.Replace("-.--/", "y");
            text = text.Replace("--../", "z");
            text = text.Replace("--.-/", "q");
            text = text.Replace("---./", "ø");
            text = text.Replace(".../", "s");
            text = text.Replace("..-/", "u");
            text = text.Replace(".-./", "r");
            text = text.Replace(".--/", "w");
            text = text.Replace("-../", "d");
            text = text.Replace("-.-/", "k");
            text = text.Replace("--./", "g");
            text = text.Replace("---/", "o");
            text = text.Replace("../", "i");
            text = text.Replace(".-/", "a");
            text = text.Replace("-./", "n");
            text = text.Replace("--/", "m");
            text = text.Replace("./", "e");
            text = text.Replace("-/", "t");
            text = text.Replace("/", " ");
            return text;
        }
    }
}
