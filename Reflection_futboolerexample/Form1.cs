using Reflection_futboolerexample.Abstract;
using Reflection_futboolerexample.Concrete;

namespace Reflection_futboolerexample
{
    public partial class Form1 : Form
    {
        Defans puyol;
        Forvet messi;
        Kaleci valdes;
        Ortasaha iniesta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puyol = new Defans("5", "puyol", "Carles")
            {
                atakgucu = "30",
                fizikgucu = "90",
                pasgucu = "80",
                savunmagucu = "90",
                sutgucu = "70"
            };
            listBox1.Items.Add(puyol);

             messi = new Forvet("10", "messi", "leo")
            {
                atakgucu = "100",
                sprintguc = "100",
                pasgucu = "90",
                savunmagucu = "40",
                sutgucu = "80"
            };
            listBox1.Items.Add(messi);  
            valdes = new Kaleci("1", "valdes", "victor")
            {
                atakgucu = "40",
                boy = "90",
                pasgucu = "80",
                savunmagucu = "70",
                sutgucu = "70"
            };
            listBox1.Items.Add(valdes);
            iniesta = new Ortasaha("8", "iniesta", "andreas")
            {
                atakgucu = "40",
                IQSeviyesi = "99",
                pasgucu = "80",
                savunmagucu = "70",
                sutgucu = "70"
            };
            listBox1.Items.Add(iniesta);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            var gelenozellikler = (Futbolcu)listBox1.SelectedItem;
            var gelenyetenekler = (IFutbolcu)listBox1.SelectedItem;
            foreach (var item in gelenozellikler.GetType().GetProperties()) 
            {
                Label label = new Label();
                label.Text = item.Name + " " + item.GetValue(gelenozellikler);
                label.AutoSize = false;
                label.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(label);
            }
            foreach (var item in gelenyetenekler.GetType().GetMethods())
            {
                Label label = new Label();
                label.Text = item.Name;
                label.AutoSize = false;
                label.Width = flowLayoutPanel1.Width;
                flowLayoutPanel1.Controls.Add(label);


               var topcu= (IFutbolcu)listBox1.SelectedItem;
                textBox1.Text = topcu.pasver();
               
               if (listBox1.SelectedIndex==1)
                {
                    textBox2.Text = messi.golat();
                    
                }
               else if (listBox1.SelectedIndex == 0)
                {
                    textBox2.Text = puyol.kafatopucik();
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    textBox2.Text = valdes.toptut();
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    textBox2.Text = iniesta.arapasiver();
                }
            }
        }
    }
}
