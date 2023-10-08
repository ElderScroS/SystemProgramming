namespace WindowsFormsApp1
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
            this.ThreadsListBox = new System.Windows.Forms.ListBox();
            this.RunBtn = new System.Windows.Forms.Button();
            this.SuspendBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.NumberPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LetterPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SymbolPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreadsListBox
            // 
            this.ThreadsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreadsListBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreadsListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ThreadsListBox.FormattingEnabled = true;
            this.ThreadsListBox.ItemHeight = 28;
            this.ThreadsListBox.Location = new System.Drawing.Point(437, 12);
            this.ThreadsListBox.Name = "ThreadsListBox";
            this.ThreadsListBox.Size = new System.Drawing.Size(401, 480);
            this.ThreadsListBox.TabIndex = 0;
            // 
            // RunBtn
            // 
            this.RunBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RunBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.RunBtn.Location = new System.Drawing.Point(85, 28);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(265, 61);
            this.RunBtn.TabIndex = 1;
            this.RunBtn.Text = "Run";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // SuspendBtn
            // 
            this.SuspendBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SuspendBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuspendBtn.ForeColor = System.Drawing.Color.Red;
            this.SuspendBtn.Location = new System.Drawing.Point(85, 141);
            this.SuspendBtn.Name = "SuspendBtn";
            this.SuspendBtn.Size = new System.Drawing.Size(265, 61);
            this.SuspendBtn.TabIndex = 2;
            this.SuspendBtn.Text = "Suspend";
            this.SuspendBtn.UseVisualStyleBackColor = false;
            this.SuspendBtn.Click += new System.EventHandler(this.SuspendBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResumeBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.ResumeBtn.Location = new System.Drawing.Point(85, 241);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(265, 61);
            this.ResumeBtn.TabIndex = 3;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = false;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // NumberPriorityComboBox
            // 
            this.NumberPriorityComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NumberPriorityComboBox.Font = new System.Drawing.Font("AcadEref", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPriorityComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberPriorityComboBox.FormattingEnabled = true;
            this.NumberPriorityComboBox.Location = new System.Drawing.Point(1073, 28);
            this.NumberPriorityComboBox.Name = "NumberPriorityComboBox";
            this.NumberPriorityComboBox.Size = new System.Drawing.Size(173, 33);
            this.NumberPriorityComboBox.TabIndex = 4;
            this.NumberPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberPriorityComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(841, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Priority Lvl:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(844, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Letter Priority Lvl:";
            // 
            // LetterPriorityComboBox
            // 
            this.LetterPriorityComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LetterPriorityComboBox.Font = new System.Drawing.Font("AcadEref", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetterPriorityComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LetterPriorityComboBox.FormattingEnabled = true;
            this.LetterPriorityComboBox.Location = new System.Drawing.Point(1073, 141);
            this.LetterPriorityComboBox.Name = "LetterPriorityComboBox";
            this.LetterPriorityComboBox.Size = new System.Drawing.Size(173, 33);
            this.LetterPriorityComboBox.TabIndex = 6;
            this.LetterPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.LetterPriorityComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(841, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Symbol Priority Lvl:";
            // 
            // SymbolPriorityComboBox
            // 
            this.SymbolPriorityComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SymbolPriorityComboBox.Font = new System.Drawing.Font("AcadEref", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolPriorityComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SymbolPriorityComboBox.FormattingEnabled = true;
            this.SymbolPriorityComboBox.Location = new System.Drawing.Point(1073, 240);
            this.SymbolPriorityComboBox.Name = "SymbolPriorityComboBox";
            this.SymbolPriorityComboBox.Size = new System.Drawing.Size(173, 33);
            this.SymbolPriorityComboBox.TabIndex = 8;
            this.SymbolPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.SymbolPriorityComboBox_SelectedIndexChanged);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ShowBtn.Location = new System.Drawing.Point(912, 406);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(267, 76);
            this.ShowBtn.TabIndex = 10;
            this.ShowBtn.Text = "Show Priorities";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1266, 550);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SymbolPriorityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LetterPriorityComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberPriorityComboBox);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.SuspendBtn);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.ThreadsListBox);
            this.Name = "Form1";
            this.Text = "Threads";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ThreadsListBox;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.Button SuspendBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.ComboBox NumberPriorityComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LetterPriorityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SymbolPriorityComboBox;
        private System.Windows.Forms.Button ShowBtn;
    }
}

