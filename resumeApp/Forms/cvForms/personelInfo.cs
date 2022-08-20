using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TextBox;
using MSHTML;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace resumeApp.Forms.cvForms
{
    public partial class personelInfo : Form
    {

        public TextBox textField;
        private SHDocVw.InternetExplorer TargetIE = null;
        string url;

        public personelInfo()
        {
            InitializeComponent();
            textField = new TextBox();
        }

        private void ClearFieldText(object textSender)
        {
            if(textSender != null)
            {
                if(textField != (TextBox)textSender)
                {
                    textField = (TextBox)textSender;
                    this.textField.Clear();
                    this.textField.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            ClearFieldText(sender);
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {
            ClearFieldText(sender);
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {
            ClearFieldText(sender);
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {
            ClearFieldText(sender);
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {
            ClearFieldText(sender);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //Use StreamWriter class.
            //StreamWriter sw = new StreamWriter("C:\\Users\\MSI\\source\\repos\\resumeApp\\resumeApp\\CVsModels\\CVModel1\\model1.html");
            GetTheIEObjectFromSystem("C:\\Users\\MSI\\source\\repos\\resumeApp\\resumeApp\\CVsModels\\CVModel1\\model1.html");
            SendTextToActiveElementWithSubmitOptionSet(false);
        }

        private void GetTheIEObjectFromSystem(string inurl = ".")
        {
            SHDocVw.ShellWindows SWs = new SHDocVw.ShellWindows();
            foreach (SHDocVw.InternetExplorer internetExplorer in SWs)
            {
                url = internetExplorer.LocationURL;
                TargetIE = internetExplorer;
                return;
            }

        }
        private void SendTextToActiveElementWithSubmitOptionSet(bool btnSubmit)
        {
            MSHTML.IHTMLDocument2 document = null;
            document = TargetIE.Document as MSHTML.IHTMLDocument2;
            if (!document.activeElement.isTextEdit)
            {
                MessageBox.Show("Active element is not a text-input system");
            }
            else
            {
                HTMLInputElement HTMLI;
                HTMLI = document.activeElement as HTMLInputElement;
                var tag = HTMLI.document as MSHTML.HTMLDocument;
                MSHTML.IHTMLElementCollection hTMLElementCollection = tag.getElementsByTagName("input");
                foreach (MSHTML.HTMLInputElement el in hTMLElementCollection)
                {
                    switch (el.id)
                    {
                        case "name":
                            el.value = name.Text;
                            break;
                        case "address":
                            el.value = address.Text;
                            break;
                        case "email":
                            el.value = email.Text;
                            break;
                        case "phone":
                            el.value = phone.Text;
                            break;
                        case "status":
                            el.value = status.Text;
                            break;
                    }
                }
            }
        }
    }
}
