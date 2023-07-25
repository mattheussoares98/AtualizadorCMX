using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtualizarCMX {
    public class DownloadCMX {


        public async Task downloadFileTaskAsync(MainForm mainForm) {
            DateOfVersion dateOfVersion = new DateOfVersion();
            HttpClient client = new HttpClient();

            string destinyPath = "C:\\Install";
            string fileName = "CmxWeb.zip";
            string urlDownload = "http://187.35.140.227/downloads/lastversion/" + fileName;

            if(!Directory.Exists(destinyPath)) {
                Directory.CreateDirectory(destinyPath);
            } 

            string fileNamePath = destinyPath + "\\" + fileName;

            #region download files
            try {

                using(var s = await client.GetStreamAsync(urlDownload)) {
                    using(var fs = new FileStream(fileNamePath, FileMode.CreateNew)) {
                        await s.CopyToAsync(fs);
                    }
                }

                File.SetCreationTime(fileNamePath, DateTime.Now);
            } catch(Exception ex) {
                DialogResult dialogResult = MessageBox.Show($"Erro para fazer o download\nErro:" + ex.Message + "\n\nDESEJA TENTAR FAZER O DOWNLOAD NOVAMENTE?", "Efetuar download", MessageBoxButtons.YesNo);

                if(dialogResult == DialogResult.No) {
                    dateOfVersion.GetDateOfVersion(mainForm);

                    return;
                } else {
                    if(Directory.Exists(destinyPath + "\\CmxWeb")) {
                        Directory.Delete(destinyPath + "\\CmxWeb", true);
                    }
                    if(File.Exists(fileNamePath)) { //teoricamente iniciou o download mas deu erro, por isso precisa apagar o arquivo pra tentar efetuar o download novamente
                        File.Delete(fileNamePath);
                        dateOfVersion.GetDateOfVersion(mainForm);
                    }
                    await downloadFileTaskAsync(mainForm);
                }
            }
            #endregion
            dateOfVersion.GetDateOfVersion(mainForm);


        }
    }
}
