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
    public partial class Reading : Form
    {
        Database db = new Database();
        string constr = "Server=.;Database=test;Trusted_Connection=True;";
        public Reading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso = db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;

            MessageBox.Show("Listing is complated.");
            db.Sqlconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
