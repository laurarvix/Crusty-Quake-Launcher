﻿namespace Doom_Loader
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            rcpBox = new CheckBox();
            closeBox = new CheckBox();
            button1 = new Button();
            openPresetsLocation = new Button();
            topMostBox = new CheckBox();
            defaultBox = new CheckBox();
            customPresetBox = new CheckBox();
            label1 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            toolTips = new ToolTip(components);
            button3 = new Button();
            iwadFolderDialog = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rcpBox
            // 
            rcpBox.AutoSize = true;
            rcpBox.Checked = true;
            rcpBox.CheckState = CheckState.Checked;
            rcpBox.Location = new Point(208, 101);
            rcpBox.Name = "rcpBox";
            rcpBox.Size = new Size(142, 19);
            rcpBox.TabIndex = 0;
            rcpBox.Text = "Discord Rich Presence";
            rcpBox.UseVisualStyleBackColor = true;
            rcpBox.CheckedChanged += rcpBox_CheckedChanged;
            // 
            // closeBox
            // 
            closeBox.AutoSize = true;
            closeBox.BackColor = SystemColors.Control;
            closeBox.Location = new Point(6, 22);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(97, 19);
            closeBox.TabIndex = 1;
            closeBox.Text = "Close on Play";
            closeBox.UseVisualStyleBackColor = false;
            closeBox.CheckedChanged += closeBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(333, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openPresetsLocation
            // 
            openPresetsLocation.Location = new Point(6, 47);
            openPresetsLocation.Name = "openPresetsLocation";
            openPresetsLocation.Size = new Size(147, 23);
            openPresetsLocation.TabIndex = 3;
            openPresetsLocation.Text = "Open AppData Presets";
            openPresetsLocation.UseVisualStyleBackColor = true;
            openPresetsLocation.Click += ShowPresets;
            // 
            // topMostBox
            // 
            topMostBox.AutoSize = true;
            topMostBox.Location = new Point(6, 47);
            topMostBox.Name = "topMostBox";
            topMostBox.Size = new Size(157, 19);
            topMostBox.TabIndex = 4;
            topMostBox.Text = "Show Window After Quit";
            topMostBox.UseVisualStyleBackColor = true;
            topMostBox.CheckedChanged += topMostBox_CheckedChanged;
            // 
            // defaultBox
            // 
            defaultBox.AutoSize = true;
            defaultBox.Location = new Point(6, 22);
            defaultBox.Name = "defaultBox";
            defaultBox.Size = new Size(175, 19);
            defaultBox.TabIndex = 5;
            defaultBox.Text = "[*] Load \"Default\" on launch";
            defaultBox.UseVisualStyleBackColor = true;
            defaultBox.CheckedChanged += defaultBox_CheckedChanged;
            // 
            // customPresetBox
            // 
            customPresetBox.AutoSize = true;
            customPresetBox.Location = new Point(6, 22);
            customPresetBox.Name = "customPresetBox";
            customPresetBox.Size = new Size(165, 19);
            customPresetBox.TabIndex = 6;
            customPresetBox.Text = "[*] Ask For Preset Location";
            customPresetBox.UseVisualStyleBackColor = true;
            customPresetBox.CheckedChanged += customPresetBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 206);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 7;
            label1.Text = "[*] = Restart Needed";
            // 
            // button2
            // 
            button2.Location = new Point(6, 47);
            button2.Name = "button2";
            button2.Size = new Size(136, 30);
            button2.TabIndex = 8;
            button2.Text = "Make Settings Portable";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customPresetBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 87);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Portability";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(openPresetsLocation);
            groupBox2.Controls.Add(defaultBox);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 83);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Presets";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(closeBox);
            groupBox3.Controls.Add(topMostBox);
            groupBox3.Location = new Point(208, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 77);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Window";
            // 
            // button3
            // 
            button3.Location = new Point(208, 126);
            button3.Name = "button3";
            button3.Size = new Size(142, 23);
            button3.TabIndex = 12;
            button3.Text = "Set IWADs Folder";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 233);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(rcpBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += Settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox rcpBox;
        private CheckBox closeBox;
        private Button button1;
        private Button openPresetsLocation;
        private CheckBox topMostBox;
        private CheckBox defaultBox;
        private CheckBox customPresetBox;
        private Label label1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ToolTip toolTips;
        private Button button3;
        private FolderBrowserDialog iwadFolderDialog;
    }
}