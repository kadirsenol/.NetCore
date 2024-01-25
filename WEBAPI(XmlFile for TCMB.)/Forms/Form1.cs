using Dapper;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Xml;
using WEBAPI_XmlFile_for_TCMB._.Concrete;
using WEBAPI_XmlFile_for_TCMB_.Models;

namespace WEBAPI_XmlFile_for_TCMB._
{
    public partial class Form1 : Form
    {

        webclient wc = new webclient();
        SqlConnection connection = new SqlConnection($@"Server=.;Database=Northwind;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            wc.WC();

            foreach (var item in wc.Dovizler.dovizler)
            {
                comboBox_dovizadlari.Items.Add(item.Currency);


            }
            comboBox_dovizadlari.Tag = wc.Dovizler;

        }

        private void comboBox_dovizadlari_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dovizler doviz1 = (Dovizler)comboBox_dovizadlari.Tag;
            textBox_alýþ.Text = doviz1.dovizler[comboBox_dovizadlari.SelectedIndex].ForexBuying;
            textBox_satýþ.Text = doviz1.dovizler[comboBox_dovizadlari.SelectedIndex].ForexSelling;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = wc.Dovizler.dovizler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxtable.Text))||(!string.IsNullOrEmpty(textBox_dbname.Text)))
            {
                try
                {
                    connection.Execute($@"CREATE DATABASE {textBox_dbname.Text}");
                    connection.Execute($@"USE [{textBox_dbname.Text}]
                                            CREATE TABLE [dbo].[{textBoxtable.Text}](
                                            	[Currency] [nvarchar](50) NULL,
                                                [ForexBuying] [decimal](18,4) NULL,
                                                [ForexSelling][nvarchar](50) NULL
                                            ) ON [PRIMARY]
                                            ");
                    MessageBox.Show(@$"Veritabaný ve tablo baþarýyla oluþturuldu!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($@"Eðer oluþturmak istediðiniz veritabanýnýz mevcut ise kontrol ediniz.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in wc.Dovizler.dovizler)
            {
                connection.Execute($@"USE [TCMB]
                                                INSERT INTO [dbo].[Dövizler]
                                                           ([Currency]
                                                           ,[ForexBuying]
                                                           ,[ForexSelling])
                                                     VALUES
                                                           ('{item.Currency}'
                                                           ,'{item.ForexBuying}'
                                                           ,'{item.ForexSelling}')");
            }
            MessageBox.Show("Veri tabanýna kayýt iþlemi baþarýyla gerçekleþti. !");
        }
    }
}
