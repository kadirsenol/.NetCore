namespace telefonses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basephone basetel = new basephone();
            basetel.ses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samsung samsungtel = new samsung();
            samsungtel.ses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            iphone iphonetel = new iphone();
            iphonetel.ses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nokia nokiatel= new nokia();    
            nokiatel.ses();
        }
    }
}
