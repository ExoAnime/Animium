using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace NeaSQ
{
    public partial class NeaSQ : Form
    {
        public NeaSQ()
        {
            InitializeComponent();
        }

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=Nea;Uid=Nea;Pwd='Nea';");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open(); 
                if (mysqlbaglan.State != ConnectionState.Closed) 
                {
                    MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti"); 
                }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!"); 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
    }
}


