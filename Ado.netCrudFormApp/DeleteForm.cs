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
    public partial class DeleteForm : Form
    {
        Database db = new Database();
        string constr = "Server=.;Database=test;Trusted_Connection=True;";
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso = db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;
            db.Sqlconnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string where = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = $@"DELETE FROM [dbo].[Personeller]
                                                      WHERE Id= {where}";
            db.Sqlcommand.ExecuteNonQuery();
            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso = db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;
            db.Sqlconnection.Close();
            MessageBox.Show("Delete successful !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
