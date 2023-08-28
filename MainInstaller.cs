using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DarknessFallsInstaller {
    public partial class MainInstaller : Form {

        public InstallData Installer;

        public MainInstaller() {
            Installer = new InstallData();
            InitializeComponent();
            gameVersionWarning.Hide();
            SetupBindings();
            GetDefaultFolderLocation();
            gameVersionWarning.Visible = !Installer.IsGameVersionValid;
            installDirTextbox.Hide();
            buttonBrowseSepInstall.Visible = false;
            sepInstallLabel.Visible = false;
            nonEmptyInstallWarningPanel.Hide();
            labelError.Text = string.Format("ERROR\r\nThe game installation you have selected is \r\nincompatible with Darkness Falls. Please select\r\nan install of 7 Days To Die version {0}.\r\n", ConfigurationManager.AppSettings.Get("7D2DVersion"));
        }

        private void SetupBindings() {
            pathBox.DataBindings.Clear();
            pathBox.DataBindings.Add(nameof(TextBox.Text), Installer, nameof(Installer.InstallDir), true, DataSourceUpdateMode.OnPropertyChanged);
            installDirTextbox.DataBindings.Add(nameof(TextBox.Text), Installer, nameof(Installer.NewInstallDir), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void GetDefaultFolderLocation() { 

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 251570", false);

            object value = key.GetValue("InstallLocation");
            if (!string.IsNullOrEmpty(value.ToString())) {
                Installer.InstallDir = value.ToString();
            }
            else {
                Installer.InstallDir = string.Empty;
            }
            key.Dispose();
        }

        private void browseButton_Click(object sender, EventArgs e) {
            string path;
            gameDialog.SelectedPath = pathBox.Text ?? "";
            gameDialog.ShowDialog();
            path = gameDialog.SelectedPath;

            if (!string.IsNullOrEmpty(path)) {
                Installer.InstallDir = path;
            }
            gameVersionWarning.Visible = !Installer.IsGameVersionValid;
        }

        private void nextButton_Click(object sender, EventArgs e) {
            mainInstallPanel.Hide();
        }

        private void okButton_Click(object sender, EventArgs e) {
            gameVersionWarning.Hide();
        }

        private void createInstallCheck_CheckedChanged(object sender, EventArgs e) {
            
            if (createInstallCheck.Checked) {
                installDirTextbox.Show();
                buttonBrowseSepInstall.Visible = true;
                sepInstallLabel.Visible = true;
                Installer.IsNewInstall = true;
            }
            else {
                installDirTextbox.Hide();
                buttonBrowseSepInstall.Visible = false;
                sepInstallLabel.Visible = false;
                Installer.IsNewInstall = false;
            }
        }

        private void buttonBrowseSepInstall_Click(object sender, EventArgs e) {
            string path;
            gameDialog.SelectedPath = pathBox.Text ?? "";
            gameDialog.ShowDialog();
            path = gameDialog.SelectedPath;

            if (!string.IsNullOrEmpty(path)) {
                Installer.NewInstallDir = path;
            }
            nonEmptyInstallWarningPanel.Visible = !Installer.IsNewInstallFolderEmpty();
        }

        private void warningButtonOk_Click(object sender, EventArgs e) {
            nonEmptyInstallWarningPanel.Hide();
        }
    }
}
