using System.Net;
using System.Text;
using System.Xml;

namespace xmlmyexample
{
    public partial class Form1 : Form
    {
        XmlDocument xmldoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.Default;
            string firstdata = wc.DownloadString(url);

            xmldoc.LoadXml(firstdata);

            XmlNodeList nodeler = xmldoc.DocumentElement.ChildNodes;
            foreach (XmlNode node in nodeler)
            {
                string kuradi = node.ChildNodes[2].InnerText;
                comboBox1.Items.Add(kuradi);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedIndex != -1)//�uan i�erisinde oldu�umuz metod zaten combobox in se�ilen in
                                                 //indexi de�i�ti�inde dedi�i i�in mecbur se�ilen index -1 den
                                                 //farkl� olmak zorunda. ama bu if ile yine de kesin se�ilme
                                                 //oldu�unda deli g�mle�ini giydirmi� oluyoruz
                                              
            {

                //kullanmanda fayda var kullanmasanda olur
                label_kuradi.ResetText();
                label_alis.ResetText();
                label_satis.ResetText();

                label_kuradi.Text =xmldoc.DocumentElement.ChildNodes[comboBox1.SelectedIndex].ChildNodes[2].InnerText;
              label_alis.Text = xmldoc.DocumentElement.ChildNodes[comboBox1.SelectedIndex].ChildNodes[3].InnerText;
              label_satis.Text = xmldoc.DocumentElement.ChildNodes[comboBox1.SelectedIndex].ChildNodes[4].InnerText;
            }
        }
    }
}
