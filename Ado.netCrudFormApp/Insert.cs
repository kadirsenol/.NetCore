using Ado.netCrudFormApp.Abstract;
using Ado.netCrudFormApp.Concrete;
using Ado.netCrudFormApp.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.netCrudFormApp
{
    public partial class Insert : Form
    {
        Database db = new Database();
        string constr = "Server=.;Database=test;Trusted_Connection=True;";
        public Insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = $@"INSERT INTO [dbo].[Personeller]
                                                          ([Ad]
                                                          ,[Soyad]
                                                          ,[Departman]
                                                          ,[bolgesi])
                                                    VALUES
                                                          ('{textBox_ad.Text}',
                                                          '{textBox_soyad.Text}',
                                                          '{textBox_departman.Text}',
                                                          '{comboBox1_bolge.SelectedItem.ToString()}')";
            db.ExecuteNonQuary(db.Sqlcommand);
            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso =db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;
            MessageBox.Show("Insert is complated.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            #region Enum verilerini manuel girmek
            //Personeller personellerr = new Personeller();
            //personellerr.personeller = new List<Personel>();
            //Personel personel = new Personel();
            //personel.bolgesi = Bolge.Karadeniz;
            //personellerr.personeller.Add(personel);
            //comboBox1_bolge.Items.Add(personellerr.personeller[0].bolgesi);    
            #endregion

            #region Enum.Parse
            //comboBox1_bolge.Items.Add(Enum.Parse(typeof(Bolge), "Marmara"));
            //comboBox1_bolge.Items.Add(Enum.Parse(typeof(Bolge), "Ege"));
            //comboBox1_bolge.Items.Add(Enum.Parse(typeof(Bolge), "Karadeniz"));
            //comboBox1_bolge.Items.Add(Enum.Parse(typeof(Bolge), "Akdeniz"));

            #endregion

            #region Enum.GetNames and Enum.GetName
            comboBox1_bolge.Items.AddRange(Enum.GetNames(typeof(Bolge)));
            #endregion
        }
    }
}
