using System.Windows.Forms;

namespace test.Forms
{
    public partial class Fylder : Form
    {
        public Fylder()
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
            
        }

        private void InputKode_CheckedChanged(object sender, System.EventArgs e)
        {
            
        }

        private void Translate_Click(object sender, System.EventArgs e)
        { 
            textOutput.Text = TilRune(textInput.Text);
        }


        static string TilFyld(string input)
        {




        }
    }
}
