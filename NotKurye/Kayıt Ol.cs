using NotKurye.DB_Classları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKurye
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
        }

        private void buttonKayitOlustur_Click(object sender, EventArgs e)
        {

            if (long.TryParse(TextBoxId.Text, out long GirisId))
            {
                if( TextBoxParola.Text != textBoxParola2.Text)
                {
                    MessageBox.Show("Girmiş oldğunuz parola ve tekrarı birbiri ile uyuşmuyor.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if(long.TryParse(textBoxTelefonNumarasi.Text,out long telefonno ))
                    {
                        //using (NotkuryeDbContext context = new NotkuryeDbContext()) ;
                        NotkuryeDbContext context = new NotkuryeDbContext() ;
                        Akademisyen akademisyen = new Akademisyen()
                        {
                            AkademikPersonelKimlikNo = Convert.ToInt64(TextBoxId.Text),
                            Parola = TextBoxParola.Text,
                            Ad = textBoxAd.Text,
                            Soyad = textBoxSoyad.Text,
                            Telefon = Convert.ToInt64(textBoxTelefonNumarasi.Text),
                            MailAdres = textBoxMail.Text,
                            DogumTarihi=dateTimeDogumTarihi.Value
                        };
                        context.Add( akademisyen );
                        context.SaveChanges();
                        MessageBox.Show("Sayın "+akademisyen.Ad+" "+akademisyen.Soyad+" kaydınız başarıyla gerçekleşti.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm loginForm = new LoginForm() ;
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz telefon numarası. Lütfen geçerli bir numara girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz Akademik Personel Kimlik Numarası. Lütfen geçerli bir numara girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
