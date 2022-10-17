using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgeleSayı
{
    public partial class Form1 : Form
    {

        // sınıfın  field(alan  yani değişken ) , property (özellik) ve metotları yazılır 
        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            int min, max;
            min = 0;
            max = 0;
            try // dene : hata beklediğimiz bu kodu bu blok içine yaz 

            {
                // 2 değer arasında rastgele tam sayı üret 
                 min = int.Parse(textBox1.Text);
                 max = Convert.ToInt32(textBox2.Text);
                int sayi = rastgele.Next(min, max + 1);
                label3.Text = sayi.ToString();

            }
            catch (Exception istisna)
            {
                //hatayı yakalayıp kullanıcı bilgilendirebilir 
                MessageBox.Show(istisna.Message, istisna.Source);
            }
            finally
            {
                // hata olsada olmasada çalışmasını istediğimiz kod
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {

            int min, max;
            min = 0;
            max = 0;
            try // dene : hata beklediğimiz bu kodu bu blok içine yaz 

            {
                // 2 değer arasında rastgele tam sayı üret 
                min = int.Parse(textBox1.Text);
                max = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception istisna)
            {
                //hatayı yakalayıp kullanıcı bilgilendirebilir 
                MessageBox.Show(istisna.Message, istisna.Source);
            }
            finally
            {
                // hata olsada olmasada çalışmasını istediğimiz kod
            }
            double sayi = rastgele.NextDouble()*(max-min)+min;

            label3.Text = sayi.ToString();


        }
    }    
}

