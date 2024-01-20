namespace xmlmyexample
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label_kuradi = new Label();
            label_alis = new Label();
            label_satis = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(114, 31);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Kurlari Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(246, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label_kuradi
            // 
            label_kuradi.AutoSize = true;
            label_kuradi.Location = new Point(246, 80);
            label_kuradi.Name = "label_kuradi";
            label_kuradi.Size = new Size(46, 15);
            label_kuradi.TabIndex = 2;
            label_kuradi.Text = "Kur Adi";
            // 
            // label_alis
            // 
            label_alis.AutoSize = true;
            label_alis.Location = new Point(246, 106);
            label_alis.Name = "label_alis";
            label_alis.Size = new Size(57, 15);
            label_alis.TabIndex = 3;
            label_alis.Text = "Alis Fiyati";
            // 
            // label_satis
            // 
            label_satis.AutoSize = true;
            label_satis.Location = new Point(246, 130);
            label_satis.Name = "label_satis";
            label_satis.Size = new Size(62, 15);
            label_satis.TabIndex = 4;
            label_satis.Text = "Satis Fiyati";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_satis);
            Controls.Add(label_alis);
            Controls.Add(label_kuradi);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private Label label_kuradi;
        private Label label_alis;
        private Label label_satis;
    }
}
