using System.Windows.Forms;

namespace resumeApp
{
    public partial class libraries : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private Form activeForm;
        private int tempIndex;

        public libraries()
        {
            InitializeComponent();
            random = new Random();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Lucida Console", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(120, 0, 5);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form Childform, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(Childform);
            this.panelDesktop.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butCvs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.cvForms.personelInfo(), sender);
            labelTitleBar.Text = "Informations Personnelles";
        }

        private void butResumes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void butCoverLetters_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitleBar_Click(object sender, EventArgs e)
        {

        }
    }
}