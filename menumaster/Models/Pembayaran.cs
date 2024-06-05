using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{
    public class Pembayaran
    {
        public int IdPembayaran { get; set; }
        public double Total { get; set; }
        public DateTime Tanggal { get; set; }
    }
}