﻿using System.Windows.Forms;
using System.IO;
using SBML2TikZ;
namespace SBML2TikZ_GUI
{
    partial class MainForm
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

        // Called after InitializeComponent() by the constructor to check
        // for saved settings 
        private void InitializeMyComponents()
        {
            heightBoxUnits.Items.AddRange(new object[] { units.pts, units.cm, units.inches });
            widthBoxUnits.Items.AddRange(new object[] { units.pts, units.cm, units.inches });
            dHeightBoxUnits.Items.AddRange(new object[] { units.pts, units.cm, units.inches });
            dWidthBoxUnits.Items.AddRange(new object[] { units.pts, units.cm, units.inches });
            showPDFCheckBox.Enabled = false; //only enabled if user has compileWithPDF set to true
            if (Application.UserAppDataRegistry.GetValue("xmlname") != null && File.Exists((string)Application.UserAppDataRegistry.GetValue("xmlname")))
            {
                if (nameChange != null)
                {
                    nameChange(new object(), (string)Application.UserAppDataRegistry.GetValue("xmlname"));
                }
            }
            if (Application.UserAppDataRegistry.GetValue("compileWithPdflatex") != null)
            {
                string compile = (string)Application.UserAppDataRegistry.GetValue("compileWithPdflatex");
                if (compile.Equals("True"))
                    CompileCheckBox.Checked = true;
                else
                    CompileCheckBox.Checked = false;
            }
            heightUnitsChange += new unitsChangeHandler(heightUnitsChanged); // Used to change the corresponding value
            widthUnitsChange += new unitsChangeHandler(widthUnitsChanged);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.load_Button = new System.Windows.Forms.Button();
            this.xmlfiledisplay = new System.Windows.Forms.TextBox();
            this.load_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desiredHeightBox = new System.Windows.Forms.TextBox();
            this.desiredWidthBox = new System.Windows.Forms.TextBox();
            this.dWidthBoxUnits = new System.Windows.Forms.ListBox();
            this.dHeightBoxUnits = new System.Windows.Forms.ListBox();
            this.LayoutSelectionBox = new System.Windows.Forms.ListBox();
            this.CompileCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBoxUnits = new System.Windows.Forms.ListBox();
            this.widthBoxUnits = new System.Windows.Forms.ListBox();
            this.SBGNCheckBox = new System.Windows.Forms.CheckBox();
            this.showOutDirCheckBox = new System.Windows.Forms.CheckBox();
            this.showPDFCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSBMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load_Panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(279, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert to *.TeX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Convert2pdf_Click);
            // 
            // load_Button
            // 
            this.load_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.load_Button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_Button.Location = new System.Drawing.Point(267, 9);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(147, 31);
            this.load_Button.TabIndex = 4;
            this.load_Button.Text = "Load SBML";
            this.load_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.load_Button.UseVisualStyleBackColor = true;
            this.load_Button.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // xmlfiledisplay
            // 
            this.xmlfiledisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.xmlfiledisplay.BackColor = System.Drawing.SystemColors.Window;
            this.xmlfiledisplay.Enabled = false;
            this.xmlfiledisplay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlfiledisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.xmlfiledisplay.Location = new System.Drawing.Point(5, 9);
            this.xmlfiledisplay.Name = "xmlfiledisplay";
            this.xmlfiledisplay.Size = new System.Drawing.Size(256, 31);
            this.xmlfiledisplay.TabIndex = 3;
            // 
            // load_Panel
            // 
            this.load_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.load_Panel.Controls.Add(this.xmlfiledisplay);
            this.load_Panel.Controls.Add(this.load_Button);
            this.load_Panel.Location = new System.Drawing.Point(12, 22);
            this.load_Panel.Name = "load_Panel";
            this.load_Panel.Size = new System.Drawing.Size(420, 50);
            this.load_Panel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desired Height ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desired Width ";
            // 
            // desiredHeightBox
            // 
            this.desiredHeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.desiredHeightBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredHeightBox.Location = new System.Drawing.Point(234, 148);
            this.desiredHeightBox.Name = "desiredHeightBox";
            this.desiredHeightBox.Size = new System.Drawing.Size(100, 27);
            this.desiredHeightBox.TabIndex = 8;
            // 
            // desiredWidthBox
            // 
            this.desiredWidthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.desiredWidthBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredWidthBox.Location = new System.Drawing.Point(234, 181);
            this.desiredWidthBox.Name = "desiredWidthBox";
            this.desiredWidthBox.Size = new System.Drawing.Size(100, 27);
            this.desiredWidthBox.TabIndex = 9;
            // 
            // dWidthBoxUnits
            // 
            this.dWidthBoxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dWidthBoxUnits.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dWidthBoxUnits.FormattingEnabled = true;
            this.dWidthBoxUnits.ItemHeight = 23;
            this.dWidthBoxUnits.Location = new System.Drawing.Point(340, 181);
            this.dWidthBoxUnits.Name = "dWidthBoxUnits";
            this.dWidthBoxUnits.Size = new System.Drawing.Size(86, 27);
            this.dWidthBoxUnits.TabIndex = 11;
            // 
            // dHeightBoxUnits
            // 
            this.dHeightBoxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dHeightBoxUnits.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dHeightBoxUnits.FormattingEnabled = true;
            this.dHeightBoxUnits.ItemHeight = 23;
            this.dHeightBoxUnits.Location = new System.Drawing.Point(340, 148);
            this.dHeightBoxUnits.Name = "dHeightBoxUnits";
            this.dHeightBoxUnits.Size = new System.Drawing.Size(86, 27);
            this.dHeightBoxUnits.TabIndex = 10;
            // 
            // LayoutSelectionBox
            // 
            this.LayoutSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LayoutSelectionBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutSelectionBox.FormattingEnabled = true;
            this.LayoutSelectionBox.ItemHeight = 23;
            this.LayoutSelectionBox.Location = new System.Drawing.Point(234, 216);
            this.LayoutSelectionBox.Name = "LayoutSelectionBox";
            this.LayoutSelectionBox.Size = new System.Drawing.Size(192, 27);
            this.LayoutSelectionBox.TabIndex = 12;
            this.LayoutSelectionBox.SelectedIndexChanged += new System.EventHandler(this.LayoutSelectionBox_SelectedIndexChanged);
            // 
            // CompileCheckBox
            // 
            this.CompileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CompileCheckBox.AutoSize = true;
            this.CompileCheckBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompileCheckBox.Location = new System.Drawing.Point(121, 256);
            this.CompileCheckBox.Name = "CompileCheckBox";
            this.CompileCheckBox.Size = new System.Drawing.Size(129, 17);
            this.CompileCheckBox.TabIndex = 14;
            this.CompileCheckBox.Text = "Compile with pdflatex";
            this.CompileCheckBox.UseVisualStyleBackColor = true;
            this.CompileCheckBox.CheckedChanged += new System.EventHandler(this.CompileCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Desired Layout";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recommended Height ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Recommended Width";
            // 
            // heightBox
            // 
            this.heightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.Location = new System.Drawing.Point(234, 80);
            this.heightBox.Name = "heightBox";
            this.heightBox.ReadOnly = true;
            this.heightBox.Size = new System.Drawing.Size(100, 27);
            this.heightBox.TabIndex = 18;
            // 
            // widthBox
            // 
            this.widthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(234, 115);
            this.widthBox.Name = "widthBox";
            this.widthBox.ReadOnly = true;
            this.widthBox.Size = new System.Drawing.Size(100, 27);
            this.widthBox.TabIndex = 19;
            // 
            // heightBoxUnits
            // 
            this.heightBoxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.heightBoxUnits.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBoxUnits.FormattingEnabled = true;
            this.heightBoxUnits.ItemHeight = 23;
            this.heightBoxUnits.Location = new System.Drawing.Point(340, 80);
            this.heightBoxUnits.Name = "heightBoxUnits";
            this.heightBoxUnits.Size = new System.Drawing.Size(86, 27);
            this.heightBoxUnits.TabIndex = 20;
            this.heightBoxUnits.SelectedIndexChanged += new System.EventHandler(this.heightBoxUnits_SelectedIndexChanged);
            // 
            // widthBoxUnits
            // 
            this.widthBoxUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.widthBoxUnits.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBoxUnits.FormattingEnabled = true;
            this.widthBoxUnits.ItemHeight = 23;
            this.widthBoxUnits.Location = new System.Drawing.Point(340, 115);
            this.widthBoxUnits.Name = "widthBoxUnits";
            this.widthBoxUnits.Size = new System.Drawing.Size(86, 27);
            this.widthBoxUnits.TabIndex = 21;
            this.widthBoxUnits.SelectedIndexChanged += new System.EventHandler(this.widthBoxUnits_SelectedIndexChanged);
            // 
            // SBGNCheckBox
            // 
            this.SBGNCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBGNCheckBox.AutoSize = true;
            this.SBGNCheckBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBGNCheckBox.Location = new System.Drawing.Point(17, 256);
            this.SBGNCheckBox.Name = "SBGNCheckBox";
            this.SBGNCheckBox.Size = new System.Drawing.Size(71, 17);
            this.SBGNCheckBox.TabIndex = 23;
            this.SBGNCheckBox.Text = "Use SBGN";
            this.SBGNCheckBox.UseVisualStyleBackColor = true;
            this.SBGNCheckBox.CheckedChanged += new System.EventHandler(this.SBGNCheckBox_CheckedChanged);
            // 
            // showOutDirCheckBox
            // 
            this.showOutDirCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showOutDirCheckBox.AutoSize = true;
            this.showOutDirCheckBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOutDirCheckBox.Location = new System.Drawing.Point(17, 279);
            this.showOutDirCheckBox.Name = "showOutDirCheckBox";
            this.showOutDirCheckBox.Size = new System.Drawing.Size(102, 17);
            this.showOutDirCheckBox.TabIndex = 24;
            this.showOutDirCheckBox.Text = "Show Output Dir";
            this.showOutDirCheckBox.UseVisualStyleBackColor = true;
            this.showOutDirCheckBox.CheckedChanged += new System.EventHandler(this.showOutDirCheckBox_CheckedChanged);
            // 
            // showPDFCheckBox
            // 
            this.showPDFCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showPDFCheckBox.AutoSize = true;
            this.showPDFCheckBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPDFCheckBox.Location = new System.Drawing.Point(121, 279);
            this.showPDFCheckBox.Name = "showPDFCheckBox";
            this.showPDFCheckBox.Size = new System.Drawing.Size(71, 17);
            this.showPDFCheckBox.TabIndex = 25;
            this.showPDFCheckBox.Text = "Show PDF";
            this.showPDFCheckBox.UseVisualStyleBackColor = true;
            this.showPDFCheckBox.CheckedChanged += new System.EventHandler(this.showPDFCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSBMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadSBMLToolStripMenuItem
            // 
            this.loadSBMLToolStripMenuItem.Name = "loadSBMLToolStripMenuItem";
            this.loadSBMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadSBMLToolStripMenuItem.Text = "Load SBML";
            this.loadSBMLToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 308);
            this.Controls.Add(this.showPDFCheckBox);
            this.Controls.Add(this.showOutDirCheckBox);
            this.Controls.Add(this.SBGNCheckBox);
            this.Controls.Add(this.widthBoxUnits);
            this.Controls.Add(this.heightBoxUnits);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompileCheckBox);
            this.Controls.Add(this.LayoutSelectionBox);
            this.Controls.Add(this.dWidthBoxUnits);
            this.Controls.Add(this.dHeightBoxUnits);
            this.Controls.Add(this.desiredWidthBox);
            this.Controls.Add(this.desiredHeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_Panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert SBML to PGF/TikZ";
            this.load_Panel.ResumeLayout(false);
            this.load_Panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Button load_Button;
        private TextBox xmlfiledisplay;
        private Panel load_Panel;
        private Label label1;
        private Label label2;
        private TextBox desiredHeightBox;
        private TextBox desiredWidthBox;
        private ListBox dWidthBoxUnits;
        private ListBox dHeightBoxUnits;
        private ListBox LayoutSelectionBox;
        private CheckBox CompileCheckBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox heightBox;
        private TextBox widthBox;
        private ListBox heightBoxUnits;
        private ListBox widthBoxUnits;
        private CheckBox SBGNCheckBox;
        private CheckBox showOutDirCheckBox;
        private CheckBox showPDFCheckBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadSBMLToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}