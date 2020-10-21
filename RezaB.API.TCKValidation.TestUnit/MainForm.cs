using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezaB.API.TCKValidation.TestUnit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckValidityButton_Click(object sender, EventArgs e)
        {
            var client = new TCKValidationClient();
            bool response = false;
            if (!string.IsNullOrWhiteSpace(CertificateNoTextbox.Text))
                response = client.ValidateOldTCK(TCKNoTextbox.Text, FirstNameTextbox.Text, LastNameTextbox.Text, BirthDateDatepicker.Value, CertificateNoTextbox.Text, CertificateSerialTextbox.Text);
            else if (!string.IsNullOrWhiteSpace(TCKRegistrationNoTextbox.Text))
                response = client.ValidateNewTCK(TCKNoTextbox.Text, FirstNameTextbox.Text, LastNameTextbox.Text, BirthDateDatepicker.Value, TCKRegistrationNoTextbox.Text);
            else
                response = client.ValidateOthers(TCKNoTextbox.Text, FirstNameTextbox.Text, LastNameTextbox.Text, BirthDateDatepicker.Value);

            MessageBox.Show(response ? "Valid" : "Invalid");
        }
    }
}
