using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarknessFallsInstaller {
    public partial class MainInstaller : Form {

        public InstallData Installer;
        private TaskCompletionSource<bool> TaskCompletionSource;

        public MainInstaller() {
            Installer = new InstallData();
            TaskCompletionSource = new TaskCompletionSource<bool>();
            InitializeComponent();
            CenterToScreen();
            gameVersionWarning.Hide();
            SetupBindings();
            GetDefaultFolderLocation();
            gameVersionWarning.Visible = !Installer.IsGameVersionValid;
            installDirTextbox.Hide();
            buttonBrowseSepInstall.Visible = false;
            sepInstallLabel.Visible = false;
            nonEmptyInstallWarningPanel.Hide();
            existingModsFolderLabel.Hide();
            labelError.Text = string.Format("ERROR\r\nThe game installation you have selected is \r\nincompatible with Darkness Falls. Please select\r\nan install of 7 Days To Die version {0}.\r\n", ConfigurationManager.AppSettings.Get("7D2DVersion"));
            installerProgressPanel.Hide();
            appdataModsWarningPanel.Hide();
            installFinishedPanel.Hide();
            closeButton.Hide();
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
            if (!gameVersionWarning.Visible) {
                existingModsFolderLabel.Visible = Installer.CheckForPreviousMods();
            }
        }

        private void createInstallCheck_CheckedChanged(object sender, EventArgs e) {

            if (createInstallCheck.Checked) {
                installDirTextbox.Show();
                buttonBrowseSepInstall.Visible = true;
                sepInstallLabel.Visible = true;
            }
            else {
                installDirTextbox.Hide();
                buttonBrowseSepInstall.Visible = false;
                sepInstallLabel.Visible = false;
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

        private async void nextButton_Click(object sender, EventArgs e) {
            gameVersionWarning.Visible = !Installer.IsGameVersionValid;
            if (gameVersionWarning.Visible) {
                return;
            }
            mainInstallPanel.Hide();
            installerProgressPanel.Show();
            var progress = new Progress<int>(v => {
                installProgressBar.Value = v;
            });

            var progressString = new Progress<string>(v => {
                workingFileLabel.Text = v;
            });

            nextButton.Enabled = false;

            bool appdataMods = Installer.DoesAppdataHaveMods();
            if (appdataMods) {
                appdataModsWarningPanel.Show();
                await TaskCompletionSource.Task;
            }

            if (createInstallCheck.Checked) {
                await Task.Run(() => {

                    stepLabel.Invoke((MethodInvoker)delegate {
                        stepLabel.Text = "Cleaning install folder.";
                    });

                    Installer.CleanInstallFolder(progressString);
                    installProgressBar.Invoke((MethodInvoker)delegate {
                        installProgressBar.Value = 0;
                    });

                    stepLabel.Invoke((MethodInvoker)delegate {
                        stepLabel.Text = "Copying game files.";
                    });

                    actionLabel.Invoke((MethodInvoker)delegate {
                        actionLabel.Text = "Copying ";
                    });

                    Installer.CloneBaseGame(progress, progressString);
                    installProgressBar.Invoke((MethodInvoker)delegate {
                        installProgressBar.Value = 0;
                    });

                    stepLabel.Invoke((MethodInvoker)delegate {
                        stepLabel.Text = "Installing Darkness Falls files.";
                    });

                    Installer.InstallModFiles(progress, progressString, Installer.NewInstallDir);
                });
                FinishUp(Installer.NewInstallDir);
            }
            else {
                await Task.Run(() => {

                    stepLabel.Invoke((MethodInvoker)delegate {
                        stepLabel.Text = "Cleaning existing mods folder.";
                    });

                    if (Installer.CheckForPreviousMods()) {
                        actionLabel.Invoke((MethodInvoker)delegate {
                            actionLabel.Text = "Deleting ";
                        });
                        Installer.RemoveExistingMods(progressString);
                    }

                    actionLabel.Invoke((MethodInvoker)delegate {
                        actionLabel.Text = "Copying ";
                    });

                    installProgressBar.Invoke((MethodInvoker)delegate {
                        installProgressBar.Value = 0;
                    });

                    stepLabel.Invoke((MethodInvoker)delegate {
                        stepLabel.Text = "Installing Darkness Falls files.";
                    });

                    Installer.InstallModFiles(progress, progressString, Installer.InstallDir);
                });
                FinishUp(Installer.InstallDir);
            }
        }

        private void okButton_Click(object sender, EventArgs e) {
            gameVersionWarning.Hide();
        }

        private void existingModsButtonOk_Click(object sender, EventArgs e) {
            existingModsFolderLabel.Hide();
        }

        private void existingModsFolderLabel_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, this.existingModsFolderLabel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private async void appdataModsWarningButtonYes_Click(object sender, EventArgs e) {
            appdataModsWarningPanel.Hide();
            TaskCompletionSource.SetResult(false);
            await Installer.CleanAppdataModsFolder();
        }

        private void appdataModsWarningButtonNo_Click(object sender, EventArgs e) {
            appdataModsWarningPanel.Hide();
            TaskCompletionSource.SetResult(false);
        }

        private void appdataModsWarningPanel_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, this.existingModsFolderLabel.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void FinishUp(string location) {
            installerProgressPanel.Hide();
            installFinishedPanel.Show();
            nextButton.Hide();
            closeButton.Show();
            CreateShortcut("Darkness Falls", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), location + "\\7DaysToDie.exe", location);
        }

        private static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string iconpath) {
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = "7D2D Darkness Falls";
            shortcut.IconLocation = iconpath + ".\\darknessfalls.ico"; 
            shortcut.TargetPath = targetFileLocation;
            shortcut.WorkingDirectory = iconpath;
            shortcut.Arguments = "-noeac";
            shortcut.Save();     
        }
    }
}
