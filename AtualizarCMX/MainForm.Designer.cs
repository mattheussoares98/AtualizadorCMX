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
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.labelDownloadedVersion = new System.Windows.Forms.Label();
            this.buttonDownloadVersion = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.progressBarDownloading = new System.Windows.Forms.ProgressBar();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRemovePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(182, 35);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(162, 40);
            this.buttonSelectPath.TabIndex = 0;
            this.buttonSelectPath.Text = "Adicionar destino";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // labelDownloadedVersion
            // 
            this.labelDownloadedVersion.AutoSize = true;
            this.labelDownloadedVersion.Location = new System.Drawing.Point(12, 328);
            this.labelDownloadedVersion.Name = "labelDownloadedVersion";
            this.labelDownloadedVersion.Size = new System.Drawing.Size(205, 13);
            this.labelDownloadedVersion.TabIndex = 1;
            this.labelDownloadedVersion.Text = "Data do arquivo \"C:\\Install\\CmxWeb.zip\":";
            // 
            // buttonDownloadVersion
            // 
            this.buttonDownloadVersion.Location = new System.Drawing.Point(12, 352);
            this.buttonDownloadVersion.Name = "buttonDownloadVersion";
            this.buttonDownloadVersion.Size = new System.Drawing.Size(166, 40);
            this.buttonDownloadVersion.TabIndex = 2;
            this.buttonDownloadVersion.Text = "Baixar versão";
            this.buttonDownloadVersion.UseVisualStyleBackColor = true;
            this.buttonDownloadVersion.Click += new System.EventHandler(this.buttonDownloadVersion_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoEllipsis = true;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(223, 328);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(13, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "0";
            // 
            // progressBarDownloading
            // 
            this.progressBarDownloading.Location = new System.Drawing.Point(12, 299);
            this.progressBarDownloading.Name = "progressBarDownloading";
            this.progressBarDownloading.Size = new System.Drawing.Size(332, 26);
            this.progressBarDownloading.TabIndex = 5;
            this.progressBarDownloading.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(182, 352);
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
            this.listBoxPaths.Location = new System.Drawing.Point(12, 81);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(332, 212);
            this.listBoxPaths.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Informe o diretório";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // buttonRemovePath
            // 
            this.buttonRemovePath.Location = new System.Drawing.Point(12, 35);
            this.buttonRemovePath.Name = "buttonRemovePath";
            this.buttonRemovePath.Size = new System.Drawing.Size(162, 40);
            this.buttonRemovePath.TabIndex = 10;
            this.buttonRemovePath.Text = "Remover destino  selecionado";
            this.buttonRemovePath.UseVisualStyleBackColor = true;
            this.buttonRemovePath.Click += new System.EventHandler(this.buttonRemovePath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 398);
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
    }
}

