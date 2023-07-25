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
            this.labelDestinyPath = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(153, 66);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(131, 41);
            this.buttonSelectPath.TabIndex = 0;
            this.buttonSelectPath.Text = "Selecionar destino";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // labelDownloadedVersion
            // 
            this.labelDownloadedVersion.AutoSize = true;
            this.labelDownloadedVersion.Location = new System.Drawing.Point(13, 9);
            this.labelDownloadedVersion.Name = "labelDownloadedVersion";
            this.labelDownloadedVersion.Size = new System.Drawing.Size(205, 13);
            this.labelDownloadedVersion.TabIndex = 1;
            this.labelDownloadedVersion.Text = "Data do arquivo \"C:\\Install\\CmxWeb.zip\":";
            // 
            // buttonDownloadVersion
            // 
            this.buttonDownloadVersion.Location = new System.Drawing.Point(12, 66);
            this.buttonDownloadVersion.Name = "buttonDownloadVersion";
            this.buttonDownloadVersion.Size = new System.Drawing.Size(131, 41);
            this.buttonDownloadVersion.TabIndex = 2;
            this.buttonDownloadVersion.Text = "Baixar versão";
            this.buttonDownloadVersion.UseVisualStyleBackColor = true;
            this.buttonDownloadVersion.Click += new System.EventHandler(this.buttonDownloadVersion_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoEllipsis = true;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(224, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(13, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "0";
            // 
            // progressBarDownloading
            // 
            this.progressBarDownloading.Location = new System.Drawing.Point(12, 34);
            this.progressBarDownloading.Name = "progressBarDownloading";
            this.progressBarDownloading.Size = new System.Drawing.Size(409, 26);
            this.progressBarDownloading.TabIndex = 5;
            this.progressBarDownloading.Visible = false;
            // 
            // labelDestinyPath
            // 
            this.labelDestinyPath.AutoSize = true;
            this.labelDestinyPath.Location = new System.Drawing.Point(111, 120);
            this.labelDestinyPath.Name = "labelDestinyPath";
            this.labelDestinyPath.Size = new System.Drawing.Size(144, 13);
            this.labelDestinyPath.TabIndex = 6;
            this.labelDestinyPath.Text = "Selecione a pasta de destino";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(290, 66);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(131, 41);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Atualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pasta de destino: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelDestinyPath);
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
        public System.Windows.Forms.Label labelDestinyPath;
        private System.Windows.Forms.Label label1;
    }
}

