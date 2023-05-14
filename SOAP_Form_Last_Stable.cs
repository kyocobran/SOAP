using System;
using System.IO;
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

            // Links the psychdiagnosis.txt to comboboxes.
            // Read the lines of the linked text file
            string[] dxs = System.IO.File.ReadAllLines("psychdiagnosis.txt");
            
            // Add the lines to the combo box
            foreach (string dx in dxs)
            {
                combo_treatedfor.Items.Add(dx);
            }

            // Read the lines from medlist.txt
            string[] meds = File.ReadAllLines("medlist.txt");

            // Add each line to the combo box
            foreach (string med in meds)
            {
                combo_medlist_A.Items.Add(med);
            }
            
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

        private void combo_treatedfor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_treatedfor_box.AppendText(combo_treatedfor.Text + Environment.NewLine);
                combo_treatedfor.Text = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void button_add_dx_Click(object sender, EventArgs e)
        {
            tb_treatedfor_box.AppendText(combo_treatedfor.Text + Environment.NewLine);
            combo_treatedfor.Text = "";
        }

        private void button_remove_dx_Click(object sender, EventArgs e)
        {
            string text = tb_treatedfor_box.Text;
            if (!string.IsNullOrEmpty(text))
            {
                // Split the text into lines
                string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length > 0)
                {
                    // Remove the last line
                    string removedLine = lines[lines.Length - 1];
                    Array.Resize(ref lines, lines.Length - 1);

                    // Join the remaining lines and set the TextBox text
                    string remainingText = string.Join(Environment.NewLine, lines);
                    tb_treatedfor_box.Text = remainingText;
                }
            }
        }

        private void combo_medlist_A_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
