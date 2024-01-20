namespace Ado.netCrudFormApp
{
    partial class UpdateForm
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
            button1 = new Button();
            comboBox1_bolge = new ComboBox();
            textBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(580, 168);
            button1.Name = "button1";
            button1.Size = new Size(162, 39);
            button1.TabIndex = 32;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1_bolge
            // 
            comboBox1_bolge.FormattingEnabled = true;
            comboBox1_bolge.Location = new Point(685, 109);
            comboBox1_bolge.Name = "comboBox1_bolge";
            comboBox1_bolge.Size = new Size(103, 23);
            comboBox1_bolge.TabIndex = 31;
            // 
            // textBox
            // 
            textBox.Location = new Point(684, 58);
            textBox.Name = "textBox";
            textBox.Size = new Size(104, 23);
            textBox.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 112);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 27;
            label5.Text = "Bölgesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(543, 61);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 24;
            label2.Text = "Ad - Soyad - Departman";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(534, 295);
            dataGridView1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(581, 230);
            button2.Name = "button2";
            button2.Size = new Size(161, 38);
            button2.TabIndex = 33;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1_bolge);
            Controls.Add(textBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1_bolge;
        private TextBox textBox;
        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
    }
}