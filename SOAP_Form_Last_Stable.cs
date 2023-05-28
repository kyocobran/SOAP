﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Globalization.DateTimeStyles;

namespace SOAP
{

    public partial class Form1 : Form
    {
        //DECLARE INITIAL VARIABLES FOR RESET FUNCTION
        private string Initial_tb_name;
        private string Initial_tb_dob;
        private string Initial_combo_gender;
        private string Initial_combo_purpose;
        private string Initial_label_age;

        public Form1()
        {
            InitializeComponent();

            // FOR RESET FUNCTIONALITY IN FORM_LOAD METHOD:
            // Store the initial values
            Initial_tb_name = tb_name.Text;
            Initial_tb_dob = tb_dob.Text;
            Initial_combo_gender = combo_gender.Text;
            Initial_combo_purpose = combo_purpose.Text;
            Initial_label_age = label_age.Text;

            //ATTACH TEXT LIST TO RESPECTIVE COMBO BOXES
            string[] genderlist = File.ReadAllLines("gender.txt");
            combo_gender.Items.AddRange(genderlist);
            
            string[] treatedforlist = File.ReadAllLines("psychdiagnosis.txt");
            combo_treatedfor.Items.AddRange(treatedforlist);

            string[] purposelist = File.ReadAllLines("visit_purpose.txt");
            combo_purpose.Items.AddRange(purposelist);


        }

        private void tb_dob_Enter(object sender, EventArgs e)
        {
            tb_dob.SelectAll();
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            tb_name.SelectAll();
        }
        












        //
        //SETS UP THE DOB text box to except numbers mainly and covert to mm/dd/yyyy format
        private void tb_dob_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only numbers, spaces, and three-letter month abbreviations
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !IsThreeLetterMonthAbbreviation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsThreeLetterMonthAbbreviation(char keyChar)
        {
            string[] monthAbbreviations = { "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
            string input = tb_dob.Text + keyChar;

            foreach (string monthAbbreviation in monthAbbreviations)
            {
                if (monthAbbreviation.StartsWith(input.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }

        private void tb_dob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = tb_dob.Text.Trim();

                DateTime dob;
                if (DateTime.TryParse(input, out dob))
                {
                    tb_dob.Text = dob.ToString("MM/dd/yyyy");

                    // Calculate age based on today's date
                    int age = CalculateAge(dob);
                    label_age.Text = age.ToString();

                }
                else if (DateTime.TryParseExact(input, new[] { "MMM d yy", "MMM d yyyy", "M d yy", "M d yyyy", "MM/dd/yy", "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
                {
                    tb_dob.Text = dob.ToString("MM/dd/yyyy");

                    // Calculate age based on today's date
                    int age = CalculateAge(dob);
                    label_age.Text = age.ToString();
                }
                else
                {
                    // Handle invalid input or show an error message
                }

                e.Handled = true;
            }
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (today < dateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }
        //ABOVE: SETS UP THE DOB text box to except numbers mainly and covert to mm/dd/yyyy format
        //

        private void button_reset_Click(object sender, EventArgs e)
        {
            tb_name.Text = Initial_tb_name;
            tb_dob.Text = Initial_tb_dob;
            combo_gender.Text = Initial_combo_gender;
            combo_purpose.Text = Initial_combo_purpose;
            label_age.Text = Initial_label_age;
        }

    }
}
