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
    public partial class Graphics : UserControl
    {
        public Graphics()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Graphics_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.globalLiveData.Count == 0)
                return;

            var tele = Program.globalLiveData[Program.globalLiveData.Count - 1];
            this.chtBsn.Series["Pressure hPa"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Basinc);
            this.chtDns.Series["Spin"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Donus_Sayisi);
            this.chtHiz.Series["Speed m/s"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Inis_Hizi);
            this.chtPil.Series["Voltage V"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Pil_Gerilimi);
            this.chtPtc.Series["Pitch"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Pitch);
            this.chtRoll.Series["Roll"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Roll);
            this.chtSck.Series["Tempature C"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Sicaklik);
            this.chtYaw.Series["Yaw"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Yaw);
            this.chtYks.Series["Height m"].Points.AddXY(tele.Gonderme_Zamani.ToString(), tele.Yukseklik);
        }

        private void chtSck_Click(object sender, EventArgs e)
        {

        }
    }
}
