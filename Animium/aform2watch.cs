using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;


namespace Animium
{
    public partial class chrome : Form
    {
        public chrome()
        {
            InitializeComponent();
        }

        public CefSharp.WinForms.ChromiumWebBrowser browser;


        private void aform2watch_Load(object sender, EventArgs e)
        {
            browser = new CefSharp.WinForms.ChromiumWebBrowser("")
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200),
            };
            this.pContainer.Controls.Add(browser);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            browser.Load(textUrl.Text);
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
