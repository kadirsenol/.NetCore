using Ado.Net__Veri_tabanından_veri_çekme_.DB;
using Ado.Net__Veri_tabanından_veri_çekme_.Satis;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

namespace Ado.Net__Veri_tabanından_veri_çekme_
{
    public partial class Form1 : Form
    {
        const string sqlfilm = "Select * from Filmler";
        const string sqlhafta = "Select * from Haftalar";
        const string sqlkategori = "Select * from Kategoriler";
        const string sqlsalon = "Select * from Salonlar";
        const string sqlseans = "Select * from Seanslar";
        const string constr = $@"Data Source=.;Initial Catalog=SinemaOtomasyon;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True";
        SqlConnection kop;
        SqlCommand komut;
        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SinemaOtomasyonDB sinema = new SinemaOtomasyonDB();

            kop = new SqlConnection(constr);
            komut = new SqlCommand(sqlfilm, kop);
            kop.Open();
            reader = komut.ExecuteReader();

            sinema.Filmler = new List<Film>();
            Film film1 = new Film();
            while (reader.Read())
            {
                film1.FilmAdi = reader["FilmAdi"].ToString();
                film1.Aciklama = reader["Aciklama"].ToString();
                film1.Id = int.Parse(reader["Id"].ToString());
                film1.Sure = short.Parse(reader["Sure"].ToString());
                sinema.Filmler.Add(film1);
                comboBoxFilm.Items.Add(film1.FilmAdi);
            }
            reader.Close();


            komut = new SqlCommand(sqlhafta, kop);
            reader = komut.ExecuteReader();

            sinema.Haftalar = new List<Hafta>();
            Hafta hafta = new Hafta();
            while (reader.Read())
            {
                hafta.HaftaAdi = reader["HaftaAdi"].ToString();
                hafta.Baslangic = DateTime.Parse(reader["Baslangic"].ToString());
                hafta.Id = int.Parse(reader["Id"].ToString());
                hafta.Bitis = DateTime.Parse(reader["Bitis"].ToString());
                sinema.Haftalar.Add(hafta);
                comboBoxHafta.Items.Add(hafta.Baslangic);
            }
            reader.Close();

            komut = new SqlCommand(sqlkategori, kop);
            reader = komut.ExecuteReader();
            Kategori kategori = new Kategori();
            sinema.Kategoriler = new List<Kategori>();
            while (reader.Read())
            {
                kategori.Id = int.Parse(reader["Id"].ToString());
                kategori.KategoriAdi = reader["KategoriAdi"].ToString();
                sinema.Kategoriler.Add(kategori);

            }
            reader.Close();

            komut = new SqlCommand(sqlsalon, kop);
            reader = komut.ExecuteReader();
            Salon salon = new Salon();
            sinema.Salonlar = new List<Salon>();
            while (reader.Read())
            {
                salon.Id = int.Parse(reader["Id"].ToString());
                salon.SalonAdi = reader["SalonAdi"].ToString();
                salon.Kapasite = int.Parse(reader["Kapasite"].ToString());
                sinema.Salonlar.Add(salon);
                comboBoxSalon.Items.Add(salon.SalonAdi);
            }
            reader.Close();

            komut = new SqlCommand(sqlseans, kop);
            reader = komut.ExecuteReader();
            Seans seans = new Seans();
            sinema.Seanslar = new List<Seans>();
            while (reader.Read())
            {
                seans.Id = int.Parse(reader["Id"].ToString());
                seans.seans = TimeOnly.Parse(reader["Seans"].ToString());
                sinema.Seanslar.Add(seans);
                comboBoxSeans.Items.Add(seans.seans);
            }

            reader.Close();
            kop.Close();


            #region Enum verilerini manuel girmek
            //sinema.Yonetmenler = new List<yonetmenadi>();
            //sinema.Yonetmenler.Add(yonetmenadi.mehmet);//Liste tipinde olduğu için böyle ekleyebilirsin.
            //                                           //Eğer liste tipinde olmasaydı;
            //                                           //sinema.Yonetmenler=yonetmenadi.mehmet; şeklinde eklerdik
            //sinema.Yonetmenler.Add(yonetmenadi.ali);
            //sinema.Yonetmenler.Add(yonetmenadi.alper);
            //sinema.Yonetmenler.Add(yonetmenadi.mehmet);
            //sinema.Yonetmenler.Add(yonetmenadi.ahmet); 
            #endregion

            #region Enum.Parse
            //comboBoxyonetmen.Items.Add(Enum.Parse(typeof(yonetmenadi), "ali"));
            //comboBoxyonetmen.Items.Add(Enum.Parse(typeof(yonetmenadi), "ahmet"));
            //comboBoxyonetmen.Items.Add(Enum.Parse(typeof(yonetmenadi), "mehmet"));
            //comboBoxyonetmen.Items.Add(Enum.Parse(typeof(yonetmenadi), "alper")); 
            #endregion


            #region Enum.GetNames and Enum.GetName
            comboBoxyonetmen.Items.AddRange(Enum.GetNames(typeof(yonetmenadi))); //Add.(Enum.GetName(typeof(yonetmenadi,1)))
            #endregion


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        Satislar satislist = new Satislar();
        //satislist.satislar = new List<satis>(); // prop kısmında newlendi.

        private void button1_Click(object sender, EventArgs e)
        {
            satis satis1 = new satis();
            satis1.kisiadi = textBoxAd.Text;
            satis1.kisisoyadi = textBoxSoyad.Text;
            satis1.Filmadi = comboBoxFilm.SelectedItem.ToString();
            satis1.Salon = comboBoxSalon.SelectedItem.ToString();
            satis1.Seans = comboBoxSeans.SelectedItem.ToString();
            satis1.Hafta = comboBoxHafta.SelectedItem.ToString();
            
            satislist.satislar.Add(satis1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= satislist.satislar;
            

        }
    }
}
