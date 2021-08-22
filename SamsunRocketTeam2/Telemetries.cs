using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SamsunSpaceSystems
{
    public partial class Telemetries : UserControl
    {
        public Telemetries()
        {
            //  Home daki serial portu başka bir 
            // Home h = new Home();
            // h.serialPort2.Write("dksjg");
            InitializeComponent();
            timer1.Start();
        }




        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.globalLiveData.Count == 0)
                return;

            dataGridView1.DataSource = Database.GetAll();

            //Labellar ve textlere son veri yazılır
            var length = Program.globalLiveData.Count - 1;
          //  txtRPM.Text = Program.globalLiveData[length].Manyetik_Alan.ToString();
            txtGPS_Alt.Text = Program.globalLiveData[length].GPS_Alt.ToString();
            txtStatu.Text = Program.globalLiveData[length].Uydu_Statusu.ToString();
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
            txtYaw.Text = Program.globalLiveData[length].Yaw.ToString();
            txtHiz.Text = Program.globalLiveData[length].Inis_Hizi.ToString();
            txtYks.Text = Program.globalLiveData[length].Yukseklik.ToString();
            txtGPSlg.Text = Program.globalLiveData[length].GPS_Long.ToString();
            txtGPSlt.Text = Program.globalLiveData[length].GPS_Lat.ToString();
            txtGPS_Alt.Text = Program.globalLiveData[length].GPS_Alt.ToString();

            // dataGridView1.DataSource = Program.globalLiveData;

            //var m = dataGridView1.GetType().GetMethod("OnDataSourceChanged", BindingFlags.NonPublic | BindingFlags.Instance);
            //m.Invoke(dataGridView1, new object[] { EventArgs.Empty });
        }
    }
}
