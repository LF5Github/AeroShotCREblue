/*  AeroShot - Transparent screenshot utility for Windows
    Copyright (C) 2022 LF5
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
        private System.Windows.Forms.FolderBrowserDialog folderSelectionDialog;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.GroupBox resizeGroupBox;
        private System.Windows.Forms.Label xLabel;

        private System.Windows.Forms.CheckBox aeroColorCheckbox;
        private System.Windows.Forms.GroupBox aeroColorGroupBox;
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
        private System.Windows.Forms.CheckBox shadowCheckbox;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderSelectionDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resizeCheckbox = new System.Windows.Forms.CheckBox();
            this.windowHeight = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.windowWidth = new System.Windows.Forms.NumericUpDown();
            this.aeroColorCheckbox = new System.Windows.Forms.CheckBox();
            this.aeroColorGroupBox = new System.Windows.Forms.GroupBox();
            this.aeroColorLabel = new System.Windows.Forms.Label();
            this.aeroColorColorLabel = new System.Windows.Forms.Label();
            this.aeroColorHexBox = new System.Windows.Forms.TextBox();
            this.aeroColorHashLabel = new System.Windows.Forms.Label();
            this.aeroColorDialog = new System.Windows.Forms.ColorDialog();
            this.resizeGroupBox = new System.Windows.Forms.GroupBox();
            this.resizeLabel = new System.Windows.Forms.Label();
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
            this.keyboardShortcutGroupBox = new System.Windows.Forms.GroupBox();
            this.keyboardShortcutButton = new System.Windows.Forms.Button();
            this.keyboardShortcutLabel = new System.Windows.Forms.Label();
            this.shadowGroupBox = new System.Windows.Forms.GroupBox();
            this.shadowLabel = new System.Windows.Forms.Label();
            this.tabAdvanced = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.appearanceSettings = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cropModeGroupBox = new System.Windows.Forms.GroupBox();
            this.cropModeKeepCenteredButton = new System.Windows.Forms.RadioButton();
            this.cropModeRemoveAllButton = new System.Windows.Forms.RadioButton();
            this.cropModeLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveToLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.nameVersion = new System.Windows.Forms.Label();
            this.aeroColorDisplay = new AeroShot.ColorDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).BeginInit();
            this.aeroColorGroupBox.SuspendLayout();
            this.resizeGroupBox.SuspendLayout();
            this.mouseGroupBox.SuspendLayout();
            this.delayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delaySeconds)).BeginInit();
            this.clearTypeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).BeginInit();
            this.keyboardShortcutGroupBox.SuspendLayout();
            this.shadowGroupBox.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cropModeGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderTextBox
            // 
            this.folderTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.folderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTextBox.ForeColor = System.Drawing.Color.White;
            this.folderTextBox.Location = new System.Drawing.Point(6, 66);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(424, 27);
            this.folderTextBox.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(6, 99);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(90, 28);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
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
            this.resizeCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.resizeCheckbox.ForeColor = System.Drawing.Color.White;
            this.resizeCheckbox.Location = new System.Drawing.Point(10, 6);
            this.resizeCheckbox.Name = "resizeCheckbox";
            this.resizeCheckbox.Size = new System.Drawing.Size(126, 24);
            this.resizeCheckbox.TabIndex = 10;
            this.resizeCheckbox.Text = "Resize window";
            this.resizeCheckbox.UseVisualStyleBackColor = false;
            this.resizeCheckbox.CheckedChanged += new System.EventHandler(this.ResizeCheckboxStateChange);
            // 
            // windowHeight
            // 
            this.windowHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.windowHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowHeight.ForeColor = System.Drawing.Color.White;
            this.windowHeight.Location = new System.Drawing.Point(353, 19);
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
            this.windowHeight.Size = new System.Drawing.Size(60, 27);
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
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.xLabel.ForeColor = System.Drawing.Color.White;
            this.xLabel.Location = new System.Drawing.Point(320, 16);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(27, 30);
            this.xLabel.TabIndex = 13;
            this.xLabel.Text = "×";
            // 
            // windowWidth
            // 
            this.windowWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.windowWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowWidth.ForeColor = System.Drawing.Color.White;
            this.windowWidth.Location = new System.Drawing.Point(254, 19);
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
            this.windowWidth.Size = new System.Drawing.Size(60, 27);
            this.windowWidth.TabIndex = 12;
            this.windowWidth.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // aeroColorCheckbox
            // 
            this.aeroColorCheckbox.AutoSize = true;
            this.aeroColorCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.aeroColorCheckbox.ForeColor = System.Drawing.Color.White;
            this.aeroColorCheckbox.Location = new System.Drawing.Point(10, 67);
            this.aeroColorCheckbox.Name = "aeroColorCheckbox";
            this.aeroColorCheckbox.Size = new System.Drawing.Size(156, 24);
            this.aeroColorCheckbox.TabIndex = 20;
            this.aeroColorCheckbox.Text = "Custom Glass Color";
            this.aeroColorCheckbox.UseVisualStyleBackColor = false;
            this.aeroColorCheckbox.CheckedChanged += new System.EventHandler(this.AeroColorCheckboxStateChange);
            // 
            // aeroColorGroupBox
            // 
            this.aeroColorGroupBox.Controls.Add(this.aeroColorLabel);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorColorLabel);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorHexBox);
            this.aeroColorGroupBox.Controls.Add(this.aeroColorHashLabel);
            this.aeroColorGroupBox.Location = new System.Drawing.Point(3, 67);
            this.aeroColorGroupBox.Name = "aeroColorGroupBox";
            this.aeroColorGroupBox.Size = new System.Drawing.Size(421, 55);
            this.aeroColorGroupBox.TabIndex = 19;
            this.aeroColorGroupBox.TabStop = false;
            // 
            // aeroColorLabel
            // 
            this.aeroColorLabel.AutoSize = true;
            this.aeroColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorLabel.ForeColor = System.Drawing.Color.White;
            this.aeroColorLabel.Location = new System.Drawing.Point(6, 20);
            this.aeroColorLabel.Name = "aeroColorLabel";
            this.aeroColorLabel.Size = new System.Drawing.Size(163, 26);
            this.aeroColorLabel.TabIndex = 21;
            this.aeroColorLabel.Text = "The color of Aero Glass will be\r\nchanged for screenshots.";
            this.aeroColorLabel.Visible = false;
            // 
            // aeroColorColorLabel
            // 
            this.aeroColorColorLabel.AutoSize = true;
            this.aeroColorColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorColorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorColorLabel.ForeColor = System.Drawing.Color.White;
            this.aeroColorColorLabel.Location = new System.Drawing.Point(199, 22);
            this.aeroColorColorLabel.Name = "aeroColorColorLabel";
            this.aeroColorColorLabel.Size = new System.Drawing.Size(106, 21);
            this.aeroColorColorLabel.TabIndex = 22;
            this.aeroColorColorLabel.Text = "Color (in hex):";
            // 
            // aeroColorHexBox
            // 
            this.aeroColorHexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.aeroColorHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aeroColorHexBox.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorHexBox.ForeColor = System.Drawing.Color.White;
            this.aeroColorHexBox.Location = new System.Drawing.Point(329, 20);
            this.aeroColorHexBox.MaxLength = 6;
            this.aeroColorHexBox.Name = "aeroColorHexBox";
            this.aeroColorHexBox.Size = new System.Drawing.Size(84, 28);
            this.aeroColorHexBox.TabIndex = 24;
            this.aeroColorHexBox.Text = "FFFFFF";
            this.aeroColorHexBox.TextChanged += new System.EventHandler(this.AeroColorTextboxTextChange);
            // 
            // aeroColorHashLabel
            // 
            this.aeroColorHashLabel.AutoSize = true;
            this.aeroColorHashLabel.BackColor = System.Drawing.Color.Transparent;
            this.aeroColorHashLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aeroColorHashLabel.ForeColor = System.Drawing.Color.White;
            this.aeroColorHashLabel.Location = new System.Drawing.Point(303, 18);
            this.aeroColorHashLabel.Name = "aeroColorHashLabel";
            this.aeroColorHashLabel.Size = new System.Drawing.Size(25, 30);
            this.aeroColorHashLabel.TabIndex = 23;
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
            this.resizeGroupBox.Location = new System.Drawing.Point(3, 6);
            this.resizeGroupBox.Name = "resizeGroupBox";
            this.resizeGroupBox.Size = new System.Drawing.Size(421, 55);
            this.resizeGroupBox.TabIndex = 9;
            this.resizeGroupBox.TabStop = false;
            // 
            // resizeLabel
            // 
            this.resizeLabel.AutoSize = true;
            this.resizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.resizeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizeLabel.ForeColor = System.Drawing.Color.White;
            this.resizeLabel.Location = new System.Drawing.Point(6, 20);
            this.resizeLabel.Name = "resizeLabel";
            this.resizeLabel.Size = new System.Drawing.Size(239, 26);
            this.resizeLabel.TabIndex = 11;
            this.resizeLabel.Text = "Sets the exact resolution screenshots are\r\ncaptured in, if the window supports re" +
    "sizing.";
            this.resizeLabel.Visible = false;
            // 
            // diskButton
            // 
            this.diskButton.AutoSize = true;
            this.diskButton.BackColor = System.Drawing.Color.Transparent;
            this.diskButton.Checked = true;
            this.diskButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.diskButton.FlatAppearance.BorderSize = 2;
            this.diskButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.diskButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.diskButton.ForeColor = System.Drawing.Color.White;
            this.diskButton.Location = new System.Drawing.Point(11, 36);
            this.diskButton.Name = "diskButton";
            this.diskButton.Size = new System.Drawing.Size(55, 24);
            this.diskButton.TabIndex = 0;
            this.diskButton.TabStop = true;
            this.diskButton.Text = "Disk";
            this.diskButton.UseVisualStyleBackColor = false;
            this.diskButton.CheckedChanged += new System.EventHandler(this.DiskButtonStateChange);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.Transparent;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.White;
            this.orLabel.Location = new System.Drawing.Point(73, 38);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(23, 20);
            this.orLabel.TabIndex = 5;
            this.orLabel.Text = "or";
            // 
            // clipboardButton
            // 
            this.clipboardButton.AutoSize = true;
            this.clipboardButton.BackColor = System.Drawing.Color.Transparent;
            this.clipboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clipboardButton.FlatAppearance.BorderSize = 2;
            this.clipboardButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.clipboardButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.clipboardButton.ForeColor = System.Drawing.Color.White;
            this.clipboardButton.Location = new System.Drawing.Point(110, 36);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(93, 24);
            this.clipboardButton.TabIndex = 1;
            this.clipboardButton.Text = "Clipboard";
            this.clipboardButton.UseVisualStyleBackColor = false;
            this.clipboardButton.CheckedChanged += new System.EventHandler(this.ClipboardButtonStateChange);
            // 
            // mouseCheckbox
            // 
            this.mouseCheckbox.AutoSize = true;
            this.mouseCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.mouseCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mouseCheckbox.ForeColor = System.Drawing.Color.White;
            this.mouseCheckbox.Location = new System.Drawing.Point(10, 6);
            this.mouseCheckbox.Name = "mouseCheckbox";
            this.mouseCheckbox.Size = new System.Drawing.Size(180, 24);
            this.mouseCheckbox.TabIndex = 30;
            this.mouseCheckbox.Text = "Capture mouse pointer";
            this.mouseCheckbox.UseVisualStyleBackColor = false;
            this.mouseCheckbox.CheckedChanged += new System.EventHandler(this.MouseCheckboxStateChange);
            // 
            // mouseGroupBox
            // 
            this.mouseGroupBox.Controls.Add(this.mouseLabel);
            this.mouseGroupBox.Location = new System.Drawing.Point(3, 6);
            this.mouseGroupBox.Name = "mouseGroupBox";
            this.mouseGroupBox.Size = new System.Drawing.Size(421, 42);
            this.mouseGroupBox.TabIndex = 29;
            this.mouseGroupBox.TabStop = false;
            // 
            // mouseLabel
            // 
            this.mouseLabel.AutoSize = true;
            this.mouseLabel.BackColor = System.Drawing.Color.Transparent;
            this.mouseLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseLabel.ForeColor = System.Drawing.Color.White;
            this.mouseLabel.Location = new System.Drawing.Point(6, 20);
            this.mouseLabel.Name = "mouseLabel";
            this.mouseLabel.Size = new System.Drawing.Size(311, 13);
            this.mouseLabel.TabIndex = 31;
            this.mouseLabel.Text = "The system mouse pointer will be preserved in screenshots.";
            this.mouseLabel.Visible = false;
            // 
            // delayCheckbox
            // 
            this.delayCheckbox.AutoSize = true;
            this.delayCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.delayCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.delayCheckbox.ForeColor = System.Drawing.Color.White;
            this.delayCheckbox.Location = new System.Drawing.Point(10, 54);
            this.delayCheckbox.Name = "delayCheckbox";
            this.delayCheckbox.Size = new System.Drawing.Size(120, 24);
            this.delayCheckbox.TabIndex = 40;
            this.delayCheckbox.Text = "Delay capture";
            this.delayCheckbox.UseVisualStyleBackColor = false;
            this.delayCheckbox.CheckedChanged += new System.EventHandler(this.DelayCheckboxStateChange);
            // 
            // delayGroupBox
            // 
            this.delayGroupBox.Controls.Add(this.delayLabel);
            this.delayGroupBox.Controls.Add(this.delaySeconds);
            this.delayGroupBox.Controls.Add(this.secondsLabel);
            this.delayGroupBox.Location = new System.Drawing.Point(3, 54);
            this.delayGroupBox.Name = "delayGroupBox";
            this.delayGroupBox.Size = new System.Drawing.Size(421, 44);
            this.delayGroupBox.TabIndex = 39;
            this.delayGroupBox.TabStop = false;
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delayLabel.ForeColor = System.Drawing.Color.White;
            this.delayLabel.Location = new System.Drawing.Point(6, 20);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(244, 13);
            this.delayLabel.TabIndex = 41;
            this.delayLabel.Text = "Adds a delay before screenshots are captured.";
            this.delayLabel.Visible = false;
            // 
            // delaySeconds
            // 
            this.delaySeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.delaySeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delaySeconds.ForeColor = System.Drawing.Color.White;
            this.delaySeconds.InterceptArrowKeys = false;
            this.delaySeconds.Location = new System.Drawing.Point(339, 15);
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
            this.delaySeconds.Size = new System.Drawing.Size(40, 23);
            this.delaySeconds.TabIndex = 42;
            this.delaySeconds.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(385, 15);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(30, 20);
            this.secondsLabel.TabIndex = 43;
            this.secondsLabel.Text = "sec";
            // 
            // clearTypeCheckbox
            // 
            this.clearTypeCheckbox.AutoSize = true;
            this.clearTypeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.clearTypeCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.clearTypeCheckbox.ForeColor = System.Drawing.Color.White;
            this.clearTypeCheckbox.Location = new System.Drawing.Point(10, 115);
            this.clearTypeCheckbox.Name = "clearTypeCheckbox";
            this.clearTypeCheckbox.Size = new System.Drawing.Size(147, 24);
            this.clearTypeCheckbox.TabIndex = 50;
            this.clearTypeCheckbox.Text = "Disable ClearType";
            this.clearTypeCheckbox.UseVisualStyleBackColor = false;
            this.clearTypeCheckbox.CheckedChanged += new System.EventHandler(this.ClearTypeCheckboxStateChange);
            // 
            // clearTypeGroupBox
            // 
            this.clearTypeGroupBox.Controls.Add(this.clearTypeLabel);
            this.clearTypeGroupBox.Location = new System.Drawing.Point(3, 115);
            this.clearTypeGroupBox.Name = "clearTypeGroupBox";
            this.clearTypeGroupBox.Size = new System.Drawing.Size(421, 55);
            this.clearTypeGroupBox.TabIndex = 49;
            this.clearTypeGroupBox.TabStop = false;
            // 
            // clearTypeLabel
            // 
            this.clearTypeLabel.AutoSize = true;
            this.clearTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.clearTypeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTypeLabel.ForeColor = System.Drawing.Color.White;
            this.clearTypeLabel.Location = new System.Drawing.Point(6, 20);
            this.clearTypeLabel.Name = "clearTypeLabel";
            this.clearTypeLabel.Size = new System.Drawing.Size(374, 26);
            this.clearTypeLabel.TabIndex = 51;
            this.clearTypeLabel.Text = "ClearType font smoothing will be disabled while screenshots are being \r\ncaptured." +
    "";
            this.clearTypeLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(379, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 40);
            this.cancelButton.TabIndex = 101;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.okButton.FlatAppearance.BorderSize = 3;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(283, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 40);
            this.okButton.TabIndex = 100;
            this.okButton.Text = "&Save";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // shadowCheckbox
            // 
            this.shadowCheckbox.AutoSize = true;
            this.shadowCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.shadowCheckbox.ForeColor = System.Drawing.Color.White;
            this.shadowCheckbox.Location = new System.Drawing.Point(7, 0);
            this.shadowCheckbox.Name = "shadowCheckbox";
            this.shadowCheckbox.Size = new System.Drawing.Size(195, 24);
            this.shadowCheckbox.TabIndex = 60;
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
            this.groupBox1.Location = new System.Drawing.Point(3, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 116);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            // 
            // saveInactiveTransparentCheckbox
            // 
            this.saveInactiveTransparentCheckbox.AutoSize = true;
            this.saveInactiveTransparentCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveInactiveTransparentCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveInactiveTransparentCheckbox.Location = new System.Drawing.Point(194, 66);
            this.saveInactiveTransparentCheckbox.Name = "saveInactiveTransparentCheckbox";
            this.saveInactiveTransparentCheckbox.Size = new System.Drawing.Size(196, 17);
            this.saveInactiveTransparentCheckbox.TabIndex = 96;
            this.saveInactiveTransparentCheckbox.Text = "Inactive, fully transparent titlebar";
            this.saveInactiveTransparentCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveTransparentCheckbox
            // 
            this.saveActiveTransparentCheckbox.AutoSize = true;
            this.saveActiveTransparentCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveActiveTransparentCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveActiveTransparentCheckbox.Location = new System.Drawing.Point(9, 66);
            this.saveActiveTransparentCheckbox.Name = "saveActiveTransparentCheckbox";
            this.saveActiveTransparentCheckbox.Size = new System.Drawing.Size(187, 17);
            this.saveActiveTransparentCheckbox.TabIndex = 95;
            this.saveActiveTransparentCheckbox.Text = "Active, fully transparent titlebar";
            this.saveActiveTransparentCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveMaskCheckbox
            // 
            this.saveMaskCheckbox.AutoSize = true;
            this.saveMaskCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveMaskCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveMaskCheckbox.Location = new System.Drawing.Point(9, 89);
            this.saveMaskCheckbox.Name = "saveMaskCheckbox";
            this.saveMaskCheckbox.Size = new System.Drawing.Size(126, 17);
            this.saveMaskCheckbox.TabIndex = 97;
            this.saveMaskCheckbox.Text = "Black window mask";
            this.saveMaskCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveInactiveLightCheckbox
            // 
            this.saveInactiveLightCheckbox.AutoSize = true;
            this.saveInactiveLightCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveInactiveLightCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveInactiveLightCheckbox.Location = new System.Drawing.Point(194, 43);
            this.saveInactiveLightCheckbox.Name = "saveInactiveLightCheckbox";
            this.saveInactiveLightCheckbox.Size = new System.Drawing.Size(184, 17);
            this.saveInactiveLightCheckbox.TabIndex = 94;
            this.saveInactiveLightCheckbox.Text = "Inactive, for light backgrounds";
            this.saveInactiveLightCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveInactiveDarkCheckbox
            // 
            this.saveInactiveDarkCheckbox.AutoSize = true;
            this.saveInactiveDarkCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveInactiveDarkCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveInactiveDarkCheckbox.Location = new System.Drawing.Point(194, 20);
            this.saveInactiveDarkCheckbox.Name = "saveInactiveDarkCheckbox";
            this.saveInactiveDarkCheckbox.Size = new System.Drawing.Size(183, 17);
            this.saveInactiveDarkCheckbox.TabIndex = 92;
            this.saveInactiveDarkCheckbox.Text = "Inactive, for dark backgrounds";
            this.saveInactiveDarkCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveLightCheckbox
            // 
            this.saveActiveLightCheckbox.AutoSize = true;
            this.saveActiveLightCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveActiveLightCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveActiveLightCheckbox.Location = new System.Drawing.Point(9, 43);
            this.saveActiveLightCheckbox.Name = "saveActiveLightCheckbox";
            this.saveActiveLightCheckbox.Size = new System.Drawing.Size(175, 17);
            this.saveActiveLightCheckbox.TabIndex = 93;
            this.saveActiveLightCheckbox.Text = "Active, for light backgrounds";
            this.saveActiveLightCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveActiveDarkCheckbox
            // 
            this.saveActiveDarkCheckbox.AutoSize = true;
            this.saveActiveDarkCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.saveActiveDarkCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveActiveDarkCheckbox.Location = new System.Drawing.Point(9, 20);
            this.saveActiveDarkCheckbox.Name = "saveActiveDarkCheckbox";
            this.saveActiveDarkCheckbox.Size = new System.Drawing.Size(174, 17);
            this.saveActiveDarkCheckbox.TabIndex = 91;
            this.saveActiveDarkCheckbox.Text = "Active, for dark backgrounds";
            this.saveActiveDarkCheckbox.UseVisualStyleBackColor = true;
            // 
            // screenshotLabel
            // 
            this.screenshotLabel.AutoSize = true;
            this.screenshotLabel.BackColor = System.Drawing.Color.Navy;
            this.screenshotLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.screenshotLabel.ForeColor = System.Drawing.Color.White;
            this.screenshotLabel.Location = new System.Drawing.Point(6, 0);
            this.screenshotLabel.Name = "screenshotLabel";
            this.screenshotLabel.Size = new System.Drawing.Size(189, 20);
            this.screenshotLabel.TabIndex = 90;
            this.screenshotLabel.Text = "Choose screenshots to save";
            // 
            // canvasSizeCheckbox
            // 
            this.canvasSizeCheckbox.AutoSize = true;
            this.canvasSizeCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.canvasSizeCheckbox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.canvasSizeCheckbox.ForeColor = System.Drawing.Color.White;
            this.canvasSizeCheckbox.Location = new System.Drawing.Point(10, 128);
            this.canvasSizeCheckbox.Name = "canvasSizeCheckbox";
            this.canvasSizeCheckbox.Size = new System.Drawing.Size(155, 24);
            this.canvasSizeCheckbox.TabIndex = 80;
            this.canvasSizeCheckbox.Text = "Custom canvas size";
            this.canvasSizeCheckbox.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.canvasLabel);
            this.groupBox2.Controls.Add(this.canvasHeight);
            this.groupBox2.Controls.Add(this.canvasWidth);
            this.groupBox2.Controls.Add(this.x2Label);
            this.groupBox2.Location = new System.Drawing.Point(3, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 55);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // canvasLabel
            // 
            this.canvasLabel.AutoSize = true;
            this.canvasLabel.BackColor = System.Drawing.Color.Transparent;
            this.canvasLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canvasLabel.ForeColor = System.Drawing.Color.White;
            this.canvasLabel.Location = new System.Drawing.Point(6, 20);
            this.canvasLabel.Name = "canvasLabel";
            this.canvasLabel.Size = new System.Drawing.Size(216, 26);
            this.canvasLabel.TabIndex = 81;
            this.canvasLabel.Text = "Sets the exact resolution screenshots are\r\ncaptured in with added empty space.";
            this.canvasLabel.Visible = false;
            // 
            // canvasHeight
            // 
            this.canvasHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.canvasHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasHeight.ForeColor = System.Drawing.Color.White;
            this.canvasHeight.Location = new System.Drawing.Point(354, 19);
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
            this.canvasHeight.Size = new System.Drawing.Size(60, 27);
            this.canvasHeight.TabIndex = 84;
            this.canvasHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // canvasWidth
            // 
            this.canvasWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.canvasWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasWidth.ForeColor = System.Drawing.Color.White;
            this.canvasWidth.Location = new System.Drawing.Point(255, 19);
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
            this.canvasWidth.Size = new System.Drawing.Size(60, 27);
            this.canvasWidth.TabIndex = 82;
            this.canvasWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // x2Label
            // 
            this.x2Label.AutoSize = true;
            this.x2Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2Label.ForeColor = System.Drawing.Color.White;
            this.x2Label.Location = new System.Drawing.Point(321, 16);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(27, 30);
            this.x2Label.TabIndex = 83;
            this.x2Label.Text = "×";
            // 
            // keyboardShortcutGroupBox
            // 
            this.keyboardShortcutGroupBox.Controls.Add(this.keyboardShortcutButton);
            this.keyboardShortcutGroupBox.Controls.Add(this.keyboardShortcutLabel);
            this.keyboardShortcutGroupBox.Location = new System.Drawing.Point(3, 225);
            this.keyboardShortcutGroupBox.Name = "keyboardShortcutGroupBox";
            this.keyboardShortcutGroupBox.Size = new System.Drawing.Size(273, 82);
            this.keyboardShortcutGroupBox.TabIndex = 69;
            this.keyboardShortcutGroupBox.TabStop = false;
            // 
            // keyboardShortcutButton
            // 
            this.keyboardShortcutButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.keyboardShortcutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.keyboardShortcutButton.FlatAppearance.BorderSize = 3;
            this.keyboardShortcutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyboardShortcutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.keyboardShortcutButton.ForeColor = System.Drawing.Color.Black;
            this.keyboardShortcutButton.Location = new System.Drawing.Point(10, 37);
            this.keyboardShortcutButton.Name = "keyboardShortcutButton";
            this.keyboardShortcutButton.Size = new System.Drawing.Size(252, 34);
            this.keyboardShortcutButton.TabIndex = 1;
            this.keyboardShortcutButton.Text = "Ctrl + Shift + Alt + PrintScreen";
            this.keyboardShortcutButton.UseVisualStyleBackColor = false;
            this.keyboardShortcutButton.Click += new System.EventHandler(this.keyboardShortcutButton_Click);
            this.keyboardShortcutButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyboardShortcutButton_KeyUp);
            // 
            // keyboardShortcutLabel
            // 
            this.keyboardShortcutLabel.AutoSize = true;
            this.keyboardShortcutLabel.BackColor = System.Drawing.Color.Transparent;
            this.keyboardShortcutLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.keyboardShortcutLabel.ForeColor = System.Drawing.Color.White;
            this.keyboardShortcutLabel.Location = new System.Drawing.Point(6, 14);
            this.keyboardShortcutLabel.Name = "keyboardShortcutLabel";
            this.keyboardShortcutLabel.Size = new System.Drawing.Size(182, 20);
            this.keyboardShortcutLabel.TabIndex = 0;
            this.keyboardShortcutLabel.Text = "Custom keyboard shortcut";
            // 
            // shadowGroupBox
            // 
            this.shadowGroupBox.Controls.Add(this.shadowLabel);
            this.shadowGroupBox.Controls.Add(this.shadowCheckbox);
            this.shadowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowGroupBox.Location = new System.Drawing.Point(3, 176);
            this.shadowGroupBox.Name = "shadowGroupBox";
            this.shadowGroupBox.Size = new System.Drawing.Size(421, 43);
            this.shadowGroupBox.TabIndex = 59;
            this.shadowGroupBox.TabStop = false;
            this.shadowGroupBox.Enter += new System.EventHandler(this.shadowGroupBox_Enter);
            // 
            // shadowLabel
            // 
            this.shadowLabel.AutoSize = true;
            this.shadowLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel.ForeColor = System.Drawing.Color.White;
            this.shadowLabel.Location = new System.Drawing.Point(6, 20);
            this.shadowLabel.Name = "shadowLabel";
            this.shadowLabel.Size = new System.Drawing.Size(404, 13);
            this.shadowLabel.TabIndex = 61;
            this.shadowLabel.Text = "Shadows on windows will be disabled while screenshots are being captured.";
            this.shadowLabel.Visible = false;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAdvanced.Controls.Add(this.tabPage1);
            this.tabAdvanced.Controls.Add(this.tabPage2);
            this.tabAdvanced.Controls.Add(this.tabPage3);
            this.tabAdvanced.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdvanced.Location = new System.Drawing.Point(0, 44);
            this.tabAdvanced.Multiline = true;
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabAdvanced.SelectedIndex = 0;
            this.tabAdvanced.Size = new System.Drawing.Size(473, 385);
            this.tabAdvanced.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAdvanced.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.appearanceSettings);
            this.tabPage1.Controls.Add(this.mouseCheckbox);
            this.tabPage1.Controls.Add(this.mouseGroupBox);
            this.tabPage1.Controls.Add(this.keyboardShortcutGroupBox);
            this.tabPage1.Controls.Add(this.delayCheckbox);
            this.tabPage1.Controls.Add(this.delayGroupBox);
            this.tabPage1.Controls.Add(this.clearTypeCheckbox);
            this.tabPage1.Controls.Add(this.clearTypeGroupBox);
            this.tabPage1.Controls.Add(this.shadowGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(30, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(6, 343);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(360, 24);
            this.checkBox1.TabIndex = 70;
            this.checkBox1.Text = "Automatically start AeroShotCRE blue with startup";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // appearanceSettings
            // 
            this.appearanceSettings.BackColor = System.Drawing.Color.RoyalBlue;
            this.appearanceSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.appearanceSettings.FlatAppearance.BorderSize = 3;
            this.appearanceSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appearanceSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.appearanceSettings.ForeColor = System.Drawing.Color.White;
            this.appearanceSettings.Location = new System.Drawing.Point(13, 311);
            this.appearanceSettings.Margin = new System.Windows.Forms.Padding(1);
            this.appearanceSettings.Name = "appearanceSettings";
            this.appearanceSettings.Size = new System.Drawing.Size(252, 31);
            this.appearanceSettings.TabIndex = 1;
            this.appearanceSettings.Text = "Change appearance settings";
            this.appearanceSettings.UseVisualStyleBackColor = false;
            this.appearanceSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.aeroColorCheckbox);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.resizeCheckbox);
            this.tabPage2.Controls.Add(this.canvasSizeCheckbox);
            this.tabPage2.Controls.Add(this.aeroColorGroupBox);
            this.tabPage2.Controls.Add(this.resizeGroupBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cropModeGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(30, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(439, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.ToolTipText = "Things that barely anyone uses, except for Choosing screenshots to save";
            // 
            // cropModeGroupBox
            // 
            this.cropModeGroupBox.Controls.Add(this.cropModeKeepCenteredButton);
            this.cropModeGroupBox.Controls.Add(this.cropModeRemoveAllButton);
            this.cropModeGroupBox.Controls.Add(this.cropModeLabel);
            this.cropModeGroupBox.Location = new System.Drawing.Point(3, 189);
            this.cropModeGroupBox.Name = "cropModeGroupBox";
            this.cropModeGroupBox.Size = new System.Drawing.Size(421, 46);
            this.cropModeGroupBox.TabIndex = 98;
            this.cropModeGroupBox.TabStop = false;
            // 
            // cropModeKeepCenteredButton
            // 
            this.cropModeKeepCenteredButton.AutoSize = true;
            this.cropModeKeepCenteredButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cropModeKeepCenteredButton.ForeColor = System.Drawing.Color.White;
            this.cropModeKeepCenteredButton.Location = new System.Drawing.Point(194, 19);
            this.cropModeKeepCenteredButton.Name = "cropModeKeepCenteredButton";
            this.cropModeKeepCenteredButton.Size = new System.Drawing.Size(143, 17);
            this.cropModeKeepCenteredButton.TabIndex = 92;
            this.cropModeKeepCenteredButton.TabStop = true;
            this.cropModeKeepCenteredButton.Text = "Keep window centered";
            this.cropModeKeepCenteredButton.UseVisualStyleBackColor = true;
            // 
            // cropModeRemoveAllButton
            // 
            this.cropModeRemoveAllButton.AutoSize = true;
            this.cropModeRemoveAllButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cropModeRemoveAllButton.ForeColor = System.Drawing.Color.White;
            this.cropModeRemoveAllButton.Location = new System.Drawing.Point(9, 19);
            this.cropModeRemoveAllButton.Name = "cropModeRemoveAllButton";
            this.cropModeRemoveAllButton.Size = new System.Drawing.Size(146, 17);
            this.cropModeRemoveAllButton.TabIndex = 91;
            this.cropModeRemoveAllButton.TabStop = true;
            this.cropModeRemoveAllButton.Text = "Remove all empty space";
            this.cropModeRemoveAllButton.UseVisualStyleBackColor = true;
            // 
            // cropModeLabel
            // 
            this.cropModeLabel.AutoSize = true;
            this.cropModeLabel.BackColor = System.Drawing.Color.Navy;
            this.cropModeLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cropModeLabel.ForeColor = System.Drawing.Color.White;
            this.cropModeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cropModeLabel.Location = new System.Drawing.Point(6, 0);
            this.cropModeLabel.Name = "cropModeLabel";
            this.cropModeLabel.Size = new System.Drawing.Size(84, 20);
            this.cropModeLabel.TabIndex = 90;
            this.cropModeLabel.Text = "Crop mode";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.browseButton);
            this.tabPage3.Controls.Add(this.folderTextBox);
            this.tabPage3.Controls.Add(this.saveToLabel);
            this.tabPage3.Controls.Add(this.clipboardButton);
            this.tabPage3.Controls.Add(this.orLabel);
            this.tabPage3.Controls.Add(this.diskButton);
            this.tabPage3.Location = new System.Drawing.Point(30, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(439, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Save to...";
            // 
            // saveToLabel
            // 
            this.saveToLabel.AutoSize = true;
            this.saveToLabel.BackColor = System.Drawing.Color.Transparent;
            this.saveToLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToLabel.ForeColor = System.Drawing.Color.White;
            this.saveToLabel.Location = new System.Drawing.Point(6, 3);
            this.saveToLabel.Name = "saveToLabel";
            this.saveToLabel.Size = new System.Drawing.Size(196, 30);
            this.saveToLabel.TabIndex = 3;
            this.saveToLabel.Text = "Save screenshots to";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.BorderSize = 3;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(221, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(56, 40);
            this.Exit.TabIndex = 102;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // nameVersion
            // 
            this.nameVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameVersion.AutoSize = true;
            this.nameVersion.Enabled = false;
            this.nameVersion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nameVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVersion.ForeColor = System.Drawing.Color.White;
            this.nameVersion.Location = new System.Drawing.Point(8, 432);
            this.nameVersion.Name = "nameVersion";
            this.nameVersion.Size = new System.Drawing.Size(62, 30);
            this.nameVersion.TabIndex = 103;
            this.nameVersion.Text = "{0} {1}";
            this.nameVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // aeroColorDisplay
            // 
            this.aeroColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aeroColorDisplay.Color = System.Drawing.Color.White;
            this.aeroColorDisplay.Location = new System.Drawing.Point(327, 25);
            this.aeroColorDisplay.Name = "aeroColorDisplay";
            this.aeroColorDisplay.Size = new System.Drawing.Size(72, 19);
            this.aeroColorDisplay.TabIndex = 25;
            this.aeroColorDisplay.Click += new System.EventHandler(this.AeroColorDisplayClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(473, 463);
            this.Controls.Add(this.nameVersion);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabAdvanced);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} {1} - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.windowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidth)).EndInit();
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasWidth)).EndInit();
            this.keyboardShortcutGroupBox.ResumeLayout(false);
            this.keyboardShortcutGroupBox.PerformLayout();
            this.shadowGroupBox.ResumeLayout(false);
            this.shadowGroupBox.PerformLayout();
            this.tabAdvanced.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cropModeGroupBox.ResumeLayout(false);
            this.cropModeGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private NumericUpDown canvasHeight;
        private NumericUpDown canvasWidth;
        private Label x2Label;
		private GroupBox keyboardShortcutGroupBox;
		private Button keyboardShortcutButton;
		private Label keyboardShortcutLabel;
		private GroupBox shadowGroupBox;
		private Label shadowLabel;
        private TabControl tabAdvanced;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button appearanceSettings;
        private TabPage tabPage3;
        private Label saveToLabel;
        private Button Exit;
        private CheckBox checkBox1;
        private GroupBox cropModeGroupBox;
        private RadioButton cropModeKeepCenteredButton;
        private RadioButton cropModeRemoveAllButton;
        private Label cropModeLabel;
        private Label aeroColorLabel;
        private Label resizeLabel;
        private Label canvasLabel;
        private Label nameVersion;
    }
}