namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseItemBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SelectedFileLbl = new System.Windows.Forms.Label();
            this.SelectedFolderForCopyLbl = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ChooseFolderForCopyBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ChooseItemBtn
            // 
            this.ChooseItemBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseItemBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseItemBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.ChooseItemBtn.Location = new System.Drawing.Point(248, 185);
            this.ChooseItemBtn.Name = "ChooseItemBtn";
            this.ChooseItemBtn.Size = new System.Drawing.Size(196, 76);
            this.ChooseItemBtn.TabIndex = 0;
            this.ChooseItemBtn.Text = "Choose Item";
            this.ChooseItemBtn.UseVisualStyleBackColor = false;
            this.ChooseItemBtn.Click += new System.EventHandler(this.ChooseItemBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Navy;
            this.progressBar.Location = new System.Drawing.Point(1, 486);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1385, 47);
            this.progressBar.TabIndex = 1;
            // 
            // SelectedFileLbl
            // 
            this.SelectedFileLbl.AutoSize = true;
            this.SelectedFileLbl.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFileLbl.ForeColor = System.Drawing.Color.White;
            this.SelectedFileLbl.Location = new System.Drawing.Point(25, 9);
            this.SelectedFileLbl.Name = "SelectedFileLbl";
            this.SelectedFileLbl.Size = new System.Drawing.Size(277, 36);
            this.SelectedFileLbl.TabIndex = 2;
            this.SelectedFileLbl.Text = "Selected Item: -----";
            // 
            // SelectedFolderForCopyLbl
            // 
            this.SelectedFolderForCopyLbl.AutoSize = true;
            this.SelectedFolderForCopyLbl.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedFolderForCopyLbl.ForeColor = System.Drawing.Color.White;
            this.SelectedFolderForCopyLbl.Location = new System.Drawing.Point(25, 76);
            this.SelectedFolderForCopyLbl.Name = "SelectedFolderForCopyLbl";
            this.SelectedFolderForCopyLbl.Size = new System.Drawing.Size(430, 36);
            this.SelectedFolderForCopyLbl.TabIndex = 3;
            this.SelectedFolderForCopyLbl.Text = "Selected Folder For Copy: -----";
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.StopBtn.Location = new System.Drawing.Point(702, 315);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(196, 76);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ChooseFolderForCopyBtn
            // 
            this.ChooseFolderForCopyBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChooseFolderForCopyBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFolderForCopyBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.ChooseFolderForCopyBtn.Location = new System.Drawing.Point(913, 185);
            this.ChooseFolderForCopyBtn.Name = "ChooseFolderForCopyBtn";
            this.ChooseFolderForCopyBtn.Size = new System.Drawing.Size(196, 76);
            this.ChooseFolderForCopyBtn.TabIndex = 5;
            this.ChooseFolderForCopyBtn.Text = "Choose Folder For Copy";
            this.ChooseFolderForCopyBtn.UseVisualStyleBackColor = false;
            this.ChooseFolderForCopyBtn.Click += new System.EventHandler(this.ChooseFolderForCopyBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.StartBtn.Location = new System.Drawing.Point(416, 315);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(196, 76);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "Start Copy";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgressLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProgressLbl.Location = new System.Drawing.Point(657, 499);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(39, 20);
            this.ProgressLbl.TabIndex = 7;
            this.ProgressLbl.Text = "0 %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1383, 557);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.ChooseFolderForCopyBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.SelectedFolderForCopyLbl);
            this.Controls.Add(this.SelectedFileLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ChooseItemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseItemBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label SelectedFileLbl;
        private System.Windows.Forms.Label SelectedFolderForCopyLbl;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button ChooseFolderForCopyBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label ProgressLbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

