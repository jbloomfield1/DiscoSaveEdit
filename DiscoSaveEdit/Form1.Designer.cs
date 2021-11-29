using System;

namespace DiscoSaveEdit
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sPnumUpDown = new System.Windows.Forms.NumericUpDown();
            this.sPlabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.jsonRawTxt = new System.Windows.Forms.TextBox();
            this.newJsonTxt = new System.Windows.Forms.TextBox();
            this.openFileLabel = new System.Windows.Forms.Label();
            this.openFileName = new System.Windows.Forms.Label();
            this.openJsonFileLabel = new System.Windows.Forms.Label();
            this.openJsonName = new System.Windows.Forms.Label();
            this.hPotLabel = new System.Windows.Forms.Label();
            this.hPotsUpDown = new System.Windows.Forms.NumericUpDown();
            this.pPotUpDown = new System.Windows.Forms.NumericUpDown();
            this.pPotlabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sPnumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPotsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPotUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "%appdata%\\LocalLow\\ZAUM Studio\\Disco Elysium\\SaveGames";
            // 
            // sPnumUpDown
            // 
            this.sPnumUpDown.Location = new System.Drawing.Point(156, 49);
            this.sPnumUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.sPnumUpDown.Name = "sPnumUpDown";
            this.sPnumUpDown.Size = new System.Drawing.Size(114, 20);
            this.sPnumUpDown.TabIndex = 1;
            this.sPnumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sPlabel
            // 
            this.sPlabel.AutoSize = true;
            this.sPlabel.BackColor = System.Drawing.Color.Transparent;
            this.sPlabel.Location = new System.Drawing.Point(89, 51);
            this.sPlabel.Name = "sPlabel";
            this.sPlabel.Size = new System.Drawing.Size(61, 13);
            this.sPlabel.TabIndex = 2;
            this.sPlabel.Text = "Skill Points:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Location = new System.Drawing.Point(108, 77);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(42, 13);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Money:";
            // 
            // moneyNumUpDown
            // 
            this.moneyNumUpDown.DecimalPlaces = 2;
            this.moneyNumUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.moneyNumUpDown.Location = new System.Drawing.Point(156, 75);
            this.moneyNumUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.moneyNumUpDown.Name = "moneyNumUpDown";
            this.moneyNumUpDown.Size = new System.Drawing.Size(114, 20);
            this.moneyNumUpDown.TabIndex = 4;
            this.moneyNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jsonRawTxt
            // 
            this.jsonRawTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jsonRawTxt.Location = new System.Drawing.Point(650, 340);
            this.jsonRawTxt.MaxLength = 999999;
            this.jsonRawTxt.Multiline = true;
            this.jsonRawTxt.Name = "jsonRawTxt";
            this.jsonRawTxt.ReadOnly = true;
            this.jsonRawTxt.Size = new System.Drawing.Size(100, 20);
            this.jsonRawTxt.TabIndex = 5;
            this.jsonRawTxt.Visible = false;
            // 
            // newJsonTxt
            // 
            this.newJsonTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newJsonTxt.Location = new System.Drawing.Point(650, 402);
            this.newJsonTxt.MaxLength = 999999;
            this.newJsonTxt.Multiline = true;
            this.newJsonTxt.Name = "newJsonTxt";
            this.newJsonTxt.Size = new System.Drawing.Size(100, 20);
            this.newJsonTxt.TabIndex = 6;
            this.newJsonTxt.Visible = false;
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.openFileLabel.Location = new System.Drawing.Point(75, 183);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(75, 13);
            this.openFileLabel.TabIndex = 7;
            this.openFileLabel.Text = "Open ZIP File:";
            // 
            // openFileName
            // 
            this.openFileName.AutoSize = true;
            this.openFileName.BackColor = System.Drawing.Color.Transparent;
            this.openFileName.Location = new System.Drawing.Point(148, 183);
            this.openFileName.Name = "openFileName";
            this.openFileName.Size = new System.Drawing.Size(129, 13);
            this.openFileName.TabIndex = 8;
            this.openFileName.Text = "<ZIP File name and path>";
            // 
            // openJsonFileLabel
            // 
            this.openJsonFileLabel.AutoSize = true;
            this.openJsonFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.openJsonFileLabel.Location = new System.Drawing.Point(64, 207);
            this.openJsonFileLabel.Name = "openJsonFileLabel";
            this.openJsonFileLabel.Size = new System.Drawing.Size(86, 13);
            this.openJsonFileLabel.TabIndex = 9;
            this.openJsonFileLabel.Text = "Open JSON File:";
            // 
            // openJsonName
            // 
            this.openJsonName.AutoSize = true;
            this.openJsonName.BackColor = System.Drawing.Color.Transparent;
            this.openJsonName.Location = new System.Drawing.Point(148, 207);
            this.openJsonName.Name = "openJsonName";
            this.openJsonName.Size = new System.Drawing.Size(100, 13);
            this.openJsonName.TabIndex = 10;
            this.openJsonName.Text = "<JSON File NAME>";
            // 
            // hPotLabel
            // 
            this.hPotLabel.AutoSize = true;
            this.hPotLabel.BackColor = System.Drawing.Color.Transparent;
            this.hPotLabel.Location = new System.Drawing.Point(81, 103);
            this.hPotLabel.Name = "hPotLabel";
            this.hPotLabel.Size = new System.Drawing.Size(69, 13);
            this.hPotLabel.TabIndex = 11;
            this.hPotLabel.Text = "Health Items:";
            // 
            // hPotsUpDown
            // 
            this.hPotsUpDown.Location = new System.Drawing.Point(156, 101);
            this.hPotsUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hPotsUpDown.Name = "hPotsUpDown";
            this.hPotsUpDown.Size = new System.Drawing.Size(114, 20);
            this.hPotsUpDown.TabIndex = 12;
            this.hPotsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pPotUpDown
            // 
            this.pPotUpDown.Location = new System.Drawing.Point(156, 127);
            this.pPotUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.pPotUpDown.Name = "pPotUpDown";
            this.pPotUpDown.Size = new System.Drawing.Size(114, 20);
            this.pPotUpDown.TabIndex = 14;
            this.pPotUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pPotlabel
            // 
            this.pPotlabel.AutoSize = true;
            this.pPotlabel.BackColor = System.Drawing.Color.Transparent;
            this.pPotlabel.Location = new System.Drawing.Point(83, 129);
            this.pPotlabel.Name = "pPotlabel";
            this.pPotlabel.Size = new System.Drawing.Size(67, 13);
            this.pPotlabel.TabIndex = 13;
            this.pPotlabel.Text = "Psych Items:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(316, 127);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(316, 75);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(316, 49);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 17;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscoSaveEdit.Properties.Resources.discoBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 259);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pPotUpDown);
            this.Controls.Add(this.pPotlabel);
            this.Controls.Add(this.hPotsUpDown);
            this.Controls.Add(this.hPotLabel);
            this.Controls.Add(this.openJsonName);
            this.Controls.Add(this.openJsonFileLabel);
            this.Controls.Add(this.openFileName);
            this.Controls.Add(this.openFileLabel);
            this.Controls.Add(this.newJsonTxt);
            this.Controls.Add(this.jsonRawTxt);
            this.Controls.Add(this.moneyNumUpDown);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.sPlabel);
            this.Controls.Add(this.sPnumUpDown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Disco Save Edit";
            ((System.ComponentModel.ISupportInitialize)(this.sPnumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hPotsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPotUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown sPnumUpDown;
        private System.Windows.Forms.Label sPlabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.NumericUpDown moneyNumUpDown;
        private System.Windows.Forms.TextBox jsonRawTxt;
        private System.Windows.Forms.TextBox newJsonTxt;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.Label openFileName;
        private System.Windows.Forms.Label openJsonFileLabel;
        private System.Windows.Forms.Label openJsonName;
        private System.Windows.Forms.Label hPotLabel;
        private System.Windows.Forms.NumericUpDown hPotsUpDown;
        private System.Windows.Forms.NumericUpDown pPotUpDown;
        private System.Windows.Forms.Label pPotlabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

