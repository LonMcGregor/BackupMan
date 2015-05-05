using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupMan
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);
            container.Add(locText);
            container.Add(browseButton);
            InitializeComponent();
        }

        private void containerPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
