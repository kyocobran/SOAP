namespace SOAP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Right_Click_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset_Form = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_dob = new System.Windows.Forms.TextBox();
            this.button_populator = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_addtreatedfor_dx = new System.Windows.Forms.Button();
            this.button_removetreatedfor_dx = new System.Windows.Forms.Button();
            this.combo_medlist_A = new System.Windows.Forms.ComboBox();
            this.combo_purpose = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.label_dob_instruction = new System.Windows.Forms.Label();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_subhx_dx = new System.Windows.Forms.ComboBox();
            this.listbox_treatedfor = new System.Windows.Forms.ListBox();
            this.listbox_subhx_dx = new System.Windows.Forms.ListBox();
            this.button_removesubhx_dx = new System.Windows.Forms.Button();
            this.button_addsubhx_dx = new System.Windows.Forms.Button();
            this.combo_treatedfor = new System.Windows.Forms.ComboBox();
            this.listbox_medhxdx = new System.Windows.Forms.ListBox();
            this.button_removemedhxdx = new System.Windows.Forms.Button();
            this.button_addmedhxdx = new System.Windows.Forms.Button();
            this.combo_medhxdx = new System.Windows.Forms.ComboBox();
            this.mainbox = new System.Windows.Forms.TextBox();
            this.Right_Click_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Right_Click_Menu
            // 
            this.Right_Click_Menu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.Right_Click_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy,
            this.Paste,
            this.Reset_Form});
            this.Right_Click_Menu.Name = "contextMenuStrip1";
            this.Right_Click_Menu.Size = new System.Drawing.Size(190, 106);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(189, 34);
            this.Copy.Text = "Copy";
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(189, 34);
            this.Paste.Text = "Paste";
            // 
            // Reset_Form
            // 
            this.Reset_Form.Name = "Reset_Form";
            this.Reset_Form.Size = new System.Drawing.Size(189, 34);
            this.Reset_Form.Text = "Reset Form";
            // 
            // tb_dob
            // 
            this.tb_dob.Location = new System.Drawing.Point(61, 172);
            this.tb_dob.Name = "tb_dob";
            this.tb_dob.Size = new System.Drawing.Size(340, 29);
            this.tb_dob.TabIndex = 2;
            this.tb_dob.Tag = "Demographics";
            this.tb_dob.Text = "Enter DOB in mm dd yy format";
            this.tb_dob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_dob_KeyDown);
            this.tb_dob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dob_KeyPress);
            // 
            // button_populator
            // 
            this.button_populator.Location = new System.Drawing.Point(1238, 91);
            this.button_populator.Name = "button_populator";
            this.button_populator.Size = new System.Drawing.Size(143, 75);
            this.button_populator.TabIndex = 250;
            this.button_populator.Text = "Populate";
            this.button_populator.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(1772, 91);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(143, 75);
            this.button_reset.TabIndex = 251;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_addtreatedfor_dx
            // 
            this.button_addtreatedfor_dx.Location = new System.Drawing.Point(462, 332);
            this.button_addtreatedfor_dx.Name = "button_addtreatedfor_dx";
            this.button_addtreatedfor_dx.Size = new System.Drawing.Size(136, 44);
            this.button_addtreatedfor_dx.TabIndex = 6;
            this.button_addtreatedfor_dx.Text = "Add Dx";
            this.button_addtreatedfor_dx.UseVisualStyleBackColor = true;
            this.button_addtreatedfor_dx.Click += new System.EventHandler(this.button_addtreatedfor_dx_Click);
            // 
            // button_removetreatedfor_dx
            // 
            this.button_removetreatedfor_dx.Location = new System.Drawing.Point(462, 395);
            this.button_removetreatedfor_dx.Name = "button_removetreatedfor_dx";
            this.button_removetreatedfor_dx.Size = new System.Drawing.Size(136, 44);
            this.button_removetreatedfor_dx.TabIndex = 7;
            this.button_removetreatedfor_dx.Text = "Remove Dx";
            this.button_removetreatedfor_dx.UseVisualStyleBackColor = true;
            this.button_removetreatedfor_dx.Click += new System.EventHandler(this.button_removedtreatedfor_dx_Click);
            // 
            // combo_medlist_A
            // 
            this.combo_medlist_A.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_medlist_A.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_medlist_A.FormattingEnabled = true;
            this.combo_medlist_A.Location = new System.Drawing.Point(61, 960);
            this.combo_medlist_A.Name = "combo_medlist_A";
            this.combo_medlist_A.Size = new System.Drawing.Size(332, 32);
            this.combo_medlist_A.TabIndex = 12;
            this.combo_medlist_A.Text = "Patient is taking";
            // 
            // combo_purpose
            // 
            this.combo_purpose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_purpose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_purpose.FormattingEnabled = true;
            this.combo_purpose.Location = new System.Drawing.Point(548, 45);
            this.combo_purpose.Name = "combo_purpose";
            this.combo_purpose.Size = new System.Drawing.Size(357, 32);
            this.combo_purpose.TabIndex = 3;
            this.combo_purpose.Text = "Purpose of Visit";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(61, 45);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(357, 32);
            this.tb_name.TabIndex = 1;
            this.tb_name.Tag = "Demographics";
            this.tb_name.Text = "Patient name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(420, 172);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(82, 29);
            this.label_age.TabIndex = 13;
            this.label_age.Text = "Pt age";
            // 
            // label_dob_instruction
            // 
            this.label_dob_instruction.AutoSize = true;
            this.label_dob_instruction.Location = new System.Drawing.Point(56, 102);
            this.label_dob_instruction.Name = "label_dob_instruction";
            this.label_dob_instruction.Size = new System.Drawing.Size(442, 50);
            this.label_dob_instruction.TabIndex = 14;
            this.label_dob_instruction.Text = "Enter the pt\'s DOB (mm yy dd) and press enter.\r\nPatient\'s age is automatically ca" +
    "lculated to the left.";
            // 
            // combo_gender
            // 
            this.combo_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Location = new System.Drawing.Point(548, 113);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(357, 32);
            this.combo_gender.TabIndex = 4;
            this.combo_gender.Text = "Gender";
            // 
            // combo_subhx_dx
            // 
            this.combo_subhx_dx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_subhx_dx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_subhx_dx.FormattingEnabled = true;
            this.combo_subhx_dx.Location = new System.Drawing.Point(61, 560);
            this.combo_subhx_dx.Name = "combo_subhx_dx";
            this.combo_subhx_dx.Size = new System.Drawing.Size(357, 32);
            this.combo_subhx_dx.TabIndex = 9;
            this.combo_subhx_dx.Text = "Additional SubHx if applicable";
            this.combo_subhx_dx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_subhx_dx_KeyDown);
            // 
            // listbox_treatedfor
            // 
            this.listbox_treatedfor.FormattingEnabled = true;
            this.listbox_treatedfor.ItemHeight = 24;
            this.listbox_treatedfor.Location = new System.Drawing.Point(624, 332);
            this.listbox_treatedfor.Name = "listbox_treatedfor";
            this.listbox_treatedfor.Size = new System.Drawing.Size(316, 100);
            this.listbox_treatedfor.TabIndex = 8;
            // 
            // listbox_subhx_dx
            // 
            this.listbox_subhx_dx.FormattingEnabled = true;
            this.listbox_subhx_dx.ItemHeight = 24;
            this.listbox_subhx_dx.Location = new System.Drawing.Point(624, 560);
            this.listbox_subhx_dx.Name = "listbox_subhx_dx";
            this.listbox_subhx_dx.Size = new System.Drawing.Size(316, 100);
            this.listbox_subhx_dx.TabIndex = 12;
            // 
            // button_removesubhx_dx
            // 
            this.button_removesubhx_dx.Location = new System.Drawing.Point(462, 623);
            this.button_removesubhx_dx.Name = "button_removesubhx_dx";
            this.button_removesubhx_dx.Size = new System.Drawing.Size(136, 44);
            this.button_removesubhx_dx.TabIndex = 11;
            this.button_removesubhx_dx.Text = "Remove Dx";
            this.button_removesubhx_dx.UseVisualStyleBackColor = true;
            this.button_removesubhx_dx.Click += new System.EventHandler(this.button_removesubhx_dx_Click);
            // 
            // button_addsubhx_dx
            // 
            this.button_addsubhx_dx.Location = new System.Drawing.Point(462, 560);
            this.button_addsubhx_dx.Name = "button_addsubhx_dx";
            this.button_addsubhx_dx.Size = new System.Drawing.Size(136, 44);
            this.button_addsubhx_dx.TabIndex = 10;
            this.button_addsubhx_dx.Text = "Add Dx";
            this.button_addsubhx_dx.UseVisualStyleBackColor = true;
            this.button_addsubhx_dx.Click += new System.EventHandler(this.button_addsubhx_dx_Click);
            // 
            // combo_treatedfor
            // 
            this.combo_treatedfor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_treatedfor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_treatedfor.FormattingEnabled = true;
            this.combo_treatedfor.Location = new System.Drawing.Point(61, 332);
            this.combo_treatedfor.Name = "combo_treatedfor";
            this.combo_treatedfor.Size = new System.Drawing.Size(357, 32);
            this.combo_treatedfor.TabIndex = 5;
            this.combo_treatedfor.Text = "The patient is treated for";
            this.combo_treatedfor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_treatedfor_KeyDown);
            // 
            // listbox_medhxdx
            // 
            this.listbox_medhxdx.FormattingEnabled = true;
            this.listbox_medhxdx.ItemHeight = 24;
            this.listbox_medhxdx.Location = new System.Drawing.Point(624, 753);
            this.listbox_medhxdx.Name = "listbox_medhxdx";
            this.listbox_medhxdx.Size = new System.Drawing.Size(316, 100);
            this.listbox_medhxdx.TabIndex = 16;
            // 
            // button_removemedhxdx
            // 
            this.button_removemedhxdx.Location = new System.Drawing.Point(462, 816);
            this.button_removemedhxdx.Name = "button_removemedhxdx";
            this.button_removemedhxdx.Size = new System.Drawing.Size(136, 44);
            this.button_removemedhxdx.TabIndex = 15;
            this.button_removemedhxdx.Text = "Remove Dx";
            this.button_removemedhxdx.UseVisualStyleBackColor = true;
            this.button_removemedhxdx.Click += new System.EventHandler(this.button_removedmedhxdx_Click);
            // 
            // button_addmedhxdx
            // 
            this.button_addmedhxdx.Location = new System.Drawing.Point(462, 753);
            this.button_addmedhxdx.Name = "button_addmedhxdx";
            this.button_addmedhxdx.Size = new System.Drawing.Size(136, 44);
            this.button_addmedhxdx.TabIndex = 14;
            this.button_addmedhxdx.Text = "Add Dx";
            this.button_addmedhxdx.UseVisualStyleBackColor = true;
            this.button_addmedhxdx.Click += new System.EventHandler(this.button_addmedhxdx_Click);
            // 
            // combo_medhxdx
            // 
            this.combo_medhxdx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_medhxdx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_medhxdx.FormattingEnabled = true;
            this.combo_medhxdx.Location = new System.Drawing.Point(61, 753);
            this.combo_medhxdx.Name = "combo_medhxdx";
            this.combo_medhxdx.Size = new System.Drawing.Size(357, 32);
            this.combo_medhxdx.TabIndex = 13;
            this.combo_medhxdx.Text = "Additional MedHx if applicable";
            this.combo_medhxdx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combo_medhxdx_KeyDown);
            // 
            // mainbox
            // 
            this.mainbox.Location = new System.Drawing.Point(1238, 189);
            this.mainbox.Multiline = true;
            this.mainbox.Name = "mainbox";
            this.mainbox.Size = new System.Drawing.Size(725, 830);
            this.mainbox.TabIndex = 252;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2476, 1376);
            this.Controls.Add(this.mainbox);
            this.Controls.Add(this.listbox_medhxdx);
            this.Controls.Add(this.button_removemedhxdx);
            this.Controls.Add(this.button_addmedhxdx);
            this.Controls.Add(this.combo_medhxdx);
            this.Controls.Add(this.combo_treatedfor);
            this.Controls.Add(this.listbox_subhx_dx);
            this.Controls.Add(this.button_removesubhx_dx);
            this.Controls.Add(this.button_addsubhx_dx);
            this.Controls.Add(this.listbox_treatedfor);
            this.Controls.Add(this.combo_subhx_dx);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.label_dob_instruction);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.combo_purpose);
            this.Controls.Add(this.combo_medlist_A);
            this.Controls.Add(this.button_removetreatedfor_dx);
            this.Controls.Add(this.button_addtreatedfor_dx);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_populator);
            this.Controls.Add(this.tb_dob);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Tag = "Demographics";
            this.Text = "SOAP Note";
            this.Right_Click_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Right_Click_Menu;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Reset_Form;
        private System.Windows.Forms.TextBox tb_dob;
        private System.Windows.Forms.Button button_populator;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_addtreatedfor_dx;
        private System.Windows.Forms.Button button_removetreatedfor_dx;
        private System.Windows.Forms.ComboBox combo_medlist_A;
        private System.Windows.Forms.ComboBox combo_purpose;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_dob_instruction;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.ComboBox combo_subhx_dx;
        private System.Windows.Forms.ListBox listbox_treatedfor;
        private System.Windows.Forms.ListBox listbox_subhx_dx;
        private System.Windows.Forms.Button button_removesubhx_dx;
        private System.Windows.Forms.Button button_addsubhx_dx;
        private System.Windows.Forms.ComboBox combo_treatedfor;
        private System.Windows.Forms.ListBox listbox_medhxdx;
        private System.Windows.Forms.Button button_removemedhxdx;
        private System.Windows.Forms.Button button_addmedhxdx;
        private System.Windows.Forms.ComboBox combo_medhxdx;
        private System.Windows.Forms.TextBox mainbox;
    }
}

