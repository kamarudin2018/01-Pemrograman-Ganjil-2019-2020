using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting
            var hasil = 0;

            switch (cmbOperasi.SelectedIndex)
            {
                case 0: // penambahan
                    hasil = Penambahan(a, b);
                    break;

                case 1: // pengurangan
                    hasil = Pengurangan(a, b);
                    break;

                case 2: // perkalian
                    hasil = Perkalian(a, b);
                    break;

                case 3: // pembagian
                    hasil = Pembagian(a, b);
                    break;

                default:
                    break;
            }

            txtHasil.Text = hasil.ToString();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
