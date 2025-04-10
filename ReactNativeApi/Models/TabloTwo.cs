namespace ReactNativeApi.Models;

    public class TableTwo
    {
        public int Id { get; set; }
        public string TeknisyenAdi { get; set; }
        public string DgtParcaKodu { get; set; }
        public string Durum { get; set; }
        public string OnaylayanProjeYoneticisi { get; set; }
        public int BeklemedeAdet { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public List<string> AciklamaListesi { get; set; }
    }
