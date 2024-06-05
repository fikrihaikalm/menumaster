using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{
    public class Admin : Karyawan
    {
        public bool MelihatPengeluaran() { /* implementation */ return true; }
        public bool MencatatPengeluaran() { /* implementation */ return true; }
        public bool MelihatPendapatan() { /* implementation */ return true; }
        public bool MenambahMenu() { /* implementation */ return true; }
        public bool MenghapusMenu() { /* implementation */ return true; }
        public bool MengubahMenu() { /* implementation */ return true; }
    }
}
