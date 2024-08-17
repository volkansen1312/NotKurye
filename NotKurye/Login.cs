

using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NotKurye.DB_Classlar�;
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
                    var kullan�c� = context.Akademisyenler.SingleOrDefault(k => k.AkademikPersonelKimlikNo == GirisId);

                    if (kullan�c� != null)
                    {
                        if (kullan�c�.Parola == Parola)
                        {
                            MessageBox.Show("Say�n " + kullan�c�.Ad + " " + kullan�c�.Soyad + " NotKurye'ye ho�geldiniz.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GlobalDatas.GlobalAkademisyenKimlikNumarasi = GirisId;


                            this.Hide();
                            NotEkleGonder formnoteklegonder = new NotEkleGonder();
                            formnoteklegonder.Show();

                        }
                        else
                        {
                            MessageBox.Show("�ifre yanl��.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Akademik Personel Kimlik Numaras� hi�bir kullan�c� ile e�le�medi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ge�ersiz Akademik Personel Kimlik Numaras�. L�tfen ge�erli bir numara girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            Kay�t_Ol formkayitol = new Kay�t_Ol();
            this.Hide();
            formkayitol.Show();
        }
    }
}

