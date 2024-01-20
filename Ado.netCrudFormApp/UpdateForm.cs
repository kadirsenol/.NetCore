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
    public partial class UpdateForm : Form
    {
        Database db = new Database();
        string constr = "Server=.;Database=test;Trusted_Connection=True;";
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string where= dataGridView1.CurrentRow.Cells[0].Value.ToString();
           int index = dataGridView1.CurrentCell.ColumnIndex;
           string columnName="";
            string value = "";
            switch (index)
            {
                case 1:
                    columnName = "Ad";
                    break;
                case 2:
                    columnName = "Soyad";
                    break;
                case 3:
                    columnName = "Departman";
                    break;
                case 4:
                    columnName = "bolgesi";
                    break;
                default:
                    break;
            }
            if (columnName=="bolgesi")
            {
                value = comboBox1_bolge.SelectedItem.ToString();
            }
            else
            {
                value = textBox.Text;
            }
            string updatestr = $@"UPDATE [dbo].[Personeller]
                     SET [{columnName}] = '{value}' WHERE Id= {where}";
            

            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = updatestr;
            db.Sqlcommand.ExecuteNonQuery();

            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso = db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;
            db.Sqlconnection.Close();
            MessageBox.Show("Update successful !");

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = "Select * from Personeller";
            Personeller perso = db.ExecuteReader(db.Sqlcommand);
            dataGridView1.DataSource = perso.personeller;
            db.Sqlconnection.Close();
            comboBox1_bolge.Items.AddRange(Enum.GetNames(typeof(Bolge)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
