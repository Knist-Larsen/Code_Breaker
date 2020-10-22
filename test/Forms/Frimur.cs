using System.Windows.Forms;

namespace test.Forms
{
    public partial class Frimur : Form
    {
        public Frimur()
        {
            InitializeComponent();
        }
        
        private void textInput_TextChanged_1(object sender, System.EventArgs e)
        {

        }

        private void textOutput_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Translate_Click(object sender, System.EventArgs e)
        {
            textOutput.Text = textInput.Text;
        }

        private void InputText_CheckedChanged(object sender, System.EventArgs e)
        {
            textOutput.Font = new System.Drawing.Font("Frimur", 12.5F,
                                      System.Drawing.FontStyle.Regular,
                                      System.Drawing.GraphicsUnit.Point,
                                      ((byte)(0)));
            textOutput.Text.ToUpper();
        }

        private void InputKode_CheckedChanged(object sender, System.EventArgs e)
        {
            textOutput.Font = new System.Drawing.Font("Microsoft Sans Sarif", 12.5F,
                                      System.Drawing.FontStyle.Regular,
                                      System.Drawing.GraphicsUnit.Point,
                                      ((byte)(0)));
            textOutput.Text.ToLower();
        }
    }
}
