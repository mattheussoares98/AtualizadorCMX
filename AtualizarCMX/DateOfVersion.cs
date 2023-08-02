using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtualizarCMX {
    internal class DateOfVersion {
        public void GetDateOfVersion(MainForm mainForm) {
            string filePath = "C:\\Install\\CmxWeb.zip";

            if(File.Exists(filePath)) {
                DateTime creationDate = File.GetCreationTime(filePath);
                mainForm.labelDate.Text= creationDate.ToString();
            } else {
                mainForm.labelDate.Text = "0";
            }
        }

    }
}
