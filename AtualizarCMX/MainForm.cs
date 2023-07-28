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
            if(!textBox1.Text.Contains("\\")) {
                MessageBox.Show("Diretório inválido!");
            } else if(!textBox1.Text.ToLower().EndsWith("cmxweb")) {
                MessageBox.Show("Diretório inválido!. O nome do diretório precisa terminar com 'CmxWeb'");
            } else if(!textBox1.Text.ToLower().Contains(":")) {
                MessageBox.Show("Diretório inválido!. O endereço não possui ':'");
            } else {
                listBoxPaths.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }

        }

        private async void buttonUpdate_Click(object sender, EventArgs e) {
            disableForms();
            await Task.Run(() => new UpdateFiles().updateFiles(this));
            enableForms();
        }

        private void buttonRemovePath_Click(object sender, EventArgs e) {
            if(listBoxPaths.SelectedIndex != -1) {
                listBoxPaths.Items.RemoveAt(listBoxPaths.SelectedIndex);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                buttonSelectPath_Click(null, null);
            }
        }
    }

}
