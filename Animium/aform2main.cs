using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;

namespace Animium
{
    public partial class aform2main : Form
    {
        public String html;
        public Uri url;
        public aform2main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 14; i++)
            {
                VeriAl("http://www.anime1.com/watch/009-1", "//*[@id='center']/div[2]/div[2]/div[1]/ul/li[" + i + "]/a", "href", comboBox1);
            }
        }
        public void VeriAl(string Url,String XPath,String dip, ComboBox CıkanSonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if (MessageBox.Show("Hatalı Url)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı Url)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı Url)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                CıkanSonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).Attributes[dip].Value);
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aform2watch f4 = new aform2watch();
            f4.textBox1.Text = comboBox1.SelectedItem.ToString();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aform2list f2 = new aform2list();
            f2.Show();
        }
    }
}
