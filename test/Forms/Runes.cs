using System.Windows.Forms;

namespace test.Forms
{
    public partial class Runes : Form
    {
        public Runes()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textOutput_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void InputText_CheckedChanged(object sender, System.EventArgs e)
        {
            textOutput.Font = new System.Drawing.Font("Runes", 12.5F,
                                      System.Drawing.FontStyle.Regular,
                                      System.Drawing.GraphicsUnit.Point,
                                      ((byte)(0)));
        }

        private void InputKode_CheckedChanged(object sender, System.EventArgs e)
        {
            textOutput.Font = new System.Drawing.Font("Microsoft Sans Sarif", 12.5F,
                                      System.Drawing.FontStyle.Regular,
                                      System.Drawing.GraphicsUnit.Point,
                                      ((byte)(0)));
        }

        private void Translate_Click(object sender, System.EventArgs e)
        { 
            textOutput.Text = TilRune(textInput.Text);
        }


        static string TilRune(string input)
        {
            input.ToLower();
            input = input.Replace('j', 'i');
            input = input.Replace('q', 'k');
            input = input.Replace("w", "vv");
            input = input.Replace("x", "ks");
            input = input.Replace('z', 's');
            input = input.Replace("å", "aa");
            return input;
        }
    }
}
