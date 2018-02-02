using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoAmstrong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * So AmStrong
         */

        private bool SoAmstrong(int x)
        {
            bool ketqua = false;

            int Xbandau = x;

            int thuong = 0;

            int sodu = 0;

            double tong = 0;

            int[] a = new int[100];

            int dem = 0; 

            do
            {
                thuong = x / 10;

                sodu = x % 10;

                a[dem++] = sodu;

                x = thuong;

            } while (thuong != 0);

            for(int i = 0; i < a.Length; i++)
            {
                tong = tong + Math.Pow((double)a[i],dem);
            }

            if(tong == Xbandau)
            {
                ketqua = true;
            }

            return ketqua; 
        }
        private void btnXuly_Click(object sender, EventArgs e)
        {
            string bienchuoi = null; 

            for (int i = 1; i < 10000; i++)
            {
                if (SoAmstrong(i))
                {
                    bienchuoi += " ";
                    bienchuoi += i;
                }
            }
            txtketqua.Text = bienchuoi;
        }

        private void btnKiemTraSon_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapSoN.Text);

            if (SoAmstrong(n))
            {
                txtketqua.Text = "là số Amstrong";
            }
            else
            {
                txtketqua.Text = "Không là số Amstrong";
            }
        }
    }
}
