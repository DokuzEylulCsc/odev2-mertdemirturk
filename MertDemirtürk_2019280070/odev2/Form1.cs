using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen değer giriniz.");
                goto bitir;
            }
            
            int sayi;
            sayi = int.Parse(textBox1.Text);
           
            if (sayi==0 || sayi>3999)
            {
                MessageBox.Show("Hatalı sayı girişi lütfen 1-3999 arası bir sayı giriniz");
                textBox1.Clear();
                goto bitir;
            }

            int binler=0, onlar=0, yuzler=0, birler=0;
            if (sayi<10)
            {
                birler = sayi;
            }
            else if (sayi>=10 && sayi<100)
            {
                birler = sayi % 10;
                onlar = (sayi - birler) / 10;
            }
            else if (sayi>=100 && sayi<1000)
            {
                birler = sayi % 10;
                onlar = ((sayi % 100) - birler) / 10;
                yuzler = (sayi -sayi%100) / 100;
            }
            else
            {
                birler = sayi % 10;
                onlar = ((sayi % 100) - birler) / 10;
                yuzler = (sayi%1000) / 100;
                binler = (sayi - birler - onlar - yuzler) / 1000;
            }
            string[] rbirler = {"","I","II" ,"II","IV","V","VI","VII","VIII","IX"};
            string[] ronlar = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ryuzler = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] rbinler = { "", "M", "MM", "MMM" };
            
            MessageBox.Show(rbinler[binler] + ryuzler[yuzler] + ronlar[onlar] + rbirler[birler]);
            textBox1.Clear();
        bitir:;



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("Lütfen değer giriniz");
                goto bitir;
            }
            string deger = textBox2.Text.ToUpper();
            
           int sayi = 0,s1=0,s2,s3=0;
            for (int i = 0; i < deger.Length; i++)
            {
                s2 = s1;
                switch (deger[i])
                {
                    case 'I': s1 = 1; break;
                    case 'V': s1 = 5; break;
                    case 'X': s1 = 10; break;
                    case 'L': s1 = 50; break;
                    case 'C': s1 = 100; break;
                    case 'D': s1 = 500; break;
                    case 'M': s1 = 1000; break;
                    default: MessageBox.Show("HATALI SAYI GİRİŞİ"); goto bitir;
                }
                if (s1>s2)
                {
                    s3 = -2 * s2;
                }
                else
                {
                    s3 = 0;
                }
               sayi += s1+s3; 
            }
            MessageBox.Show(sayi.ToString());
            textBox2.Clear();
        bitir:;
            textBox2.Clear();
        }
    }
}
