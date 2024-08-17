using Microsoft.EntityFrameworkCore;
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
using System.Net;
using System.Net.Mail;

namespace NotKurye
{
    public partial class NotEkleGonder : Form
    {
        LoginForm loginform = new LoginForm();
        public List<GonderilenMailIcerikleri> gonderilenMailIcerikler;
        public NotEkleGonder()
        {
            InitializeComponent();
            gonderilenMailIcerikler = new List<GonderilenMailIcerikleri>();
        }

        private void NotEkleGonder_Load(object sender, EventArgs e)
        {
            LoadDersler();
        }
        private void LoadDersler()
        {
            NotkuryeDbContext context = new NotkuryeDbContext();
            var akademisyen = context.Akademisyenler
            .Where(a => a.AkademikPersonelKimlikNo == GlobalDatas.GlobalAkademisyenKimlikNumarasi)
            .SelectMany(a => a.Dersler)
            .Select(d => new
            {
                d.DersKodu,
                d.DersAdi,
                d.Kredi,
                d.Acts
            })
            .ToList();

            dataGridViewDersListesi.DataSource = akademisyen;

            dataGridViewDersListesi.Columns["DersKodu"].HeaderText = "Ders Kodu";
            dataGridViewDersListesi.Columns["DersAdi"].HeaderText = "Ders Adı";
            dataGridViewDersListesi.Columns["Kredi"].HeaderText = "Kredi";
            dataGridViewDersListesi.Columns["Acts"].HeaderText = "Acts";

            dataGridViewDersListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            groupBox2.Visible = false;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
        }

        private void dataGridViewDersListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                groupBox2.Visible = true;
                var dersadi = dataGridViewDersListesi.Rows[e.RowIndex].Cells["DersAdi"].Value.ToString();
                NotkuryeDbContext context = new NotkuryeDbContext();
                var ogrenciler = context.Ogrenciler.Where(o => o.Dersler.Any(d => d.DersAdi == dersadi)).Select(o => new { o.OgrenciNo, o.Ad, o.Soyad, o.MailAdres }).ToList();

                dataGridViewOgrenciler.DataSource = ogrenciler;

                dataGridViewOgrenciler.Columns["OgrenciNo"].HeaderText = "Öğrenci No";
                dataGridViewOgrenciler.Columns["Ad"].HeaderText = "Ad";
                dataGridViewOgrenciler.Columns["Soyad"].HeaderText = "Soyad";
                dataGridViewOgrenciler.Columns["MailAdres"].HeaderText = "Mail Adres";

                dataGridViewOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 0 || numericUpDown1.Value > 100)
            {
                MessageBox.Show("Lütfen 0 ile 100 arasında bir değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericUpDown1.Value = 0;
            }
        }

        private void buttonEkleme_Click_1(object sender, EventArgs e)
        {
            if (!radioButtonVize.Checked && !radioButtonFinal.Checked && !radioButtonButunleme.Checked)
            {
                MessageBox.Show("Lütfen bir sınav türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mailAdres = dataGridViewOgrenciler.CurrentRow.Cells["MailAdres"].Value.ToString();


            string sinavTuru = "";
            if (radioButtonVize.Checked)
            {
                sinavTuru = "Vize";
            }
            else if (radioButtonFinal.Checked)
            {
                sinavTuru = "Final";
            }
            else if (radioButtonButunleme.Checked)
            {
                sinavTuru = "Bütünleme";
            }
            int puan = (int)numericUpDown1.Value;
            GonderilenMailIcerikleri icerik = new()
            {
                OgrenciNo = dataGridViewOgrenciler.CurrentRow.Cells["OgrenciNo"].Value.ToString(),
                OgrenciAdi = dataGridViewOgrenciler.CurrentRow.Cells["Ad"].Value.ToString(),
                OgrenciSoyadi = dataGridViewOgrenciler.CurrentRow.Cells["Soyad"].Value.ToString(),
                DersAdi = dataGridViewDersListesi.CurrentRow.Cells["DersAdi"].Value.ToString(),
                SinavTuru = sinavTuru,
                Not = Convert.ToInt32(numericUpDown1.Value),
                Mesaj = textBoxYorum.Text,
                OgrenciMailHesabi = mailAdres
            };
            gonderilenMailIcerikler.Add(icerik);
            NotkuryeDbContext context = new NotkuryeDbContext();
            context.MailIcerikleri.Add(icerik);
            context.SaveChanges();

            MessageBox.Show("Kayıt başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxYorum.Text = "";
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            NotkuryeDbContext context = new NotkuryeDbContext();

            foreach (var item in context.MailIcerikleri)
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("notkurye@gmail.com", "etki yapu qytr clbt");
                istemci.Port = 587;
                istemci.Host = "smtp.gmail.com";
                istemci.EnableSsl = true;
                mesaj.To.Add(item.OgrenciMailHesabi);
                mesaj.From = new MailAddress("notkurye@gmail.com");
                mesaj.Subject = "Sınav Notu İlanı";
                mesaj.Body = $"Sayın {item.OgrenciAdi} {item.OgrenciSoyadi},\n\n" +
                            $"{item.DersAdi} {item.SinavTuru} sınavından aldığınız not: {item.Not}\n" +
                            $"Dersi veren akademisyenin mesajı: {item.Mesaj}\n\n" +
                            "Başarılar dileriz.";
                istemci.Send(mesaj);
            }
            MessageBox.Show("Mail başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var veriler = context.MailIcerikleri.ToList();
            context.MailIcerikleri.RemoveRange(veriler);
            context.SaveChanges();
        }
    }
}
