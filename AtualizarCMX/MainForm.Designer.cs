namespace AtualizarCMX {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.labelDownloadedVersion = new System.Windows.Forms.Label();
            this.buttonDownloadVersion = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.progressBarDownloading = new System.Windows.Forms.ProgressBar();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRemovePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonFolderBrowserDialog = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelPathsToUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(268, 85);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(192, 40);
            this.buttonSelectPath.TabIndex = 3;
            this.buttonSelectPath.Text = "Adicionar destino DIGITADO";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // labelDownloadedVersion
            // 
            this.labelDownloadedVersion.AutoSize = true;
            this.labelDownloadedVersion.Location = new System.Drawing.Point(12, 206);
            this.labelDownloadedVersion.Name = "labelDownloadedVersion";
            this.labelDownloadedVersion.Size = new System.Drawing.Size(205, 13);
            this.labelDownloadedVersion.TabIndex = 8;
            this.labelDownloadedVersion.Text = "Data do arquivo \"C:\\Install\\CmxWeb.zip\":";
            // 
            // buttonDownloadVersion
            // 
            this.buttonDownloadVersion.Location = new System.Drawing.Point(51, 231);
            this.buttonDownloadVersion.Name = "buttonDownloadVersion";
            this.buttonDownloadVersion.Size = new System.Drawing.Size(166, 40);
            this.buttonDownloadVersion.TabIndex = 6;
            this.buttonDownloadVersion.Text = "Baixar versão";
            this.buttonDownloadVersion.UseVisualStyleBackColor = true;
            this.buttonDownloadVersion.Click += new System.EventHandler(this.buttonDownloadVersion_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoEllipsis = true;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(223, 206);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(13, 13);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "0";
            // 
            // progressBarDownloading
            // 
            this.progressBarDownloading.Location = new System.Drawing.Point(12, 178);
            this.progressBarDownloading.Name = "progressBarDownloading";
            this.progressBarDownloading.Size = new System.Drawing.Size(446, 25);
            this.progressBarDownloading.TabIndex = 5;
            this.progressBarDownloading.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(236, 231);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(164, 40);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Atualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.Location = new System.Drawing.Point(12, 25);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPaths.Size = new System.Drawing.Size(250, 147);
            this.listBoxPaths.TabIndex = 4;
            this.listBoxPaths.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxPaths_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Informe o novo diretório";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // buttonRemovePath
            // 
            this.buttonRemovePath.Location = new System.Drawing.Point(268, 131);
            this.buttonRemovePath.Name = "buttonRemovePath";
            this.buttonRemovePath.Size = new System.Drawing.Size(192, 40);
            this.buttonRemovePath.TabIndex = 5;
            this.buttonRemovePath.Text = "Remover destino(s) selecionado(s)";
            this.buttonRemovePath.UseVisualStyleBackColor = true;
            this.buttonRemovePath.Click += new System.EventHandler(this.buttonRemovePath_Click);
            // 
            // buttonFolderBrowserDialog
            // 
            this.buttonFolderBrowserDialog.Location = new System.Drawing.Point(268, 11);
            this.buttonFolderBrowserDialog.Name = "buttonFolderBrowserDialog";
            this.buttonFolderBrowserDialog.Size = new System.Drawing.Size(190, 40);
            this.buttonFolderBrowserDialog.TabIndex = 1;
            this.buttonFolderBrowserDialog.Text = "Selecionar pasta de destino pelo Windows Explorer";
            this.buttonFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.buttonFolderBrowserDialog.Click += new System.EventHandler(this.buttonFolderBrowserDialog_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelPathsToUpdate
            // 
            this.labelPathsToUpdate.Location = new System.Drawing.Point(9, 7);
            this.labelPathsToUpdate.Name = "labelPathsToUpdate";
            this.labelPathsToUpdate.Size = new System.Drawing.Size(228, 15);
            this.labelPathsToUpdate.TabIndex = 13;
            this.labelPathsToUpdate.Text = "Diretórios selecionados para atualização";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 283);
            this.Controls.Add(this.labelPathsToUpdate);
            this.Controls.Add(this.buttonFolderBrowserDialog);
            this.Controls.Add(this.buttonRemovePath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxPaths);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.progressBarDownloading);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonDownloadVersion);
            this.Controls.Add(this.labelDownloadedVersion);
            this.Controls.Add(this.buttonSelectPath);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizador do CMX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Label labelDownloadedVersion;
        public System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.ProgressBar progressBarDownloading;
        public System.Windows.Forms.Button buttonDownloadVersion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemovePath;
        public System.Windows.Forms.ListBox listBoxPaths;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonFolderBrowserDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelPathsToUpdate;
    }
}

