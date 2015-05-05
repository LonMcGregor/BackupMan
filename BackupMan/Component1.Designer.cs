namespace BackupMan
{
    partial class Component1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browseButton = new System.Windows.Forms.Button();
            this.locText = new System.Windows.Forms.TextBox();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(0, 0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "button1";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // locText
            // 
            this.locText.Location = new System.Drawing.Point(0, 0);
            this.locText.Name = "locText";
            this.locText.Size = new System.Drawing.Size(100, 20);
            this.locText.TabIndex = 0;

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox locText;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}
