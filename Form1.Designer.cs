﻿namespace SOAP
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Reset_Form = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainbox
            // 
            this.mainbox.Location = new System.Drawing.Point(20, 101);
            this.mainbox.Name = "mainbox";
            this.mainbox.Size = new System.Drawing.Size(947, 957);
            this.mainbox.TabIndex = 0;
            this.mainbox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy,
            this.Paste,
            this.Reset_Form});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 106);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(993, 1084);
            this.Controls.Add(this.mainbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Reset_Form;
    }
}
