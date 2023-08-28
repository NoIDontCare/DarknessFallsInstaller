using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using Label = System.Windows.Forms.Label;

namespace DarknessFallsInstaller {
    public class InstallData : INotifyPropertyChanged {

        static List<string> allowedMods = new List<string>() {
            "TFP_CommandExtensions", "TFP_MapRendering", "TFP_WebServer", "Xample_MarkersMod"
        };

        static string modFiles = ".\\ModFiles";

        public string InstallDir { get => _installDir; set { _installDir = value; OnPropertyChanged("InstallDir"); IsGameVersionCorrect(); } }
        public bool IsComplete { get; set; }
        public bool IsNewInstall { get; set; }

        public string WorkingFile { get => _workingFile; set { _workingFile = value; OnPropertyChanged("WorkingFile"); } }

        public string NewInstallDir { get => _newInstallDir; set { _newInstallDir = value; OnPropertyChanged("NewInstallDir"); } }

        public bool IsGameVersionValid { get => _isGameVersionCorrect; set { _isGameVersionCorrect = value; OnPropertyChanged("IsGameVersionValid"); } }

        private string _installDir;
        private string _newInstallDir;
        private bool _isGameVersionCorrect;
        private string _workingFile;

        public InstallData(string installDir = "", bool isComplete = false, bool isNewInstall = false) {
            InstallDir = installDir;
            IsComplete = isComplete;
            IsNewInstall = isNewInstall;
            IsGameVersionValid = false;
            WorkingFile = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool CheckForPreviousMods() {
            return Directory.Exists(InstallDir + "\\Mods");
        }

        public void RemoveExistingMods() {

            foreach (var subDir in new DirectoryInfo(InstallDir).GetDirectories()) {
                if (!allowedMods.Contains(subDir.Name)) {
                    subDir.Delete(true);
                }
            }
        }

        public bool IsNewInstallFolderEmpty() {

            var files = new DirectoryInfo(NewInstallDir).GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).FirstOrDefault();
            return files == null;
        }

        public void CleanInstallFolder(IProgress<string> workingFile) {
            DirectoryInfo directory = new DirectoryInfo(NewInstallDir);

            foreach (FileInfo file in directory.GetFiles()) {
                workingFile.Report(file.Name);
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.GetDirectories()) {
                workingFile.Report(dir.Name);
                dir.Delete(true);
            }
        }

        public void CloneBaseGame(IProgress<int> progress, IProgress<string> workingFile) {

            int i = 0;
            int total = Directory.GetFiles(InstallDir, "*.*", SearchOption.AllDirectories).Length;

            foreach (string dirPath in Directory.GetDirectories(InstallDir, "*", SearchOption.AllDirectories)) {
                //if (dirPath.Substring(dirPath.Length - 4, 4).Equals("Mods")) continue;
                
                if (Path.GetDirectoryName(dirPath) == InstallDir + "\\Mods") continue;

                Directory.CreateDirectory(dirPath.Replace(InstallDir, NewInstallDir));
            }

            foreach (string newPath in Directory.GetFiles(InstallDir, "*.*", SearchOption.AllDirectories)) {
                if (Path.GetDirectoryName(newPath) == "Mods") continue;
                workingFile.Report(newPath);
                File.Copy(newPath, newPath.Replace(InstallDir, NewInstallDir), true);
                progress.Report((i + 1) * 100 / total);
                i++;
            }
        }

        public void InstallModFiles(IProgress<int> progress, IProgress<string> workingFile) {

            int i = 0;
            int total = Directory.GetFiles(modFiles, "*.*", SearchOption.AllDirectories).Length;

            foreach (string dirPath in Directory.GetDirectories(modFiles, "*", SearchOption.AllDirectories)) {
                Directory.CreateDirectory(dirPath.Replace(modFiles, NewInstallDir));
            }

            foreach (string newPath in Directory.GetFiles(modFiles, "*.*", SearchOption.AllDirectories)) {
                
                workingFile.Report(newPath);
                File.Copy(newPath, newPath.Replace(modFiles, NewInstallDir), true);
                progress.Report((i + 1) * 100 / total);
                i++;
            }
        }

        private void IsGameVersionCorrect() {

            if (string.IsNullOrEmpty(InstallDir)) { IsGameVersionValid = false; return; }

            string configPath = InstallDir + "\\MicrosoftGame.Config";
            if (string.IsNullOrEmpty(configPath)) { IsGameVersionValid = false; return; }

            try {
                XDocument doc = XDocument.Load(configPath);

                XElement identity = doc.Element("Game").Element("Identity");
                if (identity == null) { IsGameVersionValid = false; return; }
                XAttribute version = identity.Attribute("Version");
                if (version == null) { IsGameVersionValid = false; return; }
                if (version.Value != ConfigurationManager.AppSettings.Get("7D2DVersionString")) { IsGameVersionValid = false; return; }

                IsGameVersionValid = true;
            }
            catch (FileNotFoundException e) {
                // Really don't care here. Just want to prevent the program from breaking.
            }
        }
    }
}
