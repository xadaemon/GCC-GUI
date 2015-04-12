using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace g___GUI
{
    public partial class GCC : Form
    {
        private string fn;
        public GCC()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.fileDialogInput.ShowDialog();
            fn = fileDialogInput.FileName;
            using (FileStream fs = File.Open(fn, FileMode.Open))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    makefileContents.Text = (temp.GetString(b));
                }
            }
        }

        private void compileStart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo("cd "+this.baseFolder.Text+"|make", this.cmdArgs.Text);
            p.UseShellExecute = false;
            p.RedirectStandardOutput = true;
            p.RedirectStandardError = true;
            Process Reg = Process.Start(p);
            string output = Reg.StandardOutput.ReadToEnd();
            Reg.WaitForExit();
            this.stdout.Text = output;
        }

        private void baseFolderBrowse_Click(object sender, EventArgs e)
        {
            this.baseFolderSelector.ShowDialog();
            string baseFolderVar = baseFolderSelector.SelectedPath;
            this.baseFolder.Text = baseFolderVar;
        }
    }
}
