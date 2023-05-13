using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mainbox.SelectedText);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            mainbox.SelectedText = Clipboard.GetText();
        }

        private void tb_pt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        // Allow only numeric input and control characters (e.g. backspace)
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Suppress the key press
        }
            

        }

        private void combo_gender_DropDown(object sender, EventArgs e)
        {

        }
    }
}
