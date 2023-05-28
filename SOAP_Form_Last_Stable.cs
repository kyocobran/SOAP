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
using Newtonsoft.Json;
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
        private string Initial_combo_treatedfor;
        private string Initial_combo_subhx_dx;
        private string Initial_combo_medhxdx;
        private string Initial_combo_psychmeds;

        //declare initial variable for listbox_treatedfor
        private List<string> Initial_listbox_treatedfor_items;

        //declare initial variable for listbox_subhx_dx
        private List<string> Initial_listbox_subhx_dx_items;

        //declare initial variable for listbox_medhxdx
        private List<string> Initial_listbox_medhxdx_items;

        //declare initial variable for listbox_psychmeds
        private List<string> Initial_listbox_psychmeds_items;

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
            Initial_combo_treatedfor = combo_treatedfor.Text;
            Initial_combo_subhx_dx = combo_subhx_dx.Text;
            Initial_combo_medhxdx = combo_medhxdx.Text;
            Initial_combo_psychmeds = combo_psychmeds.Text;

            // Store the initial values for listbox_treatedfor
            Initial_listbox_treatedfor_items = new List<string>();
            foreach (string treatedfor_item in listbox_treatedfor.Items)
            {
                Initial_listbox_treatedfor_items.Add(treatedfor_item);
            }

            // Store the initial values for listbox_subhx_dx
            Initial_listbox_subhx_dx_items = new List<string>();
            foreach (string subhx_dx_item in listbox_subhx_dx.Items)
            {
                Initial_listbox_treatedfor_items.Add(subhx_dx_item);
            }

            // Store the initial values for listbox_medhxdx
            Initial_listbox_medhxdx_items = new List<string>();
            foreach (string medhxdx_item in listbox_medhxdx.Items)
            {
                Initial_listbox_medhxdx_items.Add(medhxdx_item);
            }

            // Store the initial values for listbox_psychmeds
            Initial_listbox_psychmeds_items = new List<string>();
            foreach (string psychmeds_item in listbox_psychmeds.Items)
            {
                Initial_listbox_psychmeds_items.Add(psychmeds_item);
            }

            //ATTACH TEXT LIST TO RESPECTIVE COMBO BOXES
            string[] genderlist = File.ReadAllLines("gender.txt");
            combo_gender.Items.AddRange(genderlist);

            string[] purposelist = File.ReadAllLines("visit_purpose.txt");
            combo_purpose.Items.AddRange(purposelist);

            string[] treatedforlist = File.ReadAllLines("psychdiagnosis.txt");
            combo_treatedfor.Items.AddRange(treatedforlist);

            string[] subhxdxlist = File.ReadAllLines("subhxdx.txt");
            combo_subhx_dx.Items.AddRange(subhxdxlist);

            string[] medhxdxlist = File.ReadAllLines("medhxdx.txt");
            combo_medhxdx.Items.AddRange(medhxdxlist);

            string[] psychmedlist = File.ReadAllLines("medlist.txt");
            combo_psychmeds.Items.AddRange(psychmedlist);



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
        //FOR POPULATING THE COMBO_TREATEDFOR LISTBOX
        //allow for pressing enter in the combo treated for box
        private void combo_treatedfor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string treatedfordiagnosis = combo_treatedfor.Text.Trim();

                if (!string.IsNullOrEmpty(treatedfordiagnosis))
                {
                    AddTreatedForListBox(treatedfordiagnosis);
                }

                e.Handled = true;
            }
        }

        //allows for pressing the addtreatedfor_dx button
        private void button_addtreatedfor_dx_Click(object sender, EventArgs e)
        {
            string treatedfordiagnosis = combo_treatedfor.Text.Trim();

            if (!string.IsNullOrEmpty(treatedfordiagnosis))
            {
                AddTreatedForListBox(treatedfordiagnosis);
            }
        }

        //method for actually adding diagnoses
        private void AddTreatedForListBox(string treatedfordiagnosis)
        {
            if (!listbox_treatedfor.Items.Contains(treatedfordiagnosis))
            {
                listbox_treatedfor.Items.Add(treatedfordiagnosis);
            }

            combo_treatedfor.Text = string.Empty;
        }

        //allows for removing a highlighted diagnosis from listbox_treatedfor
        private void button_removedtreatedfor_dx_Click(object sender, EventArgs e)
        {
            if (listbox_treatedfor.SelectedIndex != -1)
            {
                listbox_treatedfor.Items.RemoveAt(listbox_treatedfor.SelectedIndex);
            }
        }
        //ABOVE
        //


        //
        //FOR POPULATING THE COMBO_SUBHX_DX LISTBOX
        //allow for pressing enter in the combo treated for box
        private void combo_subhx_dx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string subhxdiagnosis = combo_subhx_dx.Text.Trim();

                if (!string.IsNullOrEmpty(subhxdiagnosis))
                {
                    AddSubHxDxListBox(subhxdiagnosis);
                }

                e.Handled = true;
            }
        }

        //allows for pressing the button_addsubhx_dx button
        private void button_addsubhx_dx_Click(object sender, EventArgs e)
        {
            string subhxdiagnosis = combo_subhx_dx.Text.Trim();

            if (!string.IsNullOrEmpty(subhxdiagnosis))
            {
                AddSubHxDxListBox(subhxdiagnosis);
            }
        }

        //method for actually adding subhx diagnoses
        private void AddSubHxDxListBox(string subhxdiagnosis)
        {
            if (!listbox_subhx_dx.Items.Contains(subhxdiagnosis))
            {
                listbox_subhx_dx.Items.Add(subhxdiagnosis);
            }

            combo_subhx_dx.Text = string.Empty;
        }

        //allows for removing a highlighted diagnosis from listbox_subhx_dx
        private void button_removesubhx_dx_Click(object sender, EventArgs e)
        {
            if (listbox_subhx_dx.SelectedIndex != -1)
            {
                listbox_subhx_dx.Items.RemoveAt(listbox_subhx_dx.SelectedIndex);
            }
        }
        //ABOVE
        //


        //
        //FOR POPULATING THE COMBO_TREATEDFOR LISTBOX
        //allow for pressing enter in the combo treated for box
        private void combo_medhxdx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string medhxdx_diagnosis = combo_medhxdx.Text.Trim();

                if (!string.IsNullOrEmpty(medhxdx_diagnosis))
                {
                    AddMedHxDxListBox(medhxdx_diagnosis);
                }

                e.Handled = true;
            }
        }

        //allows for pressing the addtreatedfor_dx button
        private void button_addmedhxdx_Click(object sender, EventArgs e)
        {
            string medhxdx_diagnosis = combo_medhxdx.Text.Trim();

            if (!string.IsNullOrEmpty(medhxdx_diagnosis))
            {
                AddMedHxDxListBox(medhxdx_diagnosis);
            }
        }

        //method for actually adding diagnoses
        private void AddMedHxDxListBox(string medhxdx_diagnosis)
        {
            if (!listbox_medhxdx.Items.Contains(medhxdx_diagnosis))
            {
                listbox_medhxdx.Items.Add(medhxdx_diagnosis);
            }

            combo_medhxdx.Text = string.Empty;
        }

        //allows for removing a highlighted diagnosis from listbox_medhxdx
        private void button_removedmedhxdx_Click(object sender, EventArgs e)
        {
            if (listbox_medhxdx.SelectedIndex != -1)
            {
                listbox_medhxdx.Items.RemoveAt(listbox_medhxdx.SelectedIndex);
            }
        }
        //ABOVE
        //



        //
        //FOR POPULATING THE COMBO_PSYCHMEDS LISTBOX
        //allow for pressing enter in the combo treated for box
        private void combo_psychmeds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string psychmeds_med = combo_psychmeds.Text.Trim();

                if (!string.IsNullOrEmpty(psychmeds_med))
                {
                    AddPsychMedsListBox(psychmeds_med);
                }

                e.Handled = true;
            }
        }

        //allows for pressing the addtreatedfor_dx button
        private void button_addpsychmeds_Click(object sender, EventArgs e)
        {
            string psychmeds_med = combo_psychmeds.Text.Trim();

            if (!string.IsNullOrEmpty(psychmeds_med))
            {
                AddPsychMedsListBox(psychmeds_med);
            }
        }

        //method for actually adding diagnoses
        private void AddPsychMedsListBox(string psychmeds_med)
        {
            if (!listbox_psychmeds.Items.Contains(psychmeds_med))
            {
                listbox_psychmeds.Items.Add(psychmeds_med);
            }

            combo_psychmeds.Text = string.Empty;
        }

        //allows for removing a highlighted diagnosis from listbox_psychmeds
        private void button_removedpsychmeds_Click(object sender, EventArgs e)
        {
            if (listbox_psychmeds.SelectedIndex != -1)
            {
                listbox_psychmeds.Items.RemoveAt(listbox_psychmeds.SelectedIndex);
            }
        }
        //ABOVE
        //



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

        private void tb_dob_Leave(object sender, EventArgs e)
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


        //Reset the form to its initialized state
        private void button_reset_Click(object sender, EventArgs e)
        {
            tb_name.Text = Initial_tb_name;
            tb_dob.Text = Initial_tb_dob;
            combo_gender.Text = Initial_combo_gender;
            combo_purpose.Text = Initial_combo_purpose;
            label_age.Text = Initial_label_age;
            combo_treatedfor.Text = Initial_combo_treatedfor;
            combo_subhx_dx.Text = Initial_combo_subhx_dx;
            combo_medhxdx.Text = Initial_combo_medhxdx;
            combo_psychmeds.Text = Initial_combo_psychmeds;

            //changes the listbox_treatedfor to its original state
            listbox_treatedfor.Items.Clear();
            foreach (string treatedfor_item in Initial_listbox_treatedfor_items)
            {
                listbox_treatedfor.Items.Add(treatedfor_item);
            }

            //changes the listbox_sub_hx to its original state
            listbox_subhx_dx.Items.Clear();
            foreach (string subhx_dx_item in Initial_listbox_subhx_dx_items)
            {
                listbox_treatedfor.Items.Add(subhx_dx_item);
            }

            //changes the listbox_medhxdx to its original state
            listbox_medhxdx.Items.Clear();
            foreach (string medhxdx_item in Initial_listbox_medhxdx_items)
            {
                listbox_medhxdx.Items.Add(medhxdx_item);
            }

            //changes the listbox_psychmeds to its original state
            listbox_psychmeds.Items.Clear();
            foreach (string psychmeds_item in Initial_listbox_psychmeds_items)
            {
                listbox_psychmeds.Items.Add(psychmeds_item);
            }
        }

        //
        //CREATING THE DATABINDINGS FOR SAVING AND LOADING PATIENT DATA
        public class PatientData
        {
            public string mainbox_Data { get; set; }
            public string name_Data { get; set; }
            public string dob_Data { get; set; }
            public string gender_Data { get; set; }
            public string purpose_Data { get; set; }
            public List<string> treatedforitems_Data { get; set; }
            public List<string> subhx_dx_items_Data { get; set; }
            public List<string> medhxdx_items_Data { get; set; }
            public List<string> psychmeds_items_Data { get; set; }
            // Add other properties for remaining controls
        }

        //SAVES PATIENT DATA AS A JSON FILE
        private void button_save_ptdata_Click(object sender, EventArgs e)
        {
            // Gather data from controls and create a data object
            var patientData = new PatientData
            {
                mainbox_Data = mainbox.Text,
                name_Data = tb_name.Text,
                dob_Data = tb_dob.Text,
                gender_Data = combo_gender.SelectedItem?.ToString(),
                purpose_Data = combo_purpose.SelectedItem?.ToString(),
                treatedforitems_Data = listbox_treatedfor.Items.Cast<string>().ToList(),
                subhx_dx_items_Data = listbox_subhx_dx.Items.Cast<string>().ToList(),
                medhxdx_items_Data = listbox_medhxdx.Items.Cast<string>().ToList(),
                psychmeds_items_Data = listbox_psychmeds.Items.Cast<string>().ToList(),
                // Add other properties for remaining controls
            };

            // Show the SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.Title = "Save Patient Data";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.FileName = "patient_data"; // Default file name

                // If the user selects a file and clicks the "Save" button
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string fileName = saveFileDialog.FileName;

                    // Serialize the data object to JSON
                    string jsonData = JsonConvert.SerializeObject(patientData);

                    // Write the JSON data to the selected file
                    File.WriteAllText(fileName, jsonData);
                }
            }
        }

        //LOADS PATIENT DATA FROM THE JSON FILE
        private void button_loadptdata_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json";
                openFileDialog.Title = "Load Patient Data";
                openFileDialog.DefaultExt = "json";

                // If the user selects a file and clicks the "Open" button
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file name
                    string fileName = openFileDialog.FileName;

                    // Read the JSON data from the selected file
                    string jsonData = File.ReadAllText(fileName);

                    // Deserialize the JSON data to the patient data object
                    var patientData = JsonConvert.DeserializeObject<PatientData>(jsonData);

                    // Populate the form controls with the loaded data
                    mainbox.Text = patientData.mainbox_Data;
                    tb_name.Text = patientData.name_Data;
                    tb_dob.Text = patientData.dob_Data;
                    combo_gender.SelectedItem = patientData.gender_Data;
                    combo_purpose.SelectedItem = patientData.purpose_Data;
                    listbox_treatedfor.Items.Clear();
                    listbox_treatedfor.Items.AddRange(patientData.treatedforitems_Data.ToArray());
                    listbox_subhx_dx.Items.Clear();
                    listbox_subhx_dx.Items.AddRange(patientData.subhx_dx_items_Data.ToArray());
                    listbox_medhxdx.Items.Clear();
                    listbox_medhxdx.Items.AddRange(patientData.medhxdx_items_Data.ToArray());
                    listbox_psychmeds.Items.Clear();
                    listbox_psychmeds.Items.AddRange(patientData.psychmeds_items_Data.ToArray());

                    // Add code to populate other form controls as 

                    
                    // Calculate age based on loaded DOB
                    DateTime dob;
                    if (DateTime.TryParseExact(patientData.dob_Data, new[] { "MM/dd/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out dob))
                    {
                        int age = CalculateAge(dob);
                        label_age.Text = age.ToString();
                    }
                    else
                    {
                        // Handle invalid DOB format
                        // You can show an error message or handle the situation according to your requirements
                    }
                }
            }
        }
        //ABOVE CONCLUDES THE DATABINDING
        //
    }
}
