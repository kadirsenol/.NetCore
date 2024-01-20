namespace Ado.Net__Veri_tabanından_veri_çekme_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxFilm = new ComboBox();
            comboBoxHafta = new ComboBox();
            comboBoxSeans = new ComboBox();
            comboBoxSalon = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label7 = new Label();
            comboBoxyonetmen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Film";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 49);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Hafta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 78);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Seans";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 107);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Salon";
            // 
            // comboBoxFilm
            // 
            comboBoxFilm.FormattingEnabled = true;
            comboBoxFilm.Location = new Point(72, 12);
            comboBoxFilm.Name = "comboBoxFilm";
            comboBoxFilm.Size = new Size(121, 23);
            comboBoxFilm.TabIndex = 4;
            // 
            // comboBoxHafta
            // 
            comboBoxHafta.FormattingEnabled = true;
            comboBoxHafta.Location = new Point(72, 46);
            comboBoxHafta.Name = "comboBoxHafta";
            comboBoxHafta.Size = new Size(121, 23);
            comboBoxHafta.TabIndex = 5;
            comboBoxHafta.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBoxSeans
            // 
            comboBoxSeans.FormattingEnabled = true;
            comboBoxSeans.Location = new Point(72, 75);
            comboBoxSeans.Name = "comboBoxSeans";
            comboBoxSeans.Size = new Size(121, 23);
            comboBoxSeans.TabIndex = 6;
            // 
            // comboBoxSalon
            // 
            comboBoxSalon.FormattingEnabled = true;
            comboBoxSalon.Location = new Point(72, 104);
            comboBoxSalon.Name = "comboBoxSalon";
            comboBoxSalon.Size = new Size(121, 23);
            comboBoxSalon.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 11);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Adınız:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 46);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 9;
            label6.Text = "Soy Adınız:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(405, 7);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(100, 23);
            textBoxAd.TabIndex = 10;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(405, 43);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(100, 23);
            textBoxSoyad.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(571, 150);
            dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(72, 183);
            button1.Name = "button1";
            button1.Size = new Size(433, 27);
            button1.TabIndex = 14;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 141);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 15;
            label7.Text = "Yonetmen";
            // 
            // comboBoxyonetmen
            // 
            comboBoxyonetmen.FormattingEnabled = true;
            comboBoxyonetmen.Location = new Point(72, 138);
            comboBoxyonetmen.Name = "comboBoxyonetmen";
            comboBoxyonetmen.Size = new Size(121, 23);
            comboBoxyonetmen.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxyonetmen);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxSalon);
            Controls.Add(comboBoxSeans);
            Controls.Add(comboBoxHafta);
            Controls.Add(comboBoxFilm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxFilm;
        private ComboBox comboBoxHafta;
        private ComboBox comboBoxSeans;
        private ComboBox comboBoxSalon;
        private Label label5;
        private Label label6;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label7;
        private ComboBox comboBoxyonetmen;
    }
}
