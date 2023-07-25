using System;
using FolderBrowserEx;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderBrowserDialog = System.Windows.Forms.FolderBrowserDialog;

namespace AtualizarCMX {
    public partial class MainForm: Form {
        public MainForm() {
            InitializeComponent();
            new DateOfVersion().GetDateOfVersion(this);
        }


        private void disableForms() {
            this.Enabled = false;
            progressBarDownloading.Visible = true;
            progressBarDownloading.Style = ProgressBarStyle.Marquee;
            progressBarDownloading.MarqueeAnimationSpeed = 30;
            buttonDownloadVersion.Enabled = false;
        }

        private void enableForms() {
            buttonDownloadVersion.Enabled = true;
            progressBarDownloading.Style = ProgressBarStyle.Continuous;
            progressBarDownloading.MarqueeAnimationSpeed = 0;
            progressBarDownloading.Visible = false;
            this.Enabled = true;
        }

        private async void buttonDownloadVersion_Click(object sender, EventArgs e) {
            disableForms();
            await new DownloadCMX().downloadFileTaskAsync(this);
            enableForms();
        }

        private void buttonSelectPath_Click(object sender, EventArgs e) {

            using(var dialog = new FolderBrowserDialog()) {

                dialog.Description = "Selecione uma pasta";
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult result = dialog.ShowDialog();

                if(result == DialogResult.OK) {

                    if(!dialog.SelectedPath.ToLower().Contains("cmxweb")) {
                        MessageBox.Show("Diretório inválido!. Selecione a pasta 'CmxWeb'");
                        return;
                    } else if(dialog.SelectedPath.ToLower().Contains("cross")) {
                        MessageBox.Show("Diretório inválido!. Selecione a pasta 'CmxWeb'");
                        return;
                    } else if(dialog.SelectedPath.ToLower().Contains("crosssite")) {
                        MessageBox.Show("Diretório inválido!. Selecione a pasta 'CmxWeb'");
                        return;
                    } else {
                        labelDestinyPath.Text = dialog.SelectedPath;
                    }
                }
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e) {
            disableForms();
            await new UpdateFiles().updateFiles(this);
            enableForms();
        }
    }

}
