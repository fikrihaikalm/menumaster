using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{
    public class Reservasi
    {
        public int IdReservasi { get; set; }
        public DateTime WaktuReservasi { get; set; }
        public DateTime TanggalReservasi { get; set; }
        public int DurasiReservasi { get; set; }
        public int JumlahOrang { get; set; }
        public Customer Customer { get; set; }
    }
}