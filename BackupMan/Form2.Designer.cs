namespace BackupMan
{
    partial class Form2
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
            this.doUse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.doBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doQuit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doUse
            // 
            this.doUse.Location = new System.Drawing.Point(88, 3);
            this.doUse.Name = "doUse";
            this.doUse.Size = new System.Drawing.Size(78, 21);
            this.doUse.TabIndex = 0;
            this.doUse.Text = "Use";
            this.doUse.UseVisualStyleBackColor = true;
            this.doUse.Click += new System.EventHandler(this.doUse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // doBrowse
            // 
            this.doBrowse.Location = new System.Drawing.Point(3, 3);
            this.doBrowse.Name = "doBrowse";
            this.doBrowse.Size = new System.Drawing.Size(79, 21);
            this.doBrowse.TabIndex = 0;
            this.doBrowse.Text = "Browse";
            this.doBrowse.UseVisualStyleBackColor = true;
            this.doBrowse.Click += new System.EventHandler(this.doBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.doBrowse);
            this.panel1.Controls.Add(this.doQuit);
            this.panel1.Controls.Add(this.doUse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 27);
            this.panel1.TabIndex = 2;
            // 
            // doQuit
            // 
            this.doQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.doQuit.Location = new System.Drawing.Point(172, 3);
            this.doQuit.Name = "doQuit";
            this.doQuit.Size = new System.Drawing.Size(78, 21);
            this.doQuit.TabIndex = 0;
            this.doQuit.Text = "Cancel";
            this.doQuit.UseVisualStyleBackColor = true;
            this.doQuit.Click += new System.EventHandler(this.doQuit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.doQuit;
            this.ClientSize = new System.Drawing.Size(410, 51);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 90);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 90);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Select XML Datafile";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doUse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button doBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doQuit;
    }
}