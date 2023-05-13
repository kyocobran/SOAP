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
            this.mainbox = new System.Windows.Forms.RichTextBox();
            this.Right_Click_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset_Form = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_pt_age = new System.Windows.Forms.TextBox();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.combo_treatedfor = new System.Windows.Forms.ComboBox();
            this.Right_Click_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbox
            // 
            this.mainbox.ContextMenuStrip = this.Right_Click_Menu;
            this.mainbox.Location = new System.Drawing.Point(1545, 163);
            this.mainbox.Name = "mainbox";
            this.mainbox.Size = new System.Drawing.Size(677, 957);
            this.mainbox.TabIndex = 0;
            this.mainbox.Text = "";
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
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(189, 34);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Reset_Form
            // 
            this.Reset_Form.Name = "Reset_Form";
            this.Reset_Form.Size = new System.Drawing.Size(189, 34);
            this.Reset_Form.Text = "Reset Form";
            // 
            // tb_pt_age
            // 
            this.tb_pt_age.Location = new System.Drawing.Point(36, 37);
            this.tb_pt_age.Name = "tb_pt_age";
            this.tb_pt_age.Size = new System.Drawing.Size(113, 29);
            this.tb_pt_age.TabIndex = 1;
            this.tb_pt_age.Tag = "Demographics";
            this.tb_pt_age.Text = "Pt age";
            this.tb_pt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pt_age_KeyPress);
            // 
            // combo_gender
            // 
            this.combo_gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_gender.DropDownWidth = 175;
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender (MTF) Individual",
            "Transgender (FTM) Individual",
            "Non-binary individual"});
            this.combo_gender.Location = new System.Drawing.Point(197, 37);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(121, 32);
            this.combo_gender.TabIndex = 3;
            this.combo_gender.Tag = "Demographics";
            this.combo_gender.Text = "Gender";
            this.combo_gender.DropDown += new System.EventHandler(this.combo_gender_DropDown);
            // 
            // combo_treatedfor
            // 
            this.combo_treatedfor.FormattingEnabled = true;
            this.combo_treatedfor.Location = new System.Drawing.Point(358, 37);
            this.combo_treatedfor.Name = "combo_treatedfor";
            this.combo_treatedfor.Size = new System.Drawing.Size(357, 32);
            this.combo_treatedfor.TabIndex = 5;
            this.combo_treatedfor.Text = "Patient is being treated for";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2476, 1376);
            this.Controls.Add(this.combo_treatedfor);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.tb_pt_age);
            this.Controls.Add(this.mainbox);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Tag = "Demographics";
            this.Text = "SOAP Note";
            this.Right_Click_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainbox;
        private System.Windows.Forms.ContextMenuStrip Right_Click_Menu;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Reset_Form;
        private System.Windows.Forms.TextBox tb_pt_age;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.ComboBox combo_treatedfor;
    }
}

