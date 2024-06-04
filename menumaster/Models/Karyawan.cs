using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{
    public class Karyawan : Person
    {
        public int IdKaryawan { get; set; }
        public string Email { get; set; }
        public string Alamat { get; set; }
        public DateTime TglMasuk { get; set; }
        public string Password { get; set; }
        public double Gaji { get; set; }
        public byte[] Foto { get; set; }
        public bool Aktif { get; set; }
    }
}
