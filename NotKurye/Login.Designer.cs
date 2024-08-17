namespace NotKurye
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            buttonKayitOl = new Button();
            label2 = new Label();
            label1 = new Label();
            ButtonGiris = new Button();
            TextBoxParola = new TextBox();
            TextBoxId = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonKayitOl);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonGiris);
            groupBox1.Controls.Add(TextBoxParola);
            groupBox1.Controls.Add(TextBoxId);
            groupBox1.Location = new Point(6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lütfen gerekli alanları doldurunuz.";
            // 
            // buttonKayitOl
            // 
            buttonKayitOl.BackColor = SystemColors.Control;
            buttonKayitOl.BackgroundImageLayout = ImageLayout.Stretch;
            buttonKayitOl.Location = new Point(6, 189);
            buttonKayitOl.Name = "buttonKayitOl";
            buttonKayitOl.Size = new Size(422, 29);
            buttonKayitOl.TabIndex = 6;
            buttonKayitOl.Text = "Kayıt Ol";
            buttonKayitOl.UseVisualStyleBackColor = false;
            buttonKayitOl.Click += buttonKayitOl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 4;
            label1.Text = "Akademik Personel Kimlik Numarası";
            // 
            // ButtonGiris
            // 
            ButtonGiris.BackColor = SystemColors.Control;
            ButtonGiris.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonGiris.ForeColor = SystemColors.ActiveCaptionText;
            ButtonGiris.Location = new Point(6, 154);
            ButtonGiris.Name = "ButtonGiris";
            ButtonGiris.Size = new Size(423, 29);
            ButtonGiris.TabIndex = 2;
            ButtonGiris.Text = "Giriş";
            ButtonGiris.UseVisualStyleBackColor = false;
            ButtonGiris.Click += ButtonGiris_Click;
            // 
            // TextBoxParola
            // 
            TextBoxParola.Location = new Point(7, 111);
            TextBoxParola.Name = "TextBoxParola";
            TextBoxParola.PasswordChar = '*';
            TextBoxParola.PlaceholderText = "Parola giriniz.";
            TextBoxParola.Size = new Size(423, 27);
            TextBoxParola.TabIndex = 1;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(7, 56);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.PlaceholderText = "Akademik Personel Kimlik Numarası giriniz.";
            TextBoxId.Size = new Size(423, 27);
            TextBoxId.TabIndex = 0;
            // 
            // LoginForm
            // 
            AcceptButton = ButtonGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(448, 238);
            Controls.Add(groupBox1);
            KeyPreview = true;
            Name = "LoginForm";
            Text = "Giriş";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonGiris;
        private TextBox TextBoxParola;
        private TextBox TextBoxId;
        private Label label2;
        private Label label1;
        private Button buttonKayitOl;
    }
}
