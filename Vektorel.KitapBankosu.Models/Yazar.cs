using System;

namespace Vektorel.KitapBankosu.Models
{
    public enum Islem
    {
        Insert,
        Update
    }
    public class Yazar
    {
        public int Yazarid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTar { get; set; }
        public DateTime OlumTarih { get; set; }

        public string AdSoyad { get; set; }
    }
}
