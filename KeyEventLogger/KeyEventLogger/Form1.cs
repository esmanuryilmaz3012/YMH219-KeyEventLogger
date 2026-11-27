using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KeyEventLogger
{
    public partial class Form1 : Form
    {
        // Kaydın açık olup olmadığını tutan durum değişkeni
        private bool kayitAktif = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Başlat butonu: kaydı açar
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kayitAktif = true;
            lblDurum.Text = "Kayıt: Açık";
            lblDurum.BackColor = Color.LightGreen;
        }

        // Durdur butonu: kaydı kapatır
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            KayitiDurdur();
        }

        // Kaydı durdurur ve durum etiketini günceller
        private void KayitiDurdur()
        {
            kayitAktif = false;
            lblDurum.Text = "Kayıt: Kapalı";
            lblDurum.BackColor = Color.LightCoral;
        }

        // Temizle butonu: listedeki tüm kayıtları siler
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstKayitlar.Items.Clear();
        }

        // Kaydet butonu: kayıtları dosyaya yazar 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KayitiDurdur();
            // Listede hiç kayıt yoksa dosya oluşturmaya gerek yok
            if (lstKayitlar.Items.Count == 0)
            {
                MessageBox.Show("Kaydedilecek kayıt yok.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kullanıcıya kayıt dosyasının adını ve yerini seçtir
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Metin dosyası (*.txt)|*.txt";
                dialog.FileName = "tus_kayitlari.txt";

                // Kullanıcı Vazgeç derse hiçbir şey yapma
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // Dosyayı yaz: her liste öğesi dosyada bir satır olur
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        foreach (object satir in lstKayitlar.Items)
                        {
                            writer.WriteLine(satir.ToString());
                        }
                    }

                    MessageBox.Show("Kayıtlar başarıyla kaydedildi.", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Dosya yazılırken hata oluştu:\n" + ex.Message, "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Bu konuma yazma izniniz yok. Başka bir klasör seçin.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Form herhangi bir tuşa basıldığında çalışır
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kayıt kapalıysa hiçbir şey yapmadan çık
            if (!kayitAktif)
                return;

            // Saati "14:05:33" biçiminde al
            string zaman = DateTime.Now.ToString("HH:mm:ss");

            // Tuş adını ve saati listeye tek satır olarak ekle
            lstKayitlar.Items.Add($"{zaman}  {e.KeyCode,-12}");
        }
    }
}