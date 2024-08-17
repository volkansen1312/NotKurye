

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NotKurye.DB_Classlarý;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotKurye
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            NotkuryeDbContext context = new NotkuryeDbContext(); 
        }
        //public long akademisyenKimlik { get; set; }
        private void ButtonGiris_Click(object sender, EventArgs e)
        {
            
            if (long.TryParse(TextBoxId.Text, out long GirisId))
            {
                string Parola = TextBoxParola.Text;
                

                using (NotkuryeDbContext context = new NotkuryeDbContext())
                {
                    var kullanýcý = context.Akademisyenler.SingleOrDefault(k => k.AkademikPersonelKimlikNo == GirisId);

                    if (kullanýcý != null)
                    {
                        if (kullanýcý.Parola == Parola)
                        {
                            MessageBox.Show("Sayýn " + kullanýcý.Ad + " " + kullanýcý.Soyad + " NotKurye'ye hoþgeldiniz.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GlobalDatas.GlobalAkademisyenKimlikNumarasi = GirisId;


                            this.Hide();
                            NotEkleGonder formnoteklegonder = new NotEkleGonder();
                            formnoteklegonder.Show();

                        }
                        else
                        {
                            MessageBox.Show("Þifre yanlýþ.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Akademik Personel Kimlik Numarasý hiçbir kullanýcý ile eþleþmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geçersiz Akademik Personel Kimlik Numarasý. Lütfen geçerli bir numara girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            Kayýt_Ol formkayitol = new Kayýt_Ol();
            this.Hide();
            formkayitol.Show();
        }
    }
}

