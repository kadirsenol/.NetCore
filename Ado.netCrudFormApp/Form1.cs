using Ado.netCrudFormApp.Concrete;
using System.Data.SqlClient;

namespace Ado.netCrudFormApp
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        string constr = "Server=.;Database=test;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            db.sqlConnection(constr);
            db.Sqlconnection.Open();
            db.Sqlcommand.CommandText = $@"CREATE TABLE [dbo].[Personeller]
                                                       ([Id] [int] IDENTITY(1,1) NOT NULL,
                                                        [Ad] [nvarchar](40) NOT NULL,
                                                        [Soyad] [nvarchar](24) NULL,
                                                        [Departman] [nvarchar](24) NULL,
                                                        [bolgesi] [nvarchar](24) NULL,
                                                        CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED ([Id] ASC))";
            db.ExecuteNonQuary(db.Sqlcommand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reading reading = new Reading();
            reading.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm update2 = new UpdateForm();
            update2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();   
            deleteForm.Show();
            this.Hide();    
        }
    }
}
