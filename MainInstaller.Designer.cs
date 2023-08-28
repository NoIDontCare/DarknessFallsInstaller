namespace DarknessFallsInstaller {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInstaller));
            this.mainLabel = new System.Windows.Forms.Label();
            this.installDesc = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.gameDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gameVersionWarning = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.mainInstallPanel = new System.Windows.Forms.Panel();
            this.existingModsFolderLabel = new System.Windows.Forms.Panel();
            this.existingModsButtonOk = new System.Windows.Forms.Button();
            this.existingModsWarningDesc = new System.Windows.Forms.Label();
            this.warningExistingMods = new System.Windows.Forms.Label();
            this.nonEmptyInstallWarningPanel = new System.Windows.Forms.Panel();
            this.warningButtonOk = new System.Windows.Forms.Button();
            this.warningNonEmptyInstallDesc = new System.Windows.Forms.Label();
            this.warningNonEmptyInstall = new System.Windows.Forms.Label();
            this.separateInstallDesc = new System.Windows.Forms.Label();
            this.separateInstallLabel = new System.Windows.Forms.Label();
            this.sepInstallLabel = new System.Windows.Forms.Label();
            this.buttonBrowseSepInstall = new System.Windows.Forms.Button();
            this.installDirTextbox = new System.Windows.Forms.TextBox();
            this.createInstallCheck = new System.Windows.Forms.CheckBox();
            this.installerProgressPanel = new System.Windows.Forms.Panel();
            this.workingFileLabel = new System.Windows.Forms.Label();
            this.stepLabel = new System.Windows.Forms.Label();
            this.installingDFLabel = new System.Windows.Forms.Label();
            this.installProgressBar = new System.Windows.Forms.ProgressBar();
            this.actionLabel = new System.Windows.Forms.Label();
            this.installingDesc = new System.Windows.Forms.Label();
            this.gameVersionWarning.SuspendLayout();
            this.mainInstallPanel.SuspendLayout();
            this.existingModsFolderLabel.SuspendLayout();
            this.nonEmptyInstallWarningPanel.SuspendLayout();
            this.installerProgressPanel.SuspendLayout();
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
            // installDesc
            // 
            this.installDesc.AutoSize = true;
            this.installDesc.Location = new System.Drawing.Point(13, 69);
            this.installDesc.Name = "installDesc";
            this.installDesc.Size = new System.Drawing.Size(489, 26);
            this.installDesc.TabIndex = 1;
            this.installDesc.Text = "The installer will install Darkness Falls. The installer found a compatible 7D2D " +
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
            this.mainInstallPanel.Controls.Add(this.gameVersionWarning);
            this.mainInstallPanel.Controls.Add(this.existingModsFolderLabel);
            this.mainInstallPanel.Controls.Add(this.nonEmptyInstallWarningPanel);
            this.mainInstallPanel.Controls.Add(this.separateInstallDesc);
            this.mainInstallPanel.Controls.Add(this.separateInstallLabel);
            this.mainInstallPanel.Controls.Add(this.sepInstallLabel);
            this.mainInstallPanel.Controls.Add(this.buttonBrowseSepInstall);
            this.mainInstallPanel.Controls.Add(this.installDirTextbox);
            this.mainInstallPanel.Controls.Add(this.createInstallCheck);
            this.mainInstallPanel.Controls.Add(this.browseButton);
            this.mainInstallPanel.Controls.Add(this.pathBox);
            this.mainInstallPanel.Controls.Add(this.installDesc);
            this.mainInstallPanel.Controls.Add(this.mainLabel);
            this.mainInstallPanel.Location = new System.Drawing.Point(0, 0);
            this.mainInstallPanel.Name = "mainInstallPanel";
            this.mainInstallPanel.Size = new System.Drawing.Size(649, 372);
            this.mainInstallPanel.TabIndex = 6;
            // 
            // existingModsFolderLabel
            // 
            this.existingModsFolderLabel.Controls.Add(this.existingModsButtonOk);
            this.existingModsFolderLabel.Controls.Add(this.existingModsWarningDesc);
            this.existingModsFolderLabel.Controls.Add(this.warningExistingMods);
            this.existingModsFolderLabel.Location = new System.Drawing.Point(61, 35);
            this.existingModsFolderLabel.Name = "existingModsFolderLabel";
            this.existingModsFolderLabel.Size = new System.Drawing.Size(379, 169);
            this.existingModsFolderLabel.TabIndex = 8;
            // 
            // existingModsButtonOk
            // 
            this.existingModsButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingModsButtonOk.Location = new System.Drawing.Point(151, 119);
            this.existingModsButtonOk.Name = "existingModsButtonOk";
            this.existingModsButtonOk.Size = new System.Drawing.Size(75, 28);
            this.existingModsButtonOk.TabIndex = 2;
            this.existingModsButtonOk.Text = "Ok";
            this.existingModsButtonOk.UseVisualStyleBackColor = true;
            this.existingModsButtonOk.Click += new System.EventHandler(this.existingModsButtonOk_Click);
            // 
            // existingModsWarningDesc
            // 
            this.existingModsWarningDesc.AutoSize = true;
            this.existingModsWarningDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingModsWarningDesc.Location = new System.Drawing.Point(3, 45);
            this.existingModsWarningDesc.Name = "existingModsWarningDesc";
            this.existingModsWarningDesc.Size = new System.Drawing.Size(376, 51);
            this.existingModsWarningDesc.TabIndex = 1;
            this.existingModsWarningDesc.Text = "An existing mods folder was found in this game install.\r\nIf you do not choose to " +
    "create a separate install, this mods\r\nfolder will be removed before Darkness Fal" +
    "ls is installed.";
            // 
            // warningExistingMods
            // 
            this.warningExistingMods.AutoSize = true;
            this.warningExistingMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningExistingMods.Location = new System.Drawing.Point(134, 9);
            this.warningExistingMods.Name = "warningExistingMods";
            this.warningExistingMods.Size = new System.Drawing.Size(114, 31);
            this.warningExistingMods.TabIndex = 0;
            this.warningExistingMods.Text = "Warning";
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
            // separateInstallLabel
            // 
            this.separateInstallLabel.AutoSize = true;
            this.separateInstallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separateInstallLabel.Location = new System.Drawing.Point(13, 202);
            this.separateInstallLabel.Name = "separateInstallLabel";
            this.separateInstallLabel.Size = new System.Drawing.Size(287, 25);
            this.separateInstallLabel.TabIndex = 10;
            this.separateInstallLabel.Text = "Create a separate game install?";
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
            // installerProgressPanel
            // 
            this.installerProgressPanel.Controls.Add(this.installingDesc);
            this.installerProgressPanel.Controls.Add(this.actionLabel);
            this.installerProgressPanel.Controls.Add(this.workingFileLabel);
            this.installerProgressPanel.Controls.Add(this.stepLabel);
            this.installerProgressPanel.Controls.Add(this.installingDFLabel);
            this.installerProgressPanel.Controls.Add(this.installProgressBar);
            this.installerProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.installerProgressPanel.Name = "installerProgressPanel";
            this.installerProgressPanel.Size = new System.Drawing.Size(649, 366);
            this.installerProgressPanel.TabIndex = 7;
            // 
            // workingFileLabel
            // 
            this.workingFileLabel.AutoSize = true;
            this.workingFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingFileLabel.Location = new System.Drawing.Point(80, 240);
            this.workingFileLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.workingFileLabel.Name = "workingFileLabel";
            this.workingFileLabel.Size = new System.Drawing.Size(46, 17);
            this.workingFileLabel.TabIndex = 3;
            this.workingFileLabel.Text = "label1";
            this.workingFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.Location = new System.Drawing.Point(303, 166);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(51, 20);
            this.stepLabel.TabIndex = 2;
            this.stepLabel.Text = "label1";
            this.stepLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installingDFLabel
            // 
            this.installingDFLabel.AutoSize = true;
            this.installingDFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installingDFLabel.Location = new System.Drawing.Point(17, 10);
            this.installingDFLabel.Name = "installingDFLabel";
            this.installingDFLabel.Size = new System.Drawing.Size(310, 31);
            this.installingDFLabel.TabIndex = 1;
            this.installingDFLabel.Text = "Installing Darkness Falls";
            // 
            // installProgressBar
            // 
            this.installProgressBar.Location = new System.Drawing.Point(52, 202);
            this.installProgressBar.Name = "installProgressBar";
            this.installProgressBar.Size = new System.Drawing.Size(541, 23);
            this.installProgressBar.Step = 1;
            this.installProgressBar.TabIndex = 0;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.Location = new System.Drawing.Point(15, 240);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(60, 17);
            this.actionLabel.TabIndex = 4;
            this.actionLabel.Text = "Deleting";
            // 
            // installingDesc
            // 
            this.installingDesc.AutoSize = true;
            this.installingDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installingDesc.Location = new System.Drawing.Point(20, 51);
            this.installingDesc.Name = "installingDesc";
            this.installingDesc.Size = new System.Drawing.Size(504, 36);
            this.installingDesc.TabIndex = 5;
            this.installingDesc.Text = "Darkness Falls is being installed. This process may take a while. New game\r\ninsta" +
    "llations will take longer.";
            // 
            // MainInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.mainInstallPanel);
            this.Controls.Add(this.installerProgressPanel);
            this.Controls.Add(this.nextButton);
            this.Name = "MainInstaller";
            this.Text = "Install Darkness Falls";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameVersionWarning.ResumeLayout(false);
            this.gameVersionWarning.PerformLayout();
            this.mainInstallPanel.ResumeLayout(false);
            this.mainInstallPanel.PerformLayout();
            this.existingModsFolderLabel.ResumeLayout(false);
            this.existingModsFolderLabel.PerformLayout();
            this.nonEmptyInstallWarningPanel.ResumeLayout(false);
            this.nonEmptyInstallWarningPanel.PerformLayout();
            this.installerProgressPanel.ResumeLayout(false);
            this.installerProgressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label installDesc;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.FolderBrowserDialog gameDialog;
        private System.Windows.Forms.Panel gameVersionWarning;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel mainInstallPanel;
        private System.Windows.Forms.Button buttonBrowseSepInstall;
        private System.Windows.Forms.TextBox installDirTextbox;
        private System.Windows.Forms.CheckBox createInstallCheck;
        private System.Windows.Forms.Label separateInstallDesc;
        private System.Windows.Forms.Label separateInstallLabel;
        private System.Windows.Forms.Label sepInstallLabel;
        private System.Windows.Forms.Panel nonEmptyInstallWarningPanel;
        private System.Windows.Forms.Button warningButtonOk;
        private System.Windows.Forms.Label warningNonEmptyInstallDesc;
        private System.Windows.Forms.Label warningNonEmptyInstall;
        private System.Windows.Forms.Panel existingModsFolderLabel;
        private System.Windows.Forms.Label existingModsWarningDesc;
        private System.Windows.Forms.Label warningExistingMods;
        private System.Windows.Forms.Button existingModsButtonOk;
        private System.Windows.Forms.Panel installerProgressPanel;
        private System.Windows.Forms.Label installingDFLabel;
        private System.Windows.Forms.ProgressBar installProgressBar;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.Label workingFileLabel;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label installingDesc;
    }
}

