namespace NotKurye
{
    partial class NotEkleGonder
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
            groupBox1 = new GroupBox();
            dataGridViewDersListesi = new DataGridView();
            groupBox2 = new GroupBox();
            buttonGonder = new Button();
            textBoxYorum = new TextBox();
            numericUpDown1 = new NumericUpDown();
            radioButtonButunleme = new RadioButton();
            radioButtonFinal = new RadioButton();
            radioButtonVize = new RadioButton();
            dataGridViewOgrenciler = new DataGridView();
            buttonEkleme = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersListesi).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewDersListesi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ders Seçimi";
            // 
            // dataGridViewDersListesi
            // 
            dataGridViewDersListesi.AllowUserToAddRows = false;
            dataGridViewDersListesi.AllowUserToDeleteRows = false;
            dataGridViewDersListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersListesi.GridColor = SystemColors.Info;
            dataGridViewDersListesi.Location = new Point(6, 26);
            dataGridViewDersListesi.Name = "dataGridViewDersListesi";
            dataGridViewDersListesi.ReadOnly = true;
            dataGridViewDersListesi.RowHeadersWidth = 51;
            dataGridViewDersListesi.Size = new Size(770, 148);
            dataGridViewDersListesi.TabIndex = 0;
            dataGridViewDersListesi.CellContentClick += dataGridViewDersListesi_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonEkleme);
            groupBox2.Controls.Add(buttonGonder);
            groupBox2.Controls.Add(textBoxYorum);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(radioButtonButunleme);
            groupBox2.Controls.Add(radioButtonFinal);
            groupBox2.Controls.Add(radioButtonVize);
            groupBox2.Controls.Add(dataGridViewOgrenciler);
            groupBox2.Location = new Point(18, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not Ekleme";


            buttonGonder.Location = new Point(0, 204);
            buttonGonder.Name = "buttonGonder";
            buttonGonder.Size = new Size(766, 40);
            buttonGonder.TabIndex = 7;
            buttonGonder.Text = "Tüm notları öğrencilere gönder";
            buttonGonder.UseVisualStyleBackColor = true;
            buttonGonder.Click += buttonGonder_Click;

            textBoxYorum.Location = new Point(503, 107);
            textBoxYorum.Multiline = true;
            textBoxYorum.Name = "textBoxYorum";
            textBoxYorum.PlaceholderText = "Opsiyonel yorum...";
            textBoxYorum.Size = new Size(263, 29);
            textBoxYorum.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(503, 25);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(263, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // radioButtonButunleme
            // 
            radioButtonButunleme.AutoSize = true;
            radioButtonButunleme.Location = new Point(669, 77);
            radioButtonButunleme.Name = "radioButtonButunleme";
            radioButtonButunleme.Size = new Size(101, 24);
            radioButtonButunleme.TabIndex = 3;
            radioButtonButunleme.TabStop = true;
            radioButtonButunleme.Text = "Bütünleme";
            radioButtonButunleme.UseVisualStyleBackColor = true;
            // 
            // radioButtonFinal
            // 
            radioButtonFinal.AutoSize = true;
            radioButtonFinal.Location = new Point(589, 77);
            radioButtonFinal.Name = "radioButtonFinal";
            radioButtonFinal.Size = new Size(61, 24);
            radioButtonFinal.TabIndex = 2;
            radioButtonFinal.TabStop = true;
            radioButtonFinal.Text = "Final";
            radioButtonFinal.UseVisualStyleBackColor = true;
            // 
            // radioButtonVize
            // 
            radioButtonVize.AutoSize = true;
            radioButtonVize.Location = new Point(506, 77);
            radioButtonVize.Name = "radioButtonVize";
            radioButtonVize.Size = new Size(58, 24);
            radioButtonVize.TabIndex = 1;
            radioButtonVize.TabStop = true;
            radioButtonVize.Text = "Vize";
            radioButtonVize.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.AllowUserToAddRows = false;
            dataGridViewOgrenciler.AllowUserToDeleteRows = false;
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new Point(6, 25);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.ReadOnly = true;
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.Size = new Size(473, 173);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // buttonEkleme
            // 
            buttonEkleme.Location = new Point(503, 154);
            buttonEkleme.Name = "buttonEkleme";
            buttonEkleme.Size = new Size(263, 34);
            buttonEkleme.TabIndex = 8;
            buttonEkleme.Text = "Ekle";
            buttonEkleme.UseVisualStyleBackColor = true;
            buttonEkleme.Click += buttonEkleme_Click_1;
            // 
            // NotEkleGonder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NotEkleGonder";
            Text = "NotEkleGonder";
            Load += NotEkleGonder_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersListesi).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewDersListesi;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOgrenciler;
        private RadioButton radioButtonFinal;
        private RadioButton radioButtonVize;
        private RadioButton radioButtonButunleme;
        private NumericUpDown numericUpDown1;
        private TextBox textBoxYorum;
        private Button buttonGonder;
        private Button buttonEkleme;
    }
}