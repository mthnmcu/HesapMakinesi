using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private Char _islem;
        private bool _ekranTemizlenecekMi;
        private double _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            IslemBelirle('+');
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(ekranLabel.Text);
            double sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    if (ikinciSayi != 0)
                    {
                        sonuc = _ilksayi / ikinciSayi;
                    }
                    else
                    {
                        MessageBox.Show("Sıfıra bölme hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sonuc = 0;
                    }
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eskiButton_Click(object sender, EventArgs e)
        {
            IslemBelirle('-');
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            IslemBelirle('*');
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            IslemBelirle('/');
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void NoktaButton_Click(object sender, EventArgs e)
        {
            if (!ekranLabel.Text.Contains(","))
            {
                ekranLabel.Text += ",";
            }
        }

        private void YuzdeButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text != "0")
            {
                ekranLabel.Text = ekranLabel.Text.Remove(ekranLabel.Text.Length - 1);
                if (ekranLabel.Text == string.Empty)
                {
                    ekranLabel.Text = "0";
                }
            }
        }
        private void IslemBelirle(char islem)
        {
            _islem = islem;
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToDouble(ekranLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(ekranLabel.Text);
            kare=Math.Pow(kare, 2);
            ekranLabel.Text=Convert.ToString(kare);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(ekranLabel.Text);
            karekok = Math.Sqrt(karekok);
            ekranLabel.Text = Convert.ToString(karekok);
        }

        private void NegatifButton_Click(object sender, EventArgs e)
        {
            if (ekranLabel.Text.StartsWith("-"))
            {
                ekranLabel.Text = ekranLabel.Text.Substring(1); // Eksi işareti kaldır
            }
            else if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "-"; // Sadece "-" yazıyorsa, negatif işareti ekle
            }
            else
            {
                ekranLabel.Text = "-" + ekranLabel.Text; // Eksi işareti ekle
            }
        }
      }
    }

