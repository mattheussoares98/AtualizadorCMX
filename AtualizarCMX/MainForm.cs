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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string crossPath = textBox1.Text + "\\cross";
            string crossSitePath = textBox1.Text + "\\crossSite";

            if(!Directory.Exists(crossPath) || !Directory.Exists(crossSitePath)) {
                MessageBox.Show("Diretório inválido! Não foi possível encontrar a pasta do cross ou do crossSite");
            } else if(!textBox1.Text.Contains("\\")) {
                MessageBox.Show("Diretório inválido!");
            } else if(!textBox1.Text.ToLower().Contains(":")) {
                MessageBox.Show("Diretório inválido!. O endereço não possui ':'");
            } else {

                if(!string.IsNullOrEmpty(textBox1.Text) && !DirectoryExistsInListBox(textBox1.Text)) {
                    listBoxPaths.Items.Add(textBox1.Text);

                } else {
                    MessageBox.Show("O diretório já foi informado para atualização!");
                }
                textBox1.Text = "Informe o novo diretório";
                textBox1.SelectAll();
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e) {
            disableForms();
            await Task.Run(() => new UpdateFiles().updateFiles(this));
            enableForms();
        }

        private void buttonRemovePath_Click(object sender, EventArgs e) {
            var selectedItems = new List<string>(listBoxPaths.SelectedItems.Cast<string>());

            foreach(var item in selectedItems) {
                listBoxPaths.Items.Remove(item);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                buttonSelectPath_Click(null, null);
            }
        }

        private void buttonFolderBrowserDialog_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult result = folderBrowserDialog.ShowDialog();

            if(result == DialogResult.OK) {
                string selectedFolder = folderBrowserDialog.SelectedPath;

                textBox1.Text = selectedFolder;
                buttonSelectPath_Click(null, null);
            }
        }

        private void textBox1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "Informe o novo diretório") {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            if(textBox1.Text == "") {
                textBox1.Text = "Informe o novo diretório";
            }
        }
        private bool DirectoryExistsInListBox(string directory) {
            return listBoxPaths.Items.Cast<string>().Any(item =>
                string.Compare(item, directory, StringComparison.InvariantCultureIgnoreCase) == 0);
        }

        private void listBoxPaths_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Delete) {
                var selectedItems = new List<string>(listBoxPaths.SelectedItems.Cast<string>());

                foreach(var item in selectedItems) {
                    listBoxPaths.Items.Remove(item);
                }
            }
        }
    }

}
