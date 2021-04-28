/*  AeroShot - Transparent screenshot utility for Windows
    Copyright (C) 2021 Cvolton
    Copyright (C) 2015 toe_head2001
    Copyright (C) 2012 Caleb Joseph

    AeroShot is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    AeroShot is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. */

using System.Drawing;
using System.Windows.Forms;

namespace AeroShot
{
    sealed partial class MainForm
    {
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.NumericUpDown checkerValue;
        private System.Windows.Forms.ColorDialog opaqueColorDialog;
        private AeroShot.ColorDisplay opaqueColorDisplay;
        private System.Windows.Forms.TextBox opaqueColorHexBox;
        private System.Windows.Forms.FolderBrowserDialog folderSelectionDialog;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.GroupBox resizeGroupBox;
        private System.Windows.Forms.GroupBox opaqueGroupBox;
        private System.Windows.Forms.Label saveToLabel;
        private System.Windows.Forms.Label resizeLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label opaqueLabel;
        private System.Windows.Forms.Label opaqueVarLabel;
        private System.Windows.Forms.Label pxLabel;
        private System.Windows.Forms.Label opaqueHashLabel;
        private System.Windows.Forms.CheckBox opaqueCheckbox;
        private System.Windows.Forms.ComboBox opaqueType;

        private System.Windows.Forms.CheckBox aeroColorCheckbox;
        private System.Windows.Forms.GroupBox aeroColorGroupBox;
        private System.Windows.Forms.Label aeroColorLabel;
        private System.Windows.Forms.Label aeroColorColorLabel;
        private System.Windows.Forms.ColorDialog aeroColorDialog;
        private AeroShot.ColorDisplay aeroColorDisplay;
        private System.Windows.Forms.Label aeroColorHashLabel;
        private System.Windows.Forms.TextBox aeroColorHexBox;

        private System.Windows.Forms.CheckBox resizeCheckbox;
        private System.Windows.Forms.NumericUpDown windowHeight;
        private System.Windows.Forms.NumericUpDown windowWidth;
        private System.Windows.Forms.RadioButton diskButton;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.RadioButton clipboardButton;
        private System.Windows.Forms.CheckBox mouseCheckbox;
        private System.Windows.Forms.GroupBox mouseGroupBox;
        private System.Windows.Forms.Label mouseLabel;
        private System.Windows.Forms.CheckBox delayCheckbox;
        private System.Windows.Forms.GroupBox delayGroupBox;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.NumericUpDown delaySeconds;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.CheckBox clearTypeCheckbox;
        private System.Windows.Forms.GroupBox clearTypeGroupBox;
        private System.Windows.Forms.Label clearTypeLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;

        private System.Windows.Forms.GroupBox shadowGroupBox;
        private System.Windows.Forms.Label shadowLabel;
        private System.Windows.Forms.CheckBox shadowCheckbox;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveToLabel = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderSelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resizeCheckbox = new System.Windows.Forms.CheckBox();
            this.windowHeight = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.windowWidth = new System.Windows.Forms.NumericUpDown();
            this.opaqueCheckbox = new System.Windows.Forms.CheckBox();
            this.opaqueType = new System.Windows.Forms.ComboBox();
            this.opaqueVarLabel = new System.Windows.Forms.Label();
            this.checkerValue = new System.Windows.Forms.NumericUpDown();
            this.opaqueGroupBox = new System.Windows.Forms.GroupBox();
            this.opaqueColorHexBox = new System.Windows.Forms.TextBox();
            this.opaqueColorDisplay = new AeroShot.ColorDisplay();
            this.pxLabel = new System.Windows.Forms.Label();
            this.opaqueLabel = new System.Windows.Forms.Label();
            this.opaqueHashLabel = new System.Windows.Forms.Label();
            this.aeroColorCheckbox = new System.Windows.Forms.CheckBox();
            this.aeroColorGroupBox = new System.Windows.Forms.GroupBox();
            this.aeroColorLabel = new System.Windows.Forms.Label();
            this.aeroColorColorLabel = new System.Windows.Forms.Label();
            this.aeroColorHexBox = new System.Windows.Forms.TextBox();
            this.aeroColorDisplay = new AeroShot.ColorDisplay();
            this.aeroColorHashLabel = new System.Windows.Forms.Label();
            this.aeroColorDialog = new System.Windows.Forms.ColorDialog();
            this.resizeGroupBox = new System.Windows.Forms.GroupBox();
            this.resizeLabel = new System.Windows.Forms.Label();
            this.opaqueColorDialog = new System.Windows.Forms.ColorDialog();
            this.diskButton = new System.Windows.Forms.RadioButton();
            this.orLabel = new System.Windows.Forms.Label();
            this.clipboardButton = new System.Windows.Forms.RadioButton();
            this.mouseCheckbox = new System.Windows.Forms.CheckBox();
            this.mouseGroupBox = new System.Windows.Forms.GroupBox();
            this.mouseLabel = new System.Windows.Forms.Label();
            this.delayCheckbox = new System.Windows.Forms.CheckBox();
            this.delayGroupBox = new System.Windows.Forms.GroupBox();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delaySeconds = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.clearTypeCheckbox = new System.Windows.Forms.CheckBox();
            this.clearTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.clearTypeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.shadowGroupBox = new System.Windows.Forms.GroupBox();
            this.shadowLabel = new System.Windows.Forms.Label();
            this.shadowCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveInactiveTransparentCheckbox = new System.Windows.Forms.CheckBox();
            this.saveActiveTransparentCheckbox = new System.Windows.Forms.CheckBox();
            this.saveMaskCheckbox = new System.Windows.Forms.CheckBox();
            this.saveInactiveLightCheckbox = new System.Windows.Forms.CheckBox();
            this.saveInactiveDarkCheckbox = new System.Windows.Forms.CheckBox();
            this.saveActiveLightCheckbox = new System.Windows.Forms.CheckBox();
            this.saveActiveDarkCheckbox = new System.Windows.Forms.CheckBox();
            this.screenshotLabel = new System.Windows.Forms.Label();
            this.canvasSizeCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canvasLabel = new System.Windows.Forms.Label();
            this.canvasHeight = new System.Windows.Forms.NumericUpDown();
            this.canvasWidth = new System.Windows.Forms.NumericUpDown();
            this.x2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkerValue)).BeginInit();
            this.opaqueGroupBox.SuspendLayout();
            this.aeroColorGroupBox.SuspendLayout();
            this.resizeGroupBox.SuspendLayout();
            this.mouseGroupBox.SuspendLayout();
            this.delayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySeconds)).BeginInit();
            this.clearTypeGroupBox.SuspendLayout();
            this.shadowGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // saveToLabel
            // 
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveToLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToLabel.Location = new System.Drawing.Point(9, 9);
            this.saveToLabel.Name = "saveToLabel";
            this.saveToLabel.Size = new System.Drawing.Size(108, 13);
            this.saveToLabel.TabIndex = 3;
            this.saveToLabel.Text = "Save screenshots to";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTextBox.Location = new System.Drawing.Point(12, 25);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(309, 22);
            this.folderTextBox.TabIndex = 7;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(327, 24);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(90, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // folderSelectionDialog
            // 
            this.folderSelectionDialog.Description = "Please select the folder you wish screenshots to be saved to.\r\nFilenames are dete" +
    "rmined by the title of the window you are capturing.";
            // 
            // resizeCheckbox
            // 
            this.resizeCheckbox.AutoSize = true;
            this.resizeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.resizeCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeCheckbox.Location = new System.Drawing.Point(19, 53);
            this.resizeCheckbox.Name = "resizeCheckbox";
            this.resizeCheckbox.Size = new System.Drawing.Size(103, 17);
            this.resizeCheckbox.TabIndex = 9;
            this.resizeCheckbox.Text = "Resize window";
            this.resizeCheckbox.UseVisualStyleBackColor = false;
            this.resizeCheckbox.CheckedChanged += new System.EventHandler(this.ResizeCheckboxStateChange);
            // 
            // windowHeight
            // 
            this.windowHeight.Location = new System.Drawing.Point(338, 25);
            this.windowHeight.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.windowHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.Size = new System.Drawing.Size(60, 20);
            this.windowHeight.TabIndex = 14;
            this.windowHeight.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(324, 27);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(12, 13);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "x";
            // 
            // windowWidth
            // 
            this.windowWidth.Location = new System.Drawing.Point(262, 25);
            this.windowWidth.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.windowWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(60, 20);
            this.windowWidth.TabIndex = 12;
            this.windowWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // opaqueCheckbox
            // 
            this.opaqueCheckbox.AutoSize = true;
            this.opaqueCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.opaqueCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueCheckbox.Location = new System.Drawing.Point(19, 114);
            this.opaqueCheckbox.Name = "opaqueCheckbox";
            this.opaqueCheckbox.Size = new System.Drawing.Size(134, 17);
            this.opaqueCheckbox.TabIndex = 15;
            this.opaqueCheckbox.Text = "Opaque background";
            this.opaqueCheckbox.UseVisualStyleBackColor = false;
            this.opaqueCheckbox.CheckedChanged += new System.EventHandler(this.OpaqueCheckboxStateChange);
            // 
            // opaqueType
            // 
            this.opaqueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opaqueType.Enabled = false;
            this.opaqueType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueType.FormattingEnabled = true;
            this.opaqueType.Items.AddRange(new object[] {
            "Checkerboard",
            "Solid color"});
            this.opaqueType.Location = new System.Drawing.Point(195, 19);
            this.opaqueType.Name = "opaqueType";
            this.opaqueType.Size = new System.Drawing.Size(204, 21);
            this.opaqueType.TabIndex = 18;
            this.opaqueType.SelectedIndexChanged += new System.EventHandler(this.OpaqueTypeItemChange);
            // 
            // opaqueVarLabel
            // 
            this.opaqueVarLabel.AutoSize = true;
            this.opaqueVarLabel.BackColor = System.Drawing.Color.Transparent;
            this.opaqueVarLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueVarLabel.Location = new System.Drawing.Point(192, 48);
            this.opaqueVarLabel.Name = "opaqueVarLabel";
            this.opaqueVarLabel.Size = new System.Drawing.Size(27, 13);
            this.opaqueVarLabel.TabIndex = 19;
            this.opaqueVarLabel.Text = "VAR";
            // 
            // checkerValue
            // 
            this.checkerValue.Location = new System.Drawing.Point(327, 46);
            this.checkerValue.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.checkerValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.checkerValue.Name = "checkerValue";
            this.checkerValue.Size = new System.Drawing.Size(48, 20);
            this.checkerValue.TabIndex = 23;
            this.checkerValue.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // opaqueGroupBox
            // 
            this.opaqueGroupBox.Controls.Add(this.opaqueColorHexBox);
            this.opaqueGroupBox.Controls.Add(this.opaqueColorDisplay);
            this.opaqueGroupBox.Controls.Add(this.pxLabel);
            this.opaqueGroupBox.Controls.Add(this.opaqueVarLabel);
            this.opaqueGroupBox.Controls.Add(this.checkerValue);
            this.opaqueGroupBox.Controls.Add(this.opaqueType);
            this.opaqueGroupBox.Controls.Add(this.opaqueLabel);
            this.opaqueGroupBox.Controls.Add(this.opaqueHashLabel);
            this.opaqueGroupBox.Location = new System.Drawing.Point(12, 114);
            this.opaqueGroupBox.Name = "opaqueGroupBox";
            this.opaqueGroupBox.Size = new System.Drawing.Size(405, 76);
            this.opaqueGroupBox.TabIndex = 16;
            this.opaqueGroupBox.TabStop = false;
            // 
            // opaqueColorHexBox
            // 
            this.opaqueColorHexBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueColorHexBox.Location = new System.Drawing.Point(265, 46);
            this.opaqueColorHexBox.MaxLength = 6;
            this.opaqueColorHexBox.Name = "opaqueColorHexBox";
            this.opaqueColorHexBox.Size = new System.Drawing.Size(56, 20);
            this.opaqueColorHexBox.TabIndex = 21;
            this.opaqueColorHexBox.Text = "FFFFFF";
            this.opaqueColorHexBox.TextChanged += new System.EventHandler(this.opaqueColorHexBoxTextChange);
            // 
            // opaqueColorDisplay
            // 
            this.opaqueColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opaqueColorDisplay.Color = System.Drawing.Color.White;
            this.opaqueColorDisplay.Location = new System.Drawing.Point(327, 46);
            this.opaqueColorDisplay.Name = "opaqueColorDisplay";
            this.opaqueColorDisplay.Size = new System.Drawing.Size(72, 19);
            this.opaqueColorDisplay.TabIndex = 22;
            this.opaqueColorDisplay.Click += new System.EventHandler(this.opaqueColorDisplayClick);
            // 
            // pxLabel
            // 
            this.pxLabel.AutoSize = true;
            this.pxLabel.Location = new System.Drawing.Point(381, 48);
            this.pxLabel.Name = "pxLabel";
            this.pxLabel.Size = new System.Drawing.Size(18, 13);
            this.pxLabel.TabIndex = 24;
            this.pxLabel.Text = "px";
            // 
            // opaqueLabel
            // 
            this.opaqueLabel.AutoSize = true;
            this.opaqueLabel.BackColor = System.Drawing.Color.Transparent;
            this.opaqueLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueLabel.Location = new System.Drawing.Point(6, 20);
            this.opaqueLabel.Name = "opaqueLabel";
            this.opaqueLabel.Size = new System.Drawing.Size(162, 39);
            this.opaqueLabel.TabIndex = 17;
            this.opaqueLabel.Text = "Screenshots are saved with an\r\nopaque background, rather\r\nthan a transparent one." +
    "";
            // 
            // opaqueHashLabel
            // 
            this.opaqueHashLabel.AutoSize = true;
            this.opaqueHashLabel.BackColor = System.Drawing.Color.Transparent;
            this.opaqueHashLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opaqueHashLabel.Location = new System.Drawing.Point(250, 48);
            this.opaqueHashLabel.Name = "opaqueHashLabel";
            this.opaqueHashLabel.Size = new System.Drawing.Size(14, 13);
            this.opaqueHashLabel.TabIndex = 20;
            this.opaqueHashLabel.Text = "#";
            // 
            // aeroColorCheckbox
            // 
            this.aeroColorCheckbox.AutoSize = true;
            this.aeroColorCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorCheckbox.Location = new System.Drawing.Point(19, 196);
            this.aeroColorCheckbox.Name = "aeroColorCheckbox";
            this.aeroColorCheckbox.Size = new System.Drawing.Size(126, 17);
            this.aeroColorCheckbox.TabIndex = 50;
            this.aeroColorCheckbox.Text = "Custom Glass Color";
            this.aeroColorCheckbox.UseVisualStyleBackColor = false;
            this.aeroColorCheckbox.CheckedChanged += new System.EventHandler(this.AeroColorCheckboxStateChange);
            // 
            // aeroColorGroupBox
            // 
            this.aeroColorGroupBox.Controls.Add(this.aeroColorLabel);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorColorLabel);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorHexBox);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorDisplay);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorHashLabel);
            this.aeroColorGroupBox.Location = new System.Drawing.Point(12, 196);
            this.aeroColorGroupBox.Name = "aeroColorGroupBox";
            this.aeroColorGroupBox.Size = new System.Drawing.Size(405, 55);
            this.aeroColorGroupBox.TabIndex = 0;
            this.aeroColorGroupBox.TabStop = false;
            // 
            // aeroColorLabel
            // 
            this.aeroColorLabel.AutoSize = true;
            this.aeroColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorLabel.Location = new System.Drawing.Point(6, 20);
            this.aeroColorLabel.Name = "aeroColorLabel";
            this.aeroColorLabel.Size = new System.Drawing.Size(153, 26);
            this.aeroColorLabel.TabIndex = 0;
            this.aeroColorLabel.Text = "The color of Aero Glass will\r\nbe changed for screenshots.";
            // 
            // aeroColorColorLabel
            // 
            this.aeroColorColorLabel.AutoSize = true;
            this.aeroColorColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorColorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorColorLabel.Location = new System.Drawing.Point(192, 27);
            this.aeroColorColorLabel.Name = "aeroColorColorLabel";
            this.aeroColorColorLabel.Size = new System.Drawing.Size(38, 13);
            this.aeroColorColorLabel.TabIndex = 19;
            this.aeroColorColorLabel.Text = "Color:";
            // 
            // aeroColorHexBox
            // 
            this.aeroColorHexBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorHexBox.Location = new System.Drawing.Point(265, 25);
            this.aeroColorHexBox.MaxLength = 6;
            this.aeroColorHexBox.Name = "aeroColorHexBox";
            this.aeroColorHexBox.Size = new System.Drawing.Size(56, 20);
            this.aeroColorHexBox.TabIndex = 21;
            this.aeroColorHexBox.Text = "FFFFFF";
            this.aeroColorHexBox.TextChanged += new System.EventHandler(this.AeroColorTextboxTextChange);
            // 
            // aeroColorDisplay
            // 
            this.aeroColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aeroColorDisplay.Color = System.Drawing.Color.White;
            this.aeroColorDisplay.Location = new System.Drawing.Point(327, 25);
            this.aeroColorDisplay.Name = "aeroColorDisplay";
            this.aeroColorDisplay.Size = new System.Drawing.Size(72, 19);
            this.aeroColorDisplay.TabIndex = 0;
            this.aeroColorDisplay.Click += new System.EventHandler(this.AeroColorDisplayClick);
            // 
            // aeroColorHashLabel
            // 
            this.aeroColorHashLabel.AutoSize = true;
            this.aeroColorHashLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorHashLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorHashLabel.Location = new System.Drawing.Point(250, 27);
            this.aeroColorHashLabel.Name = "aeroColorHashLabel";
            this.aeroColorHashLabel.Size = new System.Drawing.Size(14, 13);
            this.aeroColorHashLabel.TabIndex = 0;
            this.aeroColorHashLabel.Text = "#";
            // 
            // aeroColorDialog
            // 
            this.aeroColorDialog.Color = System.Drawing.Color.White;
            this.aeroColorDialog.FullOpen = true;
            // 
            // resizeGroupBox
            // 
            this.resizeGroupBox.Controls.Add(this.resizeLabel);
            this.resizeGroupBox.Controls.Add(this.windowHeight);
            this.resizeGroupBox.Controls.Add(this.windowWidth);
            this.resizeGroupBox.Controls.Add(this.xLabel);
            this.resizeGroupBox.Location = new System.Drawing.Point(12, 53);
            this.resizeGroupBox.Name = "resizeGroupBox";
            this.resizeGroupBox.Size = new System.Drawing.Size(405, 55);
            this.resizeGroupBox.TabIndex = 10;
            this.resizeGroupBox.TabStop = false;
            // 
            // resizeLabel
            // 
            this.resizeLabel.AutoSize = true;
            this.resizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.resizeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeLabel.Location = new System.Drawing.Point(6, 20);
            this.resizeLabel.Name = "resizeLabel";
            this.resizeLabel.Size = new System.Drawing.Size(239, 26);
            this.resizeLabel.TabIndex = 11;
            this.resizeLabel.Text = "Sets the exact resolution screenshots are\r\ncaptured in, if the window supports re" +
    "sizing.";
            // 
            // opaqueColorDialog
            // 
            this.opaqueColorDialog.Color = System.Drawing.Color.White;
            this.opaqueColorDialog.FullOpen = true;
            // 
            // diskButton
            // 
            this.diskButton.AutoSize = true;
            this.diskButton.BackColor = System.Drawing.Color.Transparent;
            this.diskButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.diskButton.Location = new System.Drawing.Point(118, 7);
            this.diskButton.Name = "diskButton";
            this.diskButton.Size = new System.Drawing.Size(46, 17);
            this.diskButton.TabIndex = 4;
            this.diskButton.TabStop = true;
            this.diskButton.Text = "disk";
            this.diskButton.UseVisualStyleBackColor = false;
            this.diskButton.CheckedChanged += new System.EventHandler(this.DiskButtonStateChange);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.Location = new System.Drawing.Point(160, 9);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(18, 13);
            this.orLabel.TabIndex = 5;
            this.orLabel.Text = "or";
            // 
            // clipboardButton
            // 
            this.clipboardButton.AutoSize = true;
            this.clipboardButton.BackColor = System.Drawing.Color.Transparent;
            this.clipboardButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardButton.Location = new System.Drawing.Point(180, 7);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(74, 17);
            this.clipboardButton.TabIndex = 6;
            this.clipboardButton.TabStop = true;
            this.clipboardButton.Text = "clipboard";
            this.clipboardButton.UseVisualStyleBackColor = false;
            this.clipboardButton.CheckedChanged += new System.EventHandler(this.ClipboardButtonStateChange);
            // 
            // mouseCheckbox
            // 
            this.mouseCheckbox.AutoSize = true;
            this.mouseCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.mouseCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseCheckbox.Location = new System.Drawing.Point(19, 257);
            this.mouseCheckbox.Name = "mouseCheckbox";
            this.mouseCheckbox.Size = new System.Drawing.Size(145, 17);
            this.mouseCheckbox.TabIndex = 25;
            this.mouseCheckbox.Text = "Capture mouse pointer";
            this.mouseCheckbox.UseVisualStyleBackColor = false;
            this.mouseCheckbox.CheckedChanged += new System.EventHandler(this.MouseCheckboxStateChange);
            // 
            // mouseGroupBox
            // 
            this.mouseGroupBox.Controls.Add(this.mouseLabel);
            this.mouseGroupBox.Location = new System.Drawing.Point(12, 257);
            this.mouseGroupBox.Name = "mouseGroupBox";
            this.mouseGroupBox.Size = new System.Drawing.Size(405, 42);
            this.mouseGroupBox.TabIndex = 26;
            this.mouseGroupBox.TabStop = false;
            // 
            // mouseLabel
            // 
            this.mouseLabel.AutoSize = true;
            this.mouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.mouseLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseLabel.Location = new System.Drawing.Point(6, 20);
            this.mouseLabel.Name = "mouseLabel";
            this.mouseLabel.Size = new System.Drawing.Size(311, 13);
            this.mouseLabel.TabIndex = 27;
            this.mouseLabel.Text = "The system mouse pointer will be preserved in screenshots.";
            // 
            // delayCheckbox
            // 
            this.delayCheckbox.AutoSize = true;
            this.delayCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.delayCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayCheckbox.Location = new System.Drawing.Point(19, 305);
            this.delayCheckbox.Name = "delayCheckbox";
            this.delayCheckbox.Size = new System.Drawing.Size(96, 17);
            this.delayCheckbox.TabIndex = 28;
            this.delayCheckbox.Text = "Delay capture";
            this.delayCheckbox.UseVisualStyleBackColor = false;
            this.delayCheckbox.CheckedChanged += new System.EventHandler(this.DelayCheckboxStateChange);
            // 
            // delayGroupBox
            // 
            this.delayGroupBox.Controls.Add(this.delayLabel);
            this.delayGroupBox.Controls.Add(this.delaySeconds);
            this.delayGroupBox.Controls.Add(this.secondsLabel);
            this.delayGroupBox.Location = new System.Drawing.Point(12, 305);
            this.delayGroupBox.Name = "delayGroupBox";
            this.delayGroupBox.Size = new System.Drawing.Size(405, 55);
            this.delayGroupBox.TabIndex = 29;
            this.delayGroupBox.TabStop = false;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayLabel.Location = new System.Drawing.Point(6, 20);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(244, 13);
            this.delayLabel.TabIndex = 30;
            this.delayLabel.Text = "Adds a delay before screenshots are captured.";
            // 
            // delaySeconds
            // 
            this.delaySeconds.Location = new System.Drawing.Point(327, 25);
            this.delaySeconds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delaySeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delaySeconds.Name = "delaySeconds";
            this.delaySeconds.Size = new System.Drawing.Size(40, 20);
            this.delaySeconds.TabIndex = 31;
            this.delaySeconds.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(375, 27);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(24, 13);
            this.secondsLabel.TabIndex = 32;
            this.secondsLabel.Text = "sec";
            // 
            // clearTypeCheckbox
            // 
            this.clearTypeCheckbox.AutoSize = true;
            this.clearTypeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.clearTypeCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTypeCheckbox.Location = new System.Drawing.Point(19, 366);
            this.clearTypeCheckbox.Name = "clearTypeCheckbox";
            this.clearTypeCheckbox.Size = new System.Drawing.Size(116, 17);
            this.clearTypeCheckbox.TabIndex = 33;
            this.clearTypeCheckbox.Text = "Disable ClearType";
            this.clearTypeCheckbox.UseVisualStyleBackColor = false;
            this.clearTypeCheckbox.CheckedChanged += new System.EventHandler(this.ClearTypeCheckboxStateChange);
            // 
            // clearTypeGroupBox
            // 
            this.clearTypeGroupBox.Controls.Add(this.clearTypeLabel);
            this.clearTypeGroupBox.Location = new System.Drawing.Point(12, 366);
            this.clearTypeGroupBox.Name = "clearTypeGroupBox";
            this.clearTypeGroupBox.Size = new System.Drawing.Size(405, 55);
            this.clearTypeGroupBox.TabIndex = 34;
            this.clearTypeGroupBox.TabStop = false;
            // 
            // clearTypeLabel
            // 
            this.clearTypeLabel.AutoSize = true;
            this.clearTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.clearTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTypeLabel.Location = new System.Drawing.Point(6, 20);
            this.clearTypeLabel.Name = "clearTypeLabel";
            this.clearTypeLabel.Size = new System.Drawing.Size(374, 26);
            this.clearTypeLabel.TabIndex = 35;
            this.clearTypeLabel.Text = "ClearType font smoothing will be disabled while screenshots are being \r\ncaptured." +
    "";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(343, 726);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 36;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(259, 726);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 37;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // shadowGroupBox
            // 
            this.shadowGroupBox.Controls.Add(this.shadowLabel);
            this.shadowGroupBox.Location = new System.Drawing.Point(12, 427);
            this.shadowGroupBox.Name = "shadowGroupBox";
            this.shadowGroupBox.Size = new System.Drawing.Size(405, 42);
            this.shadowGroupBox.TabIndex = 51;
            this.shadowGroupBox.TabStop = false;
            // 
            // shadowLabel
            // 
            this.shadowLabel.AutoSize = true;
            this.shadowLabel.Location = new System.Drawing.Point(6, 20);
            this.shadowLabel.Name = "shadowLabel";
            this.shadowLabel.Size = new System.Drawing.Size(366, 13);
            this.shadowLabel.TabIndex = 0;
            this.shadowLabel.Text = "Shadows on windows will be disabled while screenshots are being captured.";
            // 
            // shadowCheckbox
            // 
            this.shadowCheckbox.AutoSize = true;
            this.shadowCheckbox.Location = new System.Drawing.Point(19, 426);
            this.shadowCheckbox.Name = "shadowCheckbox";
            this.shadowCheckbox.Size = new System.Drawing.Size(145, 17);
            this.shadowCheckbox.TabIndex = 0;
            this.shadowCheckbox.Text = "Disable window shadows";
            this.shadowCheckbox.UseVisualStyleBackColor = true;
            this.shadowCheckbox.CheckedChanged += new System.EventHandler(this.shadowCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveInactiveTransparentCheckbox);
            this.groupBox1.Controls.Add(this.saveActiveTransparentCheckbox);
            this.groupBox1.Controls.Add(this.saveMaskCheckbox);
            this.groupBox1.Controls.Add(this.saveInactiveLightCheckbox);
            this.groupBox1.Controls.Add(this.saveInactiveDarkCheckbox);
            this.groupBox1.Controls.Add(this.saveActiveLightCheckbox);
            this.groupBox1.Controls.Add(this.saveActiveDarkCheckbox);
            this.groupBox1.Controls.Add(this.screenshotLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 184);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // saveInactiveTransparentCheckbox
            // 
            this.saveInactiveTransparentCheckbox.AutoSize = true;
            this.saveInactiveTransparentCheckbox.Location = new System.Drawing.Point(9, 135);
            this.saveInactiveTransparentCheckbox.Name = "saveInactiveTransparentCheckbox";
            this.saveInactiveTransparentCheckbox.Size = new System.Drawing.Size(178, 17);
            this.saveInactiveTransparentCheckbox.TabIndex = 8;
            this.saveInactiveTransparentCheckbox.Text = "Inactive titlebar, fully transparent";
            this.saveInactiveTransparentCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveTransparentCheckbox
            // 
            this.saveActiveTransparentCheckbox.AutoSize = true;
            this.saveActiveTransparentCheckbox.Location = new System.Drawing.Point(9, 66);
            this.saveActiveTransparentCheckbox.Name = "saveActiveTransparentCheckbox";
            this.saveActiveTransparentCheckbox.Size = new System.Drawing.Size(170, 17);
            this.saveActiveTransparentCheckbox.TabIndex = 7;
            this.saveActiveTransparentCheckbox.Text = "Active titlebar, fully transparent";
            this.saveActiveTransparentCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveMaskCheckbox
            // 
            this.saveMaskCheckbox.AutoSize = true;
            this.saveMaskCheckbox.Location = new System.Drawing.Point(8, 158);
            this.saveMaskCheckbox.Name = "saveMaskCheckbox";
            this.saveMaskCheckbox.Size = new System.Drawing.Size(120, 17);
            this.saveMaskCheckbox.TabIndex = 6;
            this.saveMaskCheckbox.Text = "Black window mask";
            this.saveMaskCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveInactiveLightCheckbox
            // 
            this.saveInactiveLightCheckbox.AutoSize = true;
            this.saveInactiveLightCheckbox.Location = new System.Drawing.Point(9, 112);
            this.saveInactiveLightCheckbox.Name = "saveInactiveLightCheckbox";
            this.saveInactiveLightCheckbox.Size = new System.Drawing.Size(250, 17);
            this.saveInactiveLightCheckbox.TabIndex = 5;
            this.saveInactiveLightCheckbox.Text = "Inactive titlebar, optimized for light backgrounds";
            this.saveInactiveLightCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveInactiveDarkCheckbox
            // 
            this.saveInactiveDarkCheckbox.AutoSize = true;
            this.saveInactiveDarkCheckbox.Location = new System.Drawing.Point(9, 89);
            this.saveInactiveDarkCheckbox.Name = "saveInactiveDarkCheckbox";
            this.saveInactiveDarkCheckbox.Size = new System.Drawing.Size(252, 17);
            this.saveInactiveDarkCheckbox.TabIndex = 4;
            this.saveInactiveDarkCheckbox.Text = "Inactive titlebar, optimized for dark backgrounds";
            this.saveInactiveDarkCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveLightCheckbox
            // 
            this.saveActiveLightCheckbox.AutoSize = true;
            this.saveActiveLightCheckbox.Location = new System.Drawing.Point(9, 43);
            this.saveActiveLightCheckbox.Name = "saveActiveLightCheckbox";
            this.saveActiveLightCheckbox.Size = new System.Drawing.Size(242, 17);
            this.saveActiveLightCheckbox.TabIndex = 3;
            this.saveActiveLightCheckbox.Text = "Active titlebar, optimized for light backgrounds";
            this.saveActiveLightCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveDarkCheckbox
            // 
            this.saveActiveDarkCheckbox.AutoSize = true;
            this.saveActiveDarkCheckbox.Location = new System.Drawing.Point(9, 20);
            this.saveActiveDarkCheckbox.Name = "saveActiveDarkCheckbox";
            this.saveActiveDarkCheckbox.Size = new System.Drawing.Size(244, 17);
            this.saveActiveDarkCheckbox.TabIndex = 2;
            this.saveActiveDarkCheckbox.Text = "Active titlebar, optimized for dark backgrounds";
            this.saveActiveDarkCheckbox.UseVisualStyleBackColor = true;
            // 
            // screenshotLabel
            // 
            this.screenshotLabel.AutoSize = true;
            this.screenshotLabel.Location = new System.Drawing.Point(6, 0);
            this.screenshotLabel.Name = "screenshotLabel";
            this.screenshotLabel.Size = new System.Drawing.Size(141, 13);
            this.screenshotLabel.TabIndex = 1;
            this.screenshotLabel.Text = "Choose screenshots to save";
            // 
            // canvasSizeCheckbox
            // 
            this.canvasSizeCheckbox.AutoSize = true;
            this.canvasSizeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.canvasSizeCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canvasSizeCheckbox.Location = new System.Drawing.Point(20, 665);
            this.canvasSizeCheckbox.Name = "canvasSizeCheckbox";
            this.canvasSizeCheckbox.Size = new System.Drawing.Size(124, 17);
            this.canvasSizeCheckbox.TabIndex = 15;
            this.canvasSizeCheckbox.Text = "Custom canvas size";
            this.canvasSizeCheckbox.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.canvasLabel);
            this.groupBox2.Controls.Add(this.canvasHeight);
            this.groupBox2.Controls.Add(this.canvasWidth);
            this.groupBox2.Controls.Add(this.x2Label);
            this.groupBox2.Location = new System.Drawing.Point(13, 665);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.BackColor = System.Drawing.Color.Transparent;
            this.canvasLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canvasLabel.Location = new System.Drawing.Point(6, 20);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(216, 26);
            this.canvasLabel.TabIndex = 11;
            this.canvasLabel.Text = "Sets the exact resolution screenshots are\r\ncaptured in with added empty space.";
            // 
            // canvasHeight
            // 
            this.canvasHeight.Location = new System.Drawing.Point(338, 25);
            this.canvasHeight.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.canvasHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.canvasHeight.Name = "canvasHeight";
            this.canvasHeight.Size = new System.Drawing.Size(60, 20);
            this.canvasHeight.TabIndex = 14;
            this.canvasHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // canvasWidth
            // 
            this.canvasWidth.Location = new System.Drawing.Point(262, 25);
            this.canvasWidth.Maximum = new decimal(new int[] {
            16777215,
            0,
            0,
            0});
            this.canvasWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.canvasWidth.Name = "canvasWidth";
            this.canvasWidth.Size = new System.Drawing.Size(60, 20);
            this.canvasWidth.TabIndex = 12;
            this.canvasWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2Label.Location = new System.Drawing.Point(324, 27);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(12, 13);
            this.x2Label.TabIndex = 13;
            this.x2Label.Text = "x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(430, 756);
            this.Controls.Add(this.canvasSizeCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.shadowCheckbox);
            this.Controls.Add(this.shadowGroupBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resizeCheckbox);
            this.Controls.Add(this.opaqueCheckbox);
            this.Controls.Add(this.aeroColorCheckbox);
            this.Controls.Add(this.mouseCheckbox);
            this.Controls.Add(this.delayCheckbox);
            this.Controls.Add(this.clearTypeCheckbox);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.saveToLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.diskButton);
            this.Controls.Add(this.resizeGroupBox);
            this.Controls.Add(this.opaqueGroupBox);
            this.Controls.Add(this.mouseGroupBox);
            this.Controls.Add(this.delayGroupBox);
            this.Controls.Add(this.clearTypeGroupBox);
            this.Controls.Add(this.aeroColorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} {1} - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkerValue)).EndInit();
            this.opaqueGroupBox.ResumeLayout(false);
            this.opaqueGroupBox.PerformLayout();
            this.aeroColorGroupBox.ResumeLayout(false);
            this.aeroColorGroupBox.PerformLayout();
            this.resizeGroupBox.ResumeLayout(false);
            this.resizeGroupBox.PerformLayout();
            this.mouseGroupBox.ResumeLayout(false);
            this.mouseGroupBox.PerformLayout();
            this.delayGroupBox.ResumeLayout(false);
            this.delayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySeconds)).EndInit();
            this.clearTypeGroupBox.ResumeLayout(false);
            this.clearTypeGroupBox.PerformLayout();
            this.shadowGroupBox.ResumeLayout(false);
            this.shadowGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private GroupBox groupBox1;
        private CheckBox saveMaskCheckbox;
        private CheckBox saveInactiveLightCheckbox;
        private CheckBox saveInactiveDarkCheckbox;
        private CheckBox saveActiveLightCheckbox;
        private CheckBox saveActiveDarkCheckbox;
        private Label screenshotLabel;
        private CheckBox saveInactiveTransparentCheckbox;
        private CheckBox saveActiveTransparentCheckbox;
        private CheckBox canvasSizeCheckbox;
        private GroupBox groupBox2;
        private Label canvasLabel;
        private NumericUpDown canvasHeight;
        private NumericUpDown canvasWidth;
        private Label x2Label;
    }
}