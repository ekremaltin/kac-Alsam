using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kacAlsam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double vize, final;
        double vize2, final2,sonuc;

        private void button2_Click(object sender, EventArgs e) //Gereken Fianl notunu hesaplama
        {
            try
            {
                if (Convert.ToDouble(textBox20.Text)>=0&& Convert.ToDouble(textBox20.Text)<=100
                    && Convert.ToDouble(textBox21.Text)>=0&& Convert.ToDouble(textBox21.Text)<=100)
                {
                    vize2 = Convert.ToDouble(textBox20.Text);
                    final2 = Convert.ToDouble(textBox21.Text);
                    sonuc = vize2 * 0.4 + final2 * 0.6;
                    textBox22.Text = Convert.ToString(sonuc);
                    if (sonuc >= 89.5 && sonuc <= 100)
                        textBox23.Text = "AA";
                    else if (sonuc >= 84.5 && sonuc < 89.5)
                        textBox23.Text = "BA";
                    else if (sonuc >= 79.5 && sonuc < 84.5)
                        textBox23.Text = "BB";
                    else if (sonuc >= 69.5 && sonuc < 79.5)
                        textBox23.Text = "CB";
                    else if (sonuc >= 59.5 && sonuc < 69.5)
                        textBox23.Text = "CC";
                    else if (sonuc >= 54.5 && sonuc < 59.5)
                        textBox23.Text = "DC";
                    else if (sonuc >= 49.5 && sonuc < 54.5)
                        textBox23.Text = "DD";
                    else if (sonuc >= 39.5 && sonuc < 49.5)
                        textBox23.Text = "FD";
                    else
                        textBox23.Text = "FF";
                }
                else
                {
                    MessageBox.Show("Vize ve Final Notunu tam ve doğru giriniz!");
                    textBox20.Text = "";
                    textBox21.Text = "";
                    textBox21.Text = "";
                    textBox23.Text = "";
                }                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Vize ve Final Notunu tam ve doğru giriniz!");
                textBox20.Text = "";   
                textBox21.Text = "";
                textBox21.Text = "";
                textBox23.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Convert.ToDouble(textBox1.Text) >= 0 && Convert.ToDouble(textBox1.Text) <= 200)
                {
                    vize = Convert.ToDouble(textBox1.Text);
                }
                else
                {
                    vize = 1000;
                    MessageBox.Show("Lütfen notunuzu doğru şekilde giriniz. ");
                }                   
                    

            }        
            catch (Exception)
            {
                MessageBox.Show("Lütfen notunuzu doğru şekilde giriniz. ");
            }
            //AA Hesaplaması
            final = Math.Ceiling((89.5 - vize * 0.4) * 10 / 6);
            if (final > 100)
            {
                textBox2.Text = "-";
                textBox11.Text = "-";
            }
                
            else if (final < 50)
            {
                textBox2.Text = "-";
                textBox11.Text = "-";
            }
            else
            {
                textBox2.Text = Convert.ToString(final);
                textBox11.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            //BA Hesaplaması
            final = Math.Ceiling((84.5 - vize * 0.4) * 10 / 6);
            if (final > 100)
            {
                textBox3.Text = "-";
                textBox12.Text = "-";
            }
                
            else if (final < 50)
            {
                textBox3.Text = "-";
                textBox12.Text = "-";
            }
            else
            {
                textBox3.Text = Convert.ToString(final);
                textBox12.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            //BB Hesaplaması
            final = Math.Ceiling((79.5 - vize * 0.4) * 10 / 6);
            if (final > 100)
            {
                textBox4.Text = "-";
                textBox13.Text = "-";
            }
                
            else if (final < 50)
            {
                textBox4.Text = "-";
                textBox13.Text = "-";
            }
            else
            {
                textBox4.Text = Convert.ToString(final);
                textBox13.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            //CB Hesaplaması
            final = Math.Ceiling((69.5 - vize * 0.4) * 10 / 6);
            if (final > 100)
            {
                textBox5.Text = "-";
                textBox14.Text = "-";
            }
                
            else if (final<50)
            {
                textBox5.Text  = "-";
                textBox14.Text = "-";
            }
            else
            {
                textBox5.Text = Convert.ToString(final);
                textBox14.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            //CC Hesaplaması
            final = Math.Ceiling((59.5 - vize * 0.4) * 10 / 6);
            if (30+vize*0.4>=59.5 && 30 + vize * 0.4 < 69.5)
            {
                textBox6.Text = "50";
                textBox18.Text = Convert.ToString(30 + vize * 0.4);
            }
            else if (final<50)
            {
                textBox6.Text = "-";
                textBox18.Text ="-";
            }
            else
            {
                textBox6.Text = Convert.ToString(final);
                textBox18.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            
            //DC Hesaplaması
            final = Math.Ceiling((54.5 - vize * 0.4) * 10 / 6);            
            if (30+vize*0.4>=54.5 && 30 + vize * 0.4 < 59.5)
            {                
                textBox7.Text = "50";
                textBox17.Text = Convert.ToString(30 + vize * 0.4);
            }
            else if (final<50)
            {
                textBox7.Text = "-";
                textBox17.Text ="-";
            }
            else
            {
                textBox7.Text = Convert.ToString(final);
                textBox17.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }

            //DD Hesaplaması
            final = Math.Ceiling((49.5 - vize * 0.4) * 10 / 6);
            if (30+vize*0.4>=49.5 && 30 + vize * 0.4 < 54.5)
            {
                textBox8.Text = "50";
                textBox16.Text = Convert.ToString(30 + vize * 0.4);
            }
            else if(final<50)
            {
                textBox8.Text = "-";
                textBox16.Text = "-";
            }
            else
            {
                textBox8.Text = Convert.ToString(final);
                textBox16.Text = Convert.ToString(final*0.6 + vize * 0.4);
            }
           
            //FD Hesaplaması
            final = Math.Ceiling((39.5 - vize * 0.4) * 10 / 6);
            if (final>=0)
            {
                textBox9.Text = Convert.ToString(final);
                textBox15.Text = Convert.ToString(final * 0.6 + vize * 0.4);
            }
            else
            {
                textBox9.Text = "-";
                textBox15.Text = "-";
            }
            //FF Hesaplaması
            final = Math.Ceiling((39.5 - vize * 0.4) * 10 / 6);
            if (vize>=100)
            {
                textBox10.Text = "-";
                textBox19.Text = "-";
            }
            else
            {
                textBox10.Text = "<"+Convert.ToString(final);
                textBox19.Text = "<39.5";
            }
        }
    }
}
