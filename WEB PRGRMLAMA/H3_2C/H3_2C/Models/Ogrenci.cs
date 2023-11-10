namespace H3_2C.Models
{
    public class Ogrenci
    {
        public string OgrAd { get; set; } 
        public string OgrSoyad { get; set; } 
        public string OgrNo { get; set; }
        public double OgrenciOrtNotGetir(int id)
        {
            //db den bu idli öğrenciye ait not ortalmaını geitr;
            double not = 2.52;
            return not;
        }
    }
}
