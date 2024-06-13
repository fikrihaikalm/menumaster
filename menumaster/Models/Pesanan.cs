namespace menumaster.Models
{
    public class Pesanan
    {
        public int ID { get; set; }
        public DateTime TanggalPemesanan { get; set; }
        public decimal TotalHarga { get; set; }
        public decimal TotalTax { get; set; }
        public int PelangganID { get; set; }
        public int MetodePembayaranID { get; set; }
        public int KaryawanID { get; set; }
        public List<MenuItem> Items { get; set; }

        public Pesanan()
        {
            Items = new List<MenuItem>();
        }
    }

    public class MenuItem
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public int Jumlah { get; set; }
    }
}
