using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtualizarCMX {
    internal class UpdateFiles {
        private string crossSiteIPAndPort = "";
        private string crossIPAndPort = "";

        private bool validateCanContinue(MainForm mainForm) {
            bool canContinue = true;
            foreach(string path in mainForm.listBoxPaths.Items) {
                if(!existPaths(path)) {
                    canContinue = false;
                    break;
                }
            }
            if(mainForm.listBoxPaths.Items.Count == 0 || mainForm.listBoxPaths.Items == null) {
                MessageBox.Show("Informe a pasta de destino para atualização!");
                canContinue = false;
            }

            if(mainForm.labelDate.Text == "0") {
                canContinue = false;
            }
            return canContinue;
        }
        public async Task updateFiles(MainForm mainForm) {
            string originPath = "C:\\Install\\CmxWeb";

            bool canContinue = validateCanContinue(mainForm);
            if(!canContinue) {
                return;
            }


            try {
                await extractFiles();
                foreach(string destinyPath in mainForm.listBoxPaths.Items) {
                    await createZipCopyOfSourceDirectory(destinyPath);
                    await getIpOfWebConfig(destinyPath);
                    await overrideFiles(originPath, destinyPath);
                    await updateWebConfig(destinyPath);
                }

                MessageBox.Show("Atualizado com sucesso!");
            } catch(Exception ex) {
                MessageBox.Show("Ocorreu um erro não esperado durante a atualização! Teste o CMX dos clientes selecionados e caso ocorra algum problema, recupere o backup\n" + ex.Message);

            }
        }

        private async Task createZipCopyOfSourceDirectory(string path) {
            try {
                string zipFilePath = path + "Backup.zip";
                if(File.Exists(zipFilePath)) {
                    File.Delete(zipFilePath);
                }

                ZipFile.CreateFromDirectory(path, zipFilePath, CompressionLevel.Optimal, true);

            } catch(Exception ex) {
                MessageBox.Show("Erro para criar o backup: " + ex.Message);
            }
        }
        private bool existPaths(string destinyPath) {
            if(!Directory.Exists(destinyPath + "\\Cross")) {
                MessageBox.Show("O diretório '" + destinyPath + "\\Cross'" + " não foi encontrado");
                return false;
            } else if(!Directory.Exists(destinyPath + "\\CrossSite")) {
                MessageBox.Show("O diretório '" + destinyPath + "\\CrossSite'" + " não foi encontrado");
                return false;
            } else if(!File.Exists(destinyPath + "\\CrossSite\\" + "Web.config")) {
                MessageBox.Show("O arquivo '" + destinyPath + "\\CrossSite\\" + "Web.config'" + " não foi encontrado");
                return false;
            } else if(!File.Exists(destinyPath + "\\Cross\\" + "Web.config")) {
                MessageBox.Show("O arquivo '" + destinyPath + "\\Cross\\" + "Web.config'" + " não foi encontrado");
                return false;
            } else {

                return true;
            }
        }

        private async Task overrideFiles(string originPath, string destinyPath) {

            if(!Directory.Exists(originPath)) {
                MessageBox.Show($"Não foi possível encontrar o caminho {originPath}");
                return;
            }
            if(!Directory.Exists(destinyPath)) {
                Directory.CreateDirectory(destinyPath);
            }

            // Obtém a lista de arquivos da pasta de origem
            foreach(string arquivo in Directory.GetFiles(originPath, "*.*", SearchOption.AllDirectories)) {
                string caminhoRelativo = arquivo.Substring(originPath.Length + 1);
                string caminhoCompletoDestino = Path.Combine(destinyPath, caminhoRelativo);
                string diretorioDestino = Path.GetDirectoryName(caminhoCompletoDestino);

                // Cria o diretório de destino se ainda não existir
                if(!Directory.Exists(diretorioDestino)) {
                    Directory.CreateDirectory(diretorioDestino);
                }

                // Copia o arquivo, sobrescrevendo se já existir no destino
                File.Copy(arquivo, caminhoCompletoDestino, true);
            }
        }

        private async Task extractFiles() {
            string zipFilePath = "C:\\Install\\CmxWeb.zip";
            string destinyPath = "C:\\Install";

            // Verifica se o arquivo ZIP existe
            if(File.Exists(zipFilePath)) {
                // Cria o diretório de extração, se ainda não existir

                if(!File.Exists(destinyPath)) {
                    Directory.CreateDirectory(destinyPath);
                }

                if(!Directory.Exists(destinyPath + "\\CmxWeb")) {
                    //caso já exista essa pasta, não precisa extrair novamente
                    ZipFile.ExtractToDirectory(zipFilePath, destinyPath);
                }


            } else {
                MessageBox.Show($"O arquivo {zipFilePath} não foi encontrado");
            }
        }
        private async Task getIpOfWebConfig(string destinyPath) {
            string crossDestinyPath = destinyPath + "\\Cross\\Web.config";
            string crossSiteDestinyPath = destinyPath + "\\CrossSite\\Web.config";
            try {
                string crossTextConfig = File.ReadAllText(crossDestinyPath);
                string crossSiteTextConfig = File.ReadAllText(crossSiteDestinyPath);
                string commentPattern = @"<!--[\s\S]*?-->";

                string crossTextWithoutComments = Regex.Replace(crossTextConfig, commentPattern, "");
                string crossSiteTextWithoutComments = Regex.Replace(crossSiteTextConfig, commentPattern, "");

                string fileContent = File.ReadAllText(crossDestinyPath);


                string patternCrossSite = @"(?:http:\/\/)?([^\/:\s]+):(\d+)";

                string patternCross = @"http:\/\/(.*?)(?=\/ccs)";
                Match matchCross = Regex.Match(crossTextWithoutComments, patternCross);
                Match matchCrossSite = Regex.Match(crossSiteTextWithoutComments, patternCrossSite);

                if(matchCross.Success) {
                    string ipAddress = matchCross.Groups[1].Value;
                    string port = matchCross.Groups[2].Value;

                    crossIPAndPort = matchCross.Groups[1].Value;
                } else {
                    MessageBox.Show("IP com porta não encontrado no texto. Ocorreu algum erro na atualização do Web.config!");
                }

                if(matchCrossSite.Success) {
                    string ipAddress = matchCrossSite.Groups[1].Value;
                    string port = matchCrossSite.Groups[2].Value;

                    crossSiteIPAndPort = ipAddress + ":" + port;
                } else {
                    MessageBox.Show("IP com porta não encontrado no texto. Ocorreu algum erro na atualização do Web.config!");
                }


            } catch(Exception ex) {
                MessageBox.Show("An error occurred in getIpOfWebConfig: " + ex.Message);
            }
        }
        private async Task updateWebConfig(string destinyPath) {
            string crossDestinyPath = destinyPath + "\\Cross\\Web.config";
            string crossSiteDestinyPath = destinyPath + "\\CrossSite\\Web.config";
            try {
                string crossConfigText = File.ReadAllText(crossDestinyPath);
                string crossSiteConfigText = File.ReadAllText(crossSiteDestinyPath);

                crossConfigText = crossConfigText.Replace("localhost:9092", crossIPAndPort);
                crossSiteConfigText = crossSiteConfigText.Replace("localhost:34603", crossSiteIPAndPort);

                File.WriteAllText(crossDestinyPath, crossConfigText);
                File.WriteAllText(crossSiteDestinyPath, crossSiteConfigText);

            } catch(Exception ex) {
                MessageBox.Show("An error occurred in updateWebConfig: " + ex.Message);
            }
        }

    }
}
