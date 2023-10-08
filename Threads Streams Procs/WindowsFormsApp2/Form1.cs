using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cts;
        private BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseItemBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                SelectedFileLbl.Text = "Selected File: " + openFileDialog1.FileName;

        }
        private void ChooseFolderForCopyBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                SelectedFolderForCopyLbl.Text = "Selected Folder: " + folderBrowserDialog1.SelectedPath;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string sourceFile = openFileDialog1.FileName;
            string destinationFile = Path.Combine(folderBrowserDialog1.SelectedPath, Path.GetFileName(sourceFile));
            long fileSize = new FileInfo(sourceFile).Length;

            try
            {
                cts = new CancellationTokenSource();
                using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream destinationStream = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write))
                {
                    progressBar.Maximum = (int)fileSize;
                    byte[] buffer = new byte[8192];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        if (cts.IsCancellationRequested)
                            return;

                        destinationStream.Write(buffer, 0, bytesRead);
                        progressBar.Value += bytesRead;

                        if (progressBar.Value >= progressBar.Maximum)
                            break;
                    }
                    MessageBox.Show("The Copying was completed successfuly!");
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("The Copying was stoped");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            ProgressLbl.Text = $"{e.ProgressPercentage}%";
        }



    }
}

