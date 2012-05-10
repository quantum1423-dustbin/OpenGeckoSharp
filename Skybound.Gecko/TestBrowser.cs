using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenGFX
{
    public partial class TestBrowser : Form
    {
        public TestBrowser()
        {
            InitializeComponent();
        }

        private void TestBrowser_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            Skybound.Gecko.Xpcom.Initialize("xulrunner");
        }
    }
}
