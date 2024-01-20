namespace Ado.netCrudFormApp
{
    partial class Insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_ad = new TextBox();
            textBox_soyad = new TextBox();
            textBox_departman = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1_bolge = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 247);
            dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(570, 49);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 75);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 103);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Departman";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 132);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 5;
            label5.Text = "Bölgesi";
            // 
            // textBox_ad
            // 
            textBox_ad.Location = new Point(638, 41);
            textBox_ad.Name = "textBox_ad";
            textBox_ad.Size = new Size(104, 23);
            textBox_ad.TabIndex = 7;
            // 
            // textBox_soyad
            // 
            textBox_soyad.Location = new Point(638, 70);
            textBox_soyad.Name = "textBox_soyad";
            textBox_soyad.Size = new Size(104, 23);
            textBox_soyad.TabIndex = 8;
            // 
            // textBox_departman
            // 
            textBox_departman.Location = new Point(638, 100);
            textBox_departman.Name = "textBox_departman";
            textBox_departman.Size = new Size(104, 23);
            textBox_departman.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(70, 284);
            button1.Name = "button1";
            button1.Size = new Size(386, 35);
            button1.TabIndex = 11;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 325);
            button2.Name = "button2";
            button2.Size = new Size(133, 31);
            button2.TabIndex = 12;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1_bolge
            // 
            comboBox1_bolge.FormattingEnabled = true;
            comboBox1_bolge.Location = new Point(638, 130);
            comboBox1_bolge.Name = "comboBox1_bolge";
            comboBox1_bolge.Size = new Size(103, 23);
            comboBox1_bolge.TabIndex = 13;
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 414);
            Controls.Add(comboBox1_bolge);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_departman);
            Controls.Add(textBox_soyad);
            Controls.Add(textBox_ad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Insert";
            Text = "Insert";
            Load += Insert_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_ad;
        private TextBox textBox_soyad;
        private TextBox textBox_departman;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1_bolge;
    }
}