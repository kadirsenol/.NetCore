namespace WEBAPI_XmlFile_for_TCMB._
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_dovizadlari = new ComboBox();
            textBox_alış = new TextBox();
            textBox_satış = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            textBoxtable = new TextBox();
            textBox_dbname = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Döviz Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 16);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Döviz Alış";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 16);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Döviz Satış";
            // 
            // comboBox_dovizadlari
            // 
            comboBox_dovizadlari.FormattingEnabled = true;
            comboBox_dovizadlari.Location = new Point(71, 38);
            comboBox_dovizadlari.Name = "comboBox_dovizadlari";
            comboBox_dovizadlari.Size = new Size(117, 23);
            comboBox_dovizadlari.TabIndex = 4;
            comboBox_dovizadlari.SelectedIndexChanged += comboBox_dovizadlari_SelectedIndexChanged;
            // 
            // textBox_alış
            // 
            textBox_alış.Location = new Point(228, 38);
            textBox_alış.Name = "textBox_alış";
            textBox_alış.Size = new Size(58, 23);
            textBox_alış.TabIndex = 5;
            // 
            // textBox_satış
            // 
            textBox_satış.Location = new Point(331, 38);
            textBox_satış.Name = "textBox_satış";
            textBox_satış.Size = new Size(63, 23);
            textBox_satış.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(38, 99);
            button1.Name = "button1";
            button1.Size = new Size(165, 55);
            button1.TabIndex = 8;
            button1.Text = "Dövizleri Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(100, 254);
            button2.Name = "button2";
            button2.Size = new Size(117, 26);
            button2.TabIndex = 21;
            button2.Text = "Veri Tabanı Oluştur\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 228);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 20;
            label4.Text = "Tablo Adı";
            // 
            // button3
            // 
            button3.Location = new Point(114, 298);
            button3.Name = "button3";
            button3.Size = new Size(103, 42);
            button3.TabIndex = 19;
            button3.Text = "Verileri Veri Tabanına Aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxtable
            // 
            textBoxtable.Location = new Point(145, 225);
            textBoxtable.Name = "textBoxtable";
            textBoxtable.Size = new Size(58, 23);
            textBoxtable.TabIndex = 18;
            // 
            // textBox_dbname
            // 
            textBox_dbname.Location = new Point(145, 185);
            textBox_dbname.Name = "textBox_dbname";
            textBox_dbname.Size = new Size(58, 23);
            textBox_dbname.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 188);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 16;
            label5.Text = "Veri Tabanı Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(253, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 265);
            dataGridView1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 366);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBoxtable);
            Controls.Add(textBox_dbname);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox_satış);
            Controls.Add(textBox_alış);
            Controls.Add(comboBox_dovizadlari);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_dovizadlari;
        private TextBox textBox_alış;
        private TextBox textBox_satış;
        private Button button1;
        private Button button2;
        private Label label4;
        private Button button3;
        private TextBox textBoxtable;
        private TextBox textBox_dbname;
        private Label label5;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}
