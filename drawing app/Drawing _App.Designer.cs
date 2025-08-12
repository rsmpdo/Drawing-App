using System;

namespace Drawing_App
{
    partial class Drawing_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing_App));
            this.topPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redoButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.PictureBox();
            this.borderWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.boderColorButton = new System.Windows.Forms.Button();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.drawingPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.topPanel.Controls.Add(this.statusLabel);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Controls.Add(this.appName);
            this.topPanel.Controls.Add(this.appIcon);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.topPanel.Name = "topPanel";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            this.statusLabel.MouseEnter += new System.EventHandler(this.statusLabel_MouseEnter);
            this.statusLabel.MouseLeave += new System.EventHandler(this.statusLabel_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.redoButton);
            this.panel1.Controls.Add(this.undoButton);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // redoButton
            // 
            this.redoButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.redoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.redoButton, "redoButton");
            this.redoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redoButton.Name = "redoButton";
            this.redoButton.UseVisualStyleBackColor = false;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.undoButton, "undoButton");
            this.undoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.undoButton.Name = "undoButton";
            this.undoButton.UseVisualStyleBackColor = false;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // appName
            // 
            resources.ApplyResources(this.appName, "appName");
            this.appName.BackColor = System.Drawing.Color.Black;
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Name = "appName";
            this.appName.Click += new System.EventHandler(this.label1_Click);
            // 
            // appIcon
            // 
            this.appIcon.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.appIcon, "appIcon");
            this.appIcon.Name = "appIcon";
            this.appIcon.TabStop = false;
            this.appIcon.Click += new System.EventHandler(this.appIcon_Click);
            this.appIcon.MouseEnter += new System.EventHandler(this.appIcon_MouseEnter_1);
            this.appIcon.MouseLeave += new System.EventHandler(this.appIcon_MouseLeave_1);
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingPanel.Controls.Add(this.rightPanel);
            this.drawingPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            resources.ApplyResources(this.drawingPanel, "drawingPanel");
            this.drawingPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint_1);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown_1);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove_1);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp_1);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rightPanel.Controls.Add(this.Help);
            this.rightPanel.Controls.Add(this.borderWidthUpDown);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.boderColorButton);
            this.rightPanel.Controls.Add(this.borderColorLabel);
            this.rightPanel.Controls.Add(this.FillColorButton);
            this.rightPanel.Controls.Add(this.pictureBox1);
            this.rightPanel.Controls.Add(this.shapeComboBox);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.rightPanel, "rightPanel");
            this.rightPanel.Name = "rightPanel";
            // 
            // Help
            // 
            resources.ApplyResources(this.Help, "Help");
            this.Help.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Help.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.Name = "Help";
            this.Help.TabStop = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseEnter += new System.EventHandler(this.Help_MouseEnter);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            // 
            // borderWidthUpDown
            // 
            resources.ApplyResources(this.borderWidthUpDown, "borderWidthUpDown");
            this.borderWidthUpDown.Name = "borderWidthUpDown";
            this.borderWidthUpDown.ValueChanged += new System.EventHandler(this.borderWidthUpDown_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boderColorButton
            // 
            resources.ApplyResources(this.boderColorButton, "boderColorButton");
            this.boderColorButton.Name = "boderColorButton";
            this.boderColorButton.UseVisualStyleBackColor = true;
            this.boderColorButton.Click += new System.EventHandler(this.boderColorButton_Click);
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.borderColorLabel, "borderColorLabel");
            this.borderColorLabel.Name = "borderColorLabel";
            // 
            // FillColorButton
            // 
            resources.ApplyResources(this.FillColorButton, "FillColorButton");
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.UseVisualStyleBackColor = true;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // shapeComboBox
            // 
            this.shapeComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.shapeComboBox, "shapeComboBox");
            this.shapeComboBox.FormattingEnabled = true;
            this.shapeComboBox.Items.AddRange(new object[] {
            resources.GetString("shapeComboBox.Items"),
            resources.GetString("shapeComboBox.Items1")});
            this.shapeComboBox.Name = "shapeComboBox";
            this.shapeComboBox.SelectedIndexChanged += new System.EventHandler(this.shapeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Drawing_App
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Drawing_App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.drawingPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox shapeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label borderColorLabel;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boderColorButton;
        private System.Windows.Forms.NumericUpDown borderWidthUpDown;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox Help;

        //public EventHandler label2_Click { get; private set; }
    }
}

