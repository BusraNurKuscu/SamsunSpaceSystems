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
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
            tmrOverview.Start();
        }

        private void tmrOverview_Tick(object sender, EventArgs e)
        {

            if (Program.globalLiveData.Count == 0)
                return;

            //Labellar ve textlere son veri yazılır
            var length = Program.globalLiveData.Count - 1;
            txtRPM.Text = Program.globalLiveData[length].Yaw.ToString();
            txtGPS_Alt.Text = Program.globalLiveData[length].GPS_Alt.ToString();
            txtBsn.Text = Program.globalLiveData[length].Basinc.ToString();
            txtDns.Text = Program.globalLiveData[length].Donus_Sayisi.ToString();
            txtGnd.Text = Program.globalLiveData[length].Gonderme_Zamani.ToString();
            txtGPSlg.Text = Program.globalLiveData[length].GPS_Long.ToString();
            txtGPSlt.Text = Program.globalLiveData[length].GPS_Lat.ToString();
            txtPil.Text = Program.globalLiveData[length].Pil_Gerilimi.ToString();
            txtPitch.Text = Program.globalLiveData[length].Pitch.ToString();
            txtPkt.Text = Program.globalLiveData[length].Paket_No.ToString();
            txtRoll.Text = Program.globalLiveData[length].Roll.ToString();
            txtSck.Text = Program.globalLiveData[length].Sicaklik.ToString();
            txtTkm.Text = Program.globalLiveData[length].Takim_No.ToString();
            txtHiz.Text = Program.globalLiveData[length].Inis_Hizi.ToString();
            txtYks.Text = Program.globalLiveData[length].Yukseklik.ToString();
            txtGPSlg.Text = Program.globalLiveData[length].GPS_Long.ToString();
            txtGPSlt.Text = Program.globalLiveData[length].GPS_Lat.ToString();
            txtGPS_Alt.Text = Program.globalLiveData[length].GPS_Alt.ToString();

            //hız ve yükseklik grafikleri çizdirilir
            var tele = Program.globalLiveData[Program.globalLiveData.Count - 1];
            this.chtHiz.Series["Speed m/s"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Inis_Hizi);
            this.chtYks.Series["Height m"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Yukseklik);


        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
