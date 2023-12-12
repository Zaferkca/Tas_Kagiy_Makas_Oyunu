using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagıt_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string O_Secim; //oyuncu seçimi
        string B_Secim; //bilgisayar seçimi
        int Oyncu_Puan; //oyuncu puanı
        int B_Puan; //bilgisayar puanı
        int rastgele;
        Random random = new Random();

        private void oyuncu_puanı_Click(object sender, EventArgs e)
        {

        }

        private void Tas_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimlerr/taş.jpg"; 
            O_Secim = "Taş";
        }

        private void Kagıt_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimler/kagit.jpg";
            O_Secim = "Kağıt";
        }

        private void Makas_Click(object sender, EventArgs e)
        {
            Oyuncu.ImageLocation = "Resimler/makas.jpg";
            O_Secim = "Makas";
        }

        private void Bilgisayar_Hamle()
        {
            rastgele = random.Next(1, 4); 
            if(rastgele==1)
            {
                Bilgisayar.ImageLocation = "Resimler/tas.jpg";
                B_Secim = "Taş";
            }
            else if(rastgele==2)
            {
                Bilgisayar.ImageLocation = "Resimler/kagit.jpg";
                B_Secim = "Kağıt";
            }
            else if(rastgele==3)
            {
                Bilgisayar.ImageLocation = "Resimler/makas.jpg";
                B_Secim = "Makas";
            }
        }

        private void btn_oyun_Click(object sender, EventArgs e)
        {
          
            if(Oyncu_Puan==0 && B_Puan==0)
            {
                label5.Visible = false;              
                Oyuncu_Puanı.Text = "0";
                Bilgisayar_Puanı.Text = "0";
            }
           
            if(O_Secim==null)
            {
                MessageBox.Show("Hamle Şeçimi Yapmalısınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Bilgisayar_Hamle();
            }

            puanlama();
        }
        private void puanlama()
        {

            if(O_Secim == "Taş" && B_Secim == "Kağıt")
            {
                B_Puan++; 
                Bilgisayar_Puanı.Text = B_Puan.ToString(); 
            }
            else if(O_Secim == "Taş" && B_Secim == "Makas")
            {
                Oyncu_Puan++;
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }
            else if (O_Secim == "Kağıt" && B_Secim == "Taş")
            {
                Oyncu_Puan++; 
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }
            else if (O_Secim == "Kağıt" && B_Secim == "Makas")
            {
                B_Puan++; 
                Bilgisayar_Puanı.Text = B_Puan.ToString();
            }
            else if (O_Secim == "Makas" && B_Secim == "Taş")
            {
                B_Puan++; 
                Bilgisayar_Puanı.Text = B_Puan.ToString();
            }
            else if(O_Secim=="Makas" && B_Secim=="Kağıt")
            {
                Oyncu_Puan++;
                Oyuncu_Puanı.Text = Oyncu_Puan.ToString();
            }

           
            if(B_Puan==10 || Oyncu_Puan==10)
            {
                label5.Visible = true;

               
                if(B_Puan> Oyncu_Puan)
                {
  
                    Oyncu_Puan = 0;
                    B_Puan = 0;
                    Bilgisayar.ImageLocation = null;
                    Oyuncu.ImageLocation = null;
                    B_Secim = null;
                    O_Secim = null;
                }
                else if (Oyncu_Puan> B_Puan)
                {
    
                    Oyncu_Puan = 0;
                    B_Puan = 0;
                    Bilgisayar.ImageLocation = null;
                    Oyuncu.ImageLocation = null;
                    B_Secim = null;
                    O_Secim = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
