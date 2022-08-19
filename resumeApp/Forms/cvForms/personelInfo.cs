using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resumeApp.Forms.cvForms
{
    public partial class personelInfo : Form
    {

        public TextBox textField;

        public personelInfo()
        {
            InitializeComponent();
        }

        private void ClearFieldText(object textSender, EventArgs e)
        {
            if(textSender != null)
            {
                MessageBox.Show("works");
                if(textField == (TextBox)textSender)
                {
                    textField.Click += (textSender, e) => {
                        textField.Clear();
                    };
                }
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            ClearFieldText(sender, e);
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
  
        }
    }
}
