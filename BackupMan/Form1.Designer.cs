namespace BackupMan
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
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbNames = new System.Windows.Forms.GroupBox();
            this.currentOutputFor = new System.Windows.Forms.Label();
            this.doBrowse = new System.Windows.Forms.Button();
            this.locTxt = new System.Windows.Forms.TextBox();
            this.goNext = new System.Windows.Forms.Button();
            this.goPrev = new System.Windows.Forms.Button();
            this.prompt = new System.Windows.Forms.Label();
            this.zPbar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clb1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(12, 335);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(372, 23);
            this.progBar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locations";
            // 
            // gbNames
            // 
            this.gbNames.Controls.Add(this.currentOutputFor);
            this.gbNames.Controls.Add(this.doBrowse);
            this.gbNames.Controls.Add(this.locTxt);
            this.gbNames.Location = new System.Drawing.Point(12, 12);
            this.gbNames.Name = "gbNames";
            this.gbNames.Size = new System.Drawing.Size(372, 288);
            this.gbNames.TabIndex = 4;
            this.gbNames.TabStop = false;
            this.gbNames.Text = "Output Location";
            this.gbNames.Visible = false;
            // 
            // currentOutputFor
            // 
            this.currentOutputFor.AutoSize = true;
            this.currentOutputFor.Location = new System.Drawing.Point(17, 53);
            this.currentOutputFor.Name = "currentOutputFor";
            this.currentOutputFor.Size = new System.Drawing.Size(87, 13);
            this.currentOutputFor.TabIndex = 2;
            this.currentOutputFor.Text = "currentOutputFor";
            // 
            // doBrowse
            // 
            this.doBrowse.Location = new System.Drawing.Point(291, 98);
            this.doBrowse.Name = "doBrowse";
            this.doBrowse.Size = new System.Drawing.Size(75, 20);
            this.doBrowse.TabIndex = 1;
            this.doBrowse.Text = "Browse";
            this.doBrowse.UseVisualStyleBackColor = true;
            this.doBrowse.Click += new System.EventHandler(this.doBrowse_Click);
            // 
            // locTxt
            // 
            this.locTxt.Location = new System.Drawing.Point(17, 72);
            this.locTxt.Name = "locTxt";
            this.locTxt.Size = new System.Drawing.Size(349, 20);
            this.locTxt.TabIndex = 0;
            // 
            // goNext
            // 
            this.goNext.Location = new System.Drawing.Point(308, 306);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(76, 23);
            this.goNext.TabIndex = 2;
            this.goNext.Text = "Next";
            this.goNext.UseVisualStyleBackColor = true;
            this.goNext.Click += new System.EventHandler(this.goNext_Click);
            // 
            // goPrev
            // 
            this.goPrev.Location = new System.Drawing.Point(225, 306);
            this.goPrev.Name = "goPrev";
            this.goPrev.Size = new System.Drawing.Size(77, 23);
            this.goPrev.TabIndex = 2;
            this.goPrev.Text = "Previous";
            this.goPrev.UseVisualStyleBackColor = true;
            this.goPrev.Click += new System.EventHandler(this.goPrev_Click);
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.prompt.Location = new System.Drawing.Point(12, 311);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(149, 13);
            this.prompt.TabIndex = 3;
            this.prompt.Text = "Select Location(s) to Back Up";
            // 
            // zPbar
            // 
            this.zPbar.Location = new System.Drawing.Point(12, 364);
            this.zPbar.Name = "zPbar";
            this.zPbar.Size = new System.Drawing.Size(372, 23);
            this.zPbar.TabIndex = 0;
            // 
            // clb1
            // 
            this.clb1.FormattingEnabled = true;
            this.clb1.Location = new System.Drawing.Point(6, 19);
            this.clb1.Name = "clb1";
            this.clb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.clb1.Size = new System.Drawing.Size(350, 264);
            this.clb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 391);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.gbNames);
            this.Controls.Add(this.goPrev);
            this.Controls.Add(this.goNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zPbar);
            this.Controls.Add(this.progBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 430);
            this.MinimumSize = new System.Drawing.Size(412, 430);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BackupManager";
            this.groupBox1.ResumeLayout(false);
            this.gbNames.ResumeLayout(false);
            this.gbNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goNext;
        private System.Windows.Forms.Button goPrev;
        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.ProgressBar zPbar;
        private System.Windows.Forms.GroupBox gbNames;
        private System.Windows.Forms.TextBox locTxt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button doBrowse;
        private System.Windows.Forms.Label currentOutputFor;
        private System.Windows.Forms.ListBox clb1;
    }
}

