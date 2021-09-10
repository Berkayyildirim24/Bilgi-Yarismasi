using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class f1 : Form
    {
        public f1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru=0 , yanlis=0;

        private void b2_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = true;

            label3.Text = b2.Text;
            if (label2.Text == label3.Text)
            {
                dogru++;
                l5.Text = dogru.ToString();
                p1.Visible = true;
            }
            else
            {
                yanlis++;
                l6.Text = yanlis.ToString();
                p2.Visible = true;

            }
        }
        private void b3_Click(object sender, EventArgs e)
        {

            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = true;


            label3.Text = b3.Text;
            if (label2.Text == label3.Text)

            {
                dogru++;
                l5.Text = dogru.ToString();
                p1.Visible = true;

            }

            else
            {
                yanlis++;
                l6.Text = yanlis.ToString();
                p2.Visible = true;

            }
        }
        private void b4_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = true;


            label3.Text = b4.Text;
            if (label2.Text == label3.Text)

            {
                dogru++;
                l5.Text = dogru.ToString();
                p1.Visible = true;
            }
            else
            {
                yanlis++;
                l6.Text = yanlis.ToString();
                p2.Visible = true;
           }
        }
        private void b1_Click(object sender, EventArgs e)
        {

            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = true;
            label3.Text = b1.Text;
            if (label2.Text==label3.Text)
            {
                dogru++;
                l5.Text = dogru.ToString();
                p1.Visible = true;
                
            }
            else
            {
                yanlis++;
                l6.Text = yanlis.ToString();
                p2.Visible = true;
            }          
        }
        private void b5_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = false;

            p1.Visible = false;
            p2.Visible = false;


            soruno++;
            l4.Text = soruno.ToString();

            if (soruno == 1)
            {
                r1.Text = "Türkiye'nin başkenti neresidir?";
                b1.Text = "İstanbul";
                b2.Text = "Ankara";
                b3.Text = "İzmir";
                b4.Text = "Manisa";
                label2.Text = "Ankara";
            }
            if (soruno == 2)
            {

                r1.Text = "Atatürk kaç yılında doğmuştur?";
                b1.Text = "1938";
                b2.Text = "1881";
                b3.Text = "1818";
                b4.Text = "1923";
                label2.Text = "1881";
            }
            if (soruno == 3)
            {

                r1.Text = "Türkiye'de toplam kaç il vardır?";
                b1.Text = "96";
                b2.Text = "91";
                b3.Text = "71";
                b4.Text = "81";
                label2.Text = "81";
            }
            if (soruno == 4)
            {

                r1.Text = "Güneşe en yakın gezegen hangisidir?";
                b1.Text = "Mars";
                b2.Text = "Merkür";
                b3.Text = "Dünya";
                b4.Text = "Satürn";
                label2.Text = "Merkür";
            }
            if (soruno == 5)
            {

                r1.Text = "Hangisi bir yaz meyvesidir?";
                b1.Text = "Nar";
                b2.Text = "Mandalina";
                b3.Text = "Karpuz";
                b4.Text = "Portakal";
                label2.Text = "Karpuz";
            }



        }
    }
}
