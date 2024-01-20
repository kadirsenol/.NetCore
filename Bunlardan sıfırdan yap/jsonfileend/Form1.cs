namespace jsonfileend
{
    public partial class verigetirlabel : Form
    {
        DosyaCek doscek = new DosyaCek();
        public verigetirlabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            doscek.dosyacek();
            dataGridView1.DataSource = doscek.resultlist;
            MessageBox.Show("asd");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateTable table = new CreateTable();
            table.createtab();
            Insertdb ýnsertdb = new Insertdb();
            ýnsertdb.insertmet(doscek.resultlist);
        }
    }
}
