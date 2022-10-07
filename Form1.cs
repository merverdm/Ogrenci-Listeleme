using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ogrenci_Listeleme
{
    public partial class OgrenciListeleme : Form
    {
        public OgrenciListeleme()
        {
            InitializeComponent();
        }
        OgrenciTabEntities db = new OgrenciTabEntities();
        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCİ.ToList();//Listele

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLOGRENCİ  t = new TBLOGRENCİ();
            t.AD = textBox1.Text;
            t.SOYAD = textBox2.Text;
            db.TBLOGRENCİ.Add(t);//Öğrenciyi Ekle
            db.SaveChanges();//Değişiklikleri Kaydet
            MessageBox.Show("Öğrenci Kaydedildi.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);//textbox'a girilen id de ki öğrenciyi bul
            var x = db.TBLOGRENCİ.Find(id);
            db.TBLOGRENCİ.Remove(x); //ID olan öğrenciyi sil
            db.SaveChanges();//Değişiklikleri Kaydet
            MessageBox.Show("Öğrenci Silindi.");
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox3.Text);
            var y = db.TBLOGRENCİ.Find(id);//Güncelle
            y.AD = textBox1.Text;
            y.SOYAD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
