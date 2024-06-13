using System;

namespace menumaster.Models
{
    public class Pengeluaran1Model
    {
        public int IdJenisPengeluaran { get; set; }
        public DateTime TanggalPengeluaran { get; set; }
        public decimal JumlahPengeluaran { get; set; }
        public int IdKaryawan { get; set; }
    }
}
