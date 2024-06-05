using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{
    public class Waiter : Karyawan
    {
        public bool MembuatPesanan() { /* implementatioon */ return true; }
        public bool HapusPesanan() { /* implementation */ return true; }
        public bool UbahPesanan() { /* implementation */ return true; }
        public bool MembuatReservasi() { /* implementation */ return true; }
        public bool UbahReservasi() { /* implementation */ return true; }
        public bool HapusReservasi() { /* implementation */ return true; }
    }
}
