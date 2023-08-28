using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DarknessFallsInstaller {
    public class InstallData : INotifyPropertyChanged {

        public string InstallDir { get => _installDir; set { _installDir = value; OnPropertyChanged("InstallDir"); IsGameVersionCorrect(); } }
        public bool IsComplete { get; set; }
        public bool IsNewInstall { get; set; }

        public string NewInstallDir { get => _newInstallDir; set { _newInstallDir = value; OnPropertyChanged("NewInstallDir"); } }

        public bool IsGameVersionValid { get => _isGameVersionCorrect; set { _isGameVersionCorrect = value; OnPropertyChanged("IsGameVersionValid"); } }

        private string _installDir;
        private string _newInstallDir;
        private bool _isGameVersionCorrect;

        public InstallData(string installDir = "", bool isComplete = false, bool isNewInstall = false) {
            InstallDir = installDir;
            IsComplete = isComplete;
            IsNewInstall = isNewInstall;
            IsGameVersionValid = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool CheckForPreviousMods() {

            if (Directory.Exists(InstallDir + "\\Mods")) {
                return true;
            }
            return false;
        }

        public bool IsNewInstallFolderEmpty() {

            var files = new DirectoryInfo(NewInstallDir).GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).FirstOrDefault();
            return files == null;
        }

        public void CleanInstallFolder() {
            DirectoryInfo directory = new DirectoryInfo(NewInstallDir);

            foreach (FileInfo file in directory.GetFiles()) {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.GetDirectories()) {
                dir.Delete(true);
            }
        }

        public void CloneBaseGame() {

            foreach (string dirPath in Directory.GetDirectories(InstallDir, "*", SearchOption.AllDirectories)) {
                Directory.CreateDirectory(dirPath.Replace(InstallDir, NewInstallDir));
            }

            foreach (string newPath in Directory.GetFiles(InstallDir, "*.*", SearchOption.AllDirectories)) {
                File.Copy(newPath, newPath.Replace(InstallDir, NewInstallDir), true);
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
