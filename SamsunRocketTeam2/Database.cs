using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SamsunSpaceSystems
{
    public class Database
    {
        private static readonly LiteDatabase db = new LiteDatabase(@"database.db");

        public static object Port1 { get; internal set; }

        //Litedb ile database de tutulacak verileri bu envertere ekliyoruz.
        public int Takim_No { get; set; }//0
        public int Paket_No { get; set; } //1
        public DateTime Gonderme_Zamani { get; set; } //2
        public float Basinc { get; set; } //3
        public float Yukseklik { get; set; } //4
        public float Inis_Hizi { get; set; }//5
        public float Sicaklik { get; set; }//6
        public float Pil_Gerilimi { get; set; }//7 
       // public float Pil_Gerilimi2 { get; set; }//8
        public float GPS_Lat { get; set; }//9
        public float GPS_Long { get; set; }//10
        public float GPS_Alt { get; set; }//11
        public string Uydu_Statusu { get; set; }//12
        public float Pitch { get; set; }//13
        public float Roll { get; set; }//14
        public float Yaw { get; set; }//15
        public float Donus_Sayisi { get; set; }//16
        public string Video_Aktarım_Bilgisi { get; set; }//17
      //  public float Manyetik_Alan { get; set; }//18

        public static void Add(Database telemetri)//ekle fonksiyonu oluşturarak datalarımızı value olarak ekliyoruz.
        {
            var telemetries = db.GetCollection<Database>();
            telemetries.Insert(telemetri);
        }

        public static List<Database> GetAll()//tümünü listele fonksiyonu oluşturarak verilerin hepsini okuyop listeliyoruz.
        {
            var x = db.GetCollection<Database>().FindAll().ToList();
            return db.GetCollection<Database>().FindAll().OrderByDescending(t => t.Gonderme_Zamani).ToList();
        }

        internal static object ListenSerial() => throw new NotImplementedException();
    }
}

