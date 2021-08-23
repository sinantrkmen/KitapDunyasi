using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitapDunyasi
{
    public partial class KitapDünyası_Kitap : Form
    {
        public KitapDünyası_Kitap()
        {
            InitializeComponent();
        }

        
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=kitapKiralama;" +
            "user ID=postgres;password=root"); 
        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kitap";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("INSERT INTO kitap (kitapid, dilid, adi,isbn, sayfa_sayisi," +
                " basim_tarihi, kiralama_fiyati,kiralama_suresi,son_guncelleme_tarihi ) " +
                "values  (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtKitapId.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(txtdilId.Text));
            komut1.Parameters.AddWithValue("@p3", txtAdi.Text);
            komut1.Parameters.AddWithValue("@p4", long.Parse(txtISBN.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(txtSayfaSayisi.Text));
            komut1.Parameters.AddWithValue("@p6", DateTime.Parse(txtBasimTarihi.Text));
            komut1.Parameters.AddWithValue("@p7", Decimal.Parse(txtKiralamaFiyati.Text));
            komut1.Parameters.AddWithValue("@p8", int.Parse(textKiralamaSuresi.Text));
            komut1.Parameters.AddWithValue("@p9", DateTime.Parse(txtSonGuncellemeTarihi.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap ekleme işlemi başarı ile gerçekleştirildi");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

        }

        private void txtKitapId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("Delete From kitap WHERE kitapid=@pr1",baglanti);
            komut2.Parameters.AddWithValue("@pr1", int.Parse(txtKitapId.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleştirildi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("UPDATE kitap SET dilid=@prm1,adi=@prm2,isbn=@prm3,sayfa_sayisi=@prm4" +
                "basim_tarihi=@prm5,kiralama_fiyati=@prm6,kiralama_suresi=@prm7,son_guncelleme_tarihi=@prm8 where kitapid=@prm9", baglanti);
            
            komut3.Parameters.AddWithValue("@prm1", int.Parse(txtdilId.Text));
            komut3.Parameters.AddWithValue("@prm2", txtAdi.Text);
            komut3.Parameters.AddWithValue("@prm3", long.Parse(txtISBN.Text));
            komut3.Parameters.AddWithValue("@prm4", int.Parse(txtSayfaSayisi.Text));
            komut3.Parameters.AddWithValue("@prm5", DateTime.Parse(txtBasimTarihi.Text));
            komut3.Parameters.AddWithValue("@prm6", Decimal.Parse(txtKiralamaFiyati.Text));
            komut3.Parameters.AddWithValue("@prm7", int.Parse(textKiralamaSuresi.Text));
            komut3.Parameters.AddWithValue("@prm8", DateTime.Parse(txtSonGuncellemeTarihi.Text));
            komut3.Parameters.AddWithValue("@prm9", int.Parse(txtKitapId.Text));
            komut3.ExecuteNonQuery();
            MessageBox.Show("Ürün güncelleme işlemi başarılı bir şekilde gerçekleştirildi");
            baglanti.Close();

        }
    }
}
