﻿namespace DarknessFallsInstaller {
    partial class MainInstaller {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInstaller));
            this.mainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.gameDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gameVersionWarning = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.mainInstallPanel = new System.Windows.Forms.Panel();
            this.nonEmptyInstallWarningPanel = new System.Windows.Forms.Panel();
            this.warningButtonOk = new System.Windows.Forms.Button();
            this.warningNonEmptyInstallDesc = new System.Windows.Forms.Label();
            this.warningNonEmptyInstall = new System.Windows.Forms.Label();
            this.separateInstallDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sepInstallLabel = new System.Windows.Forms.Label();
            this.buttonBrowseSepInstall = new System.Windows.Forms.Button();
            this.installDirTextbox = new System.Windows.Forms.TextBox();
            this.createInstallCheck = new System.Windows.Forms.CheckBox();
            this.mainInstallerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameVersionWarning.SuspendLayout();
            this.mainInstallPanel.SuspendLayout();
            this.nonEmptyInstallWarningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainInstallerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(312, 31);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Select Installation Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "The installer will install Darkness Falls. The installer found a compatible 7D2D " +
    "at the following location. \r\nClick next to install to this folder or browse to s" +
    "elect a different folder.  ";
            // 
            // pathBox
            // 
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.Location = new System.Drawing.Point(16, 121);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(485, 26);
            this.pathBox.TabIndex = 2;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(410, 153);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(91, 29);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(413, 390);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(90, 28);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // gameVersionWarning
            // 
            this.gameVersionWarning.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gameVersionWarning.Controls.Add(this.labelError);
            this.gameVersionWarning.Controls.Add(this.okButton);
            this.gameVersionWarning.Location = new System.Drawing.Point(61, 43);
            this.gameVersionWarning.Name = "gameVersionWarning";
            this.gameVersionWarning.Size = new System.Drawing.Size(379, 161);
            this.gameVersionWarning.TabIndex = 5;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(18, 15);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(341, 80);
            this.labelError.TabIndex = 0;
            this.labelError.Text = "ERROR\r\nThe game installation you have selected is \r\nincompatible with Darkness Fa" +
    "lls. Please select\r\nan install of 7 Days To Die version A21.1.\r\n";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(140, 113);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 30);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // mainInstallPanel
            // 
            this.mainInstallPanel.Controls.Add(this.nonEmptyInstallWarningPanel);
            this.mainInstallPanel.Controls.Add(this.separateInstallDesc);
            this.mainInstallPanel.Controls.Add(this.label2);
            this.mainInstallPanel.Controls.Add(this.sepInstallLabel);
            this.mainInstallPanel.Controls.Add(this.buttonBrowseSepInstall);
            this.mainInstallPanel.Controls.Add(this.installDirTextbox);
            this.mainInstallPanel.Controls.Add(this.createInstallCheck);
            this.mainInstallPanel.Controls.Add(this.gameVersionWarning);
            this.mainInstallPanel.Controls.Add(this.browseButton);
            this.mainInstallPanel.Controls.Add(this.pathBox);
            this.mainInstallPanel.Controls.Add(this.label1);
            this.mainInstallPanel.Controls.Add(this.mainLabel);
            this.mainInstallPanel.Location = new System.Drawing.Point(0, 0);
            this.mainInstallPanel.Name = "mainInstallPanel";
            this.mainInstallPanel.Size = new System.Drawing.Size(542, 372);
            this.mainInstallPanel.TabIndex = 6;
            // 
            // nonEmptyInstallWarningPanel
            // 
            this.nonEmptyInstallWarningPanel.Controls.Add(this.warningButtonOk);
            this.nonEmptyInstallWarningPanel.Controls.Add(this.warningNonEmptyInstallDesc);
            this.nonEmptyInstallWarningPanel.Controls.Add(this.warningNonEmptyInstall);
            this.nonEmptyInstallWarningPanel.Location = new System.Drawing.Point(61, 39);
            this.nonEmptyInstallWarningPanel.Name = "nonEmptyInstallWarningPanel";
            this.nonEmptyInstallWarningPanel.Size = new System.Drawing.Size(379, 165);
            this.nonEmptyInstallWarningPanel.TabIndex = 7;
            // 
            // warningButtonOk
            // 
            this.warningButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningButtonOk.Location = new System.Drawing.Point(151, 115);
            this.warningButtonOk.Name = "warningButtonOk";
            this.warningButtonOk.Size = new System.Drawing.Size(75, 28);
            this.warningButtonOk.TabIndex = 2;
            this.warningButtonOk.Text = "Ok";
            this.warningButtonOk.UseVisualStyleBackColor = true;
            this.warningButtonOk.Click += new System.EventHandler(this.warningButtonOk_Click);
            // 
            // warningNonEmptyInstallDesc
            // 
            this.warningNonEmptyInstallDesc.AutoSize = true;
            this.warningNonEmptyInstallDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningNonEmptyInstallDesc.Location = new System.Drawing.Point(37, 36);
            this.warningNonEmptyInstallDesc.Name = "warningNonEmptyInstallDesc";
            this.warningNonEmptyInstallDesc.Size = new System.Drawing.Size(322, 60);
            this.warningNonEmptyInstallDesc.TabIndex = 1;
            this.warningNonEmptyInstallDesc.Text = resources.GetString("warningNonEmptyInstallDesc.Text");
            // 
            // warningNonEmptyInstall
            // 
            this.warningNonEmptyInstall.AutoSize = true;
            this.warningNonEmptyInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningNonEmptyInstall.Location = new System.Drawing.Point(134, 5);
            this.warningNonEmptyInstall.Name = "warningNonEmptyInstall";
            this.warningNonEmptyInstall.Size = new System.Drawing.Size(114, 31);
            this.warningNonEmptyInstall.TabIndex = 0;
            this.warningNonEmptyInstall.Text = "Warning";
            // 
            // separateInstallDesc
            // 
            this.separateInstallDesc.AutoSize = true;
            this.separateInstallDesc.Location = new System.Drawing.Point(17, 231);
            this.separateInstallDesc.Name = "separateInstallDesc";
            this.separateInstallDesc.Size = new System.Drawing.Size(445, 26);
            this.separateInstallDesc.TabIndex = 11;
            this.separateInstallDesc.Text = "A separate install will create a copy of the game files using the location above " +
    "and then install\r\nthe Darkness Falls files into this copy.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Create a separate game install?";
            // 
            // sepInstallLabel
            // 
            this.sepInstallLabel.AutoSize = true;
            this.sepInstallLabel.Location = new System.Drawing.Point(16, 290);
            this.sepInstallLabel.Name = "sepInstallLabel";
            this.sepInstallLabel.Size = new System.Drawing.Size(237, 13);
            this.sepInstallLabel.TabIndex = 9;
            this.sepInstallLabel.Text = "Select the location to create a separate install at.";
            // 
            // buttonBrowseSepInstall
            // 
            this.buttonBrowseSepInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseSepInstall.Location = new System.Drawing.Point(411, 338);
            this.buttonBrowseSepInstall.Name = "buttonBrowseSepInstall";
            this.buttonBrowseSepInstall.Size = new System.Drawing.Size(91, 29);
            this.buttonBrowseSepInstall.TabIndex = 8;
            this.buttonBrowseSepInstall.Text = "Browse";
            this.buttonBrowseSepInstall.UseVisualStyleBackColor = true;
            this.buttonBrowseSepInstall.Click += new System.EventHandler(this.buttonBrowseSepInstall_Click);
            // 
            // installDirTextbox
            // 
            this.installDirTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installDirTextbox.Location = new System.Drawing.Point(18, 306);
            this.installDirTextbox.Name = "installDirTextbox";
            this.installDirTextbox.Size = new System.Drawing.Size(485, 26);
            this.installDirTextbox.TabIndex = 7;
            // 
            // createInstallCheck
            // 
            this.createInstallCheck.AutoSize = true;
            this.createInstallCheck.Location = new System.Drawing.Point(19, 270);
            this.createInstallCheck.Name = "createInstallCheck";
            this.createInstallCheck.Size = new System.Drawing.Size(133, 17);
            this.createInstallCheck.TabIndex = 6;
            this.createInstallCheck.Text = "Create Separate Install";
            this.createInstallCheck.UseVisualStyleBackColor = true;
            this.createInstallCheck.CheckedChanged += new System.EventHandler(this.createInstallCheck_CheckedChanged);
            // 
            // mainInstallerBindingSource
            // 
            this.mainInstallerBindingSource.DataSource = typeof(DarknessFallsInstaller.MainInstaller);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DarknessFallsInstaller.Program);
            // 
            // MainInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 430);
            this.Controls.Add(this.mainInstallPanel);
            this.Controls.Add(this.nextButton);
            this.Name = "MainInstaller";
            this.Text = "Install Darkness Falls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameVersionWarning.ResumeLayout(false);
            this.gameVersionWarning.PerformLayout();
            this.mainInstallPanel.ResumeLayout(false);
            this.mainInstallPanel.PerformLayout();
            this.nonEmptyInstallWarningPanel.ResumeLayout(false);
            this.nonEmptyInstallWarningPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainInstallerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.BindingSource mainInstallerBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FolderBrowserDialog gameDialog;
        private System.Windows.Forms.Panel gameVersionWarning;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel mainInstallPanel;
        private System.Windows.Forms.Button buttonBrowseSepInstall;
        private System.Windows.Forms.TextBox installDirTextbox;
        private System.Windows.Forms.CheckBox createInstallCheck;
        private System.Windows.Forms.Label separateInstallDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sepInstallLabel;
        private System.Windows.Forms.Panel nonEmptyInstallWarningPanel;
        private System.Windows.Forms.Button warningButtonOk;
        private System.Windows.Forms.Label warningNonEmptyInstallDesc;
        private System.Windows.Forms.Label warningNonEmptyInstall;
    }
}
