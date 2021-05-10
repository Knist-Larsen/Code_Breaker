using System;
using System.Drawing;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F,
                                                    FontStyle.Regular, 
                                                    GraphicsUnit.Point,
                                                    0);
                    panelTitelBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 
                                                10F, 
                                                FontStyle.Regular, 
                                                GraphicsUnit.Point, 
                                                0);
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childform);
            this.panelDesktopPane.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitel.Text = childform.Text;
        }

        private void btnMorse_Click(object sender, EventArgs e) // MorseBtn
        {
            OpenChildForm(new Forms.FormMorse(), sender);
        }

        private void btnBukstavsKode_Click(object sender, EventArgs e) // A-KkodeBtn
        {
            OpenChildForm(new Forms.A_K(), sender);
        }

        private void btnSMS_Click(object sender, EventArgs e) // NummerkodeBtn
        {
            OpenChildForm(new Forms.NummerKode(), sender);
        }

        private void btnBukstavsKode_Click_1(object sender, EventArgs e) // BogstavskodeBtn
        {
            OpenChildForm(new Forms.BogstavsKode(), sender);
        }
    }
}
