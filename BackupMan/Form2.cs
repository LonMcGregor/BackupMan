using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupMan
{
    public partial class Form2 : Form
    {
        Form1 parent;

        public Form2(Form1 e, String title)
        {
            InitializeComponent();
            this.ControlBox = false;
            parent = e;
            this.Text = title;
        }

        private void doBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void doUse_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                parent.setXmlData(textBox1.Text);
                this.Hide();
            }
        }

        private void doQuit_Click(object sender, EventArgs e)
        {
            parent.exit();
        }
    }
}
