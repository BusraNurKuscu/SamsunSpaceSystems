using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamsunSpaceSystems
{
    public partial class Home : UserControl
    {
        public Home()
        {
            //  formdaki daki serial portu başka bir 
            //Form1 h = new Form1();
            //h.srlPortGelen.Write("dksjg");
            InitializeComponent();
            //    try
            //    {
            //        if (srlPortGiden.IsOpen == false)
            //        {
            //            srlPortGiden.Open();
            //            txtSbtPort2.Text = "Bağlandı";
            //        }
            //    }
            //    catch
            //    {
            //        txtSbtPort2.Text = "Bağlanamadı";
            //    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //TEST EDİLECEK (Seri porttan veri gönderme komutu)
            //Çalışmıyor
            try
            {
                Form1 f1 = new Form1();
                f1.srlPortGelen.Write("birles");
            }
            catch (Exception)
            {
                // LOG EX
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.srlPortGelen.Write("sison");
            }
            catch (Exception)
            {
                // LOG EX
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.srlPortGelen.Write("ayril");
            }
            catch (Exception)
            {
                // LOG EX
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.srlPortGelen.Write("motoron");
            }
            catch (Exception)
            {
                // LOG EX
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.srlPortGelen.Write("motoroff");
            }
            catch (Exception)
            {
                // LOG EX
            }
        }

        private void btnVdSec_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    this.txt_path.Text = dialog.FileName;
            //    rhcVdGnd.Text = txt_path.Text;
            //    byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
            //    base64Text = Convert.ToBase64String(imageArray); // base64Text global olmalı ama richtextbox kullanacağım
            //    richTextBox1.Text = base64Text;


            //}
        }
    }
}
