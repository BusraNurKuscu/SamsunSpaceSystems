using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamsunSpaceSystems
{
    public partial class Form1 : Form
    {
        private static string _data;
        private static string _oldData;

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (srlPortGelen.IsOpen == false)
                {
                    srlPortGelen.Open();
                    txtSbtPort.Text = "Bağlandı";
                }
            }
            catch
            {
                if (srlPortGelen.IsOpen == false)
                {
                    txtSbtPort.Text = "Bağlanamadı";
                }

            }
        }


        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //   map1.Visible = false;
            overview1.Visible = false;
            graphics1.Visible = false;
            home1.Visible = true;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnHome.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // map1.Visible = false;
            overview1.Visible = false;
            graphics1.Visible = false;
            home1.Visible = false;
            simCam1.Visible = true;
            telemetries1.Visible = false;
            BtnSimCam.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //  map1.Visible = false;
            overview1.Visible = false;
            graphics1.Visible = true;
            home1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnGraphhics.BackColor = Color.Gold;
            BtnSimCam.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // map1.Visible = false;
            // overview1.Visible = true;
            overview1.Visible = true;
            graphics1.Visible = false;
            home1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnOverview.BackColor = Color.Gold;
            BtnHome.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // map1.Visible = true;
            overview1.Visible = false;
            graphics1.Visible = false;
            home1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = false;
            BtnMap.BackColor = Color.Gold;
            BtnHome.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnTelemetries.BackColor = Color.Transparent;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        string data = srlPortGelen.ReadLine();
                        _data = data;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Port okuma işlemi sonlandırıldı.");
                    }

                }

            }).Start();
            overview1.Visible = true;
            BtnOverview.BackColor = Color.Gold;
        }

        private void BtnTelemetries_Click(object sender, EventArgs e)
        {
            //  map1.Visible = false;
            overview1.Visible = false;
            graphics1.Visible = false;
            simCam1.Visible = false;
            telemetries1.Visible = true;
            home1.Visible = false;
            BtnTelemetries.BackColor = Color.Gold;
            BtnGraphhics.BackColor = Color.Transparent;
            BtnSimCam.BackColor = Color.Transparent;
            BtnOverview.BackColor = Color.Transparent;
            BtnMap.BackColor = Color.Transparent;
            BtnHome.BackColor = Color.Transparent;
        }



        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_data == null)
                {
                    return;
                }
                //if (_data != _oldData)
                //{
                _oldData = _data;
                string[] pots = _data.Split(',');

                var tele = new Database
                {
                    Takim_No = int.Parse(pots[0]),
                    Paket_No = int.Parse(pots[1]),
                    Gonderme_Zamani = DateTime.Now,//DateTime.Parse(pots[2]),
                    Basinc = float.Parse(pots[3]) / 100.0f,
                    Yukseklik = float.Parse(pots[4]) / 100.0f,
                    Inis_Hizi = float.Parse(pots[5]) / 100.0f,
                    Sicaklik = float.Parse(pots[6]) / 100.0f,
                    Pil_Gerilimi = float.Parse(pots[7]) / 100.0f,
                    Pil_Gerilimi2 = float.Parse(pots[8]) / 100.0f,
                    GPS_Lat = float.Parse(pots[9]) / 1000000.0f,
                    GPS_Long = float.Parse(pots[10]) / 1000000.0f,
                    GPS_Alt = float.Parse(pots[11]) / 100.0f,
                    Uydu_Statusu = Convert.ToString(pots[12]),
                    Pitch = float.Parse(pots[13]) / 100f,
                    Roll = float.Parse(pots[14]) / 100.0f,
                    Yaw = float.Parse(pots[15]) / 100f,
                    Donus_Sayisi = float.Parse(pots[16]) / 100.0f,
                    Video_Aktarım_Bilgisi = float.Parse(pots[17]) / 100.0f,
                    Manyetik_Alan = float.Parse(pots[18]) / 100.0f,
                };

                Database.Add(tele);
                //Veri statik değişkene atılır
                Program.globalLiveData.Add(tele);
                //}
            }
            catch
            {
                if (_data != _oldData)
                {
                    _oldData = _data;
                    string[] pots = _data.Split(',');

                    var tele = new Database
                    {
                        Takim_No = 0,
                        Paket_No = 0,
                        Gonderme_Zamani = DateTime.Now,//DateTime.Parse(pots[2]),
                        Basinc = 0,
                        Yukseklik = 0,
                        Inis_Hizi = 0,
                        Sicaklik = 0,
                        Pil_Gerilimi = 0,
                        Pil_Gerilimi2 = 0,
                        GPS_Lat = 0,
                        GPS_Long = 0,
                        GPS_Alt = 0,
                        Uydu_Statusu = "statü bilgisi yok",
                        Pitch = 0,
                        Roll = 0,
                        Yaw = 0,
                        Donus_Sayisi = 0,
                        Video_Aktarım_Bilgisi = 0,
                        Manyetik_Alan = 0,
                    };

                    Database.Add(tele);
                    //Veri statik değişkene atılır
                    Program.globalLiveData.Add(tele);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //programı kapatır
            Application.Exit();
        }


    }
}
