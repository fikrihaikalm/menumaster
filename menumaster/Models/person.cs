using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menumaster.Models
{

public class Person
    {
        public string Nama { get; set; }
        public string Telp { get; set; }
    }

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



public class Customer : Person
    {
        public int IdCustomer { get; set; }
    }



public class Admin : Karyawan
    {
        public bool MelihatPengeluaran() { /* implementation */ return true; }
        public bool MencatatPengeluaran() { /* implementation */ return true; }
        public bool MelihatPendapatan() { /* implementation */ return true; }
        public bool MenambahMenu() { /* implementation */ return true; }
        public bool MenghapusMenu() { /* implementation */ return true; }
        public bool MengubahMenu() { /* implementation */ return true; }
    }

    public class Manager : Karyawan
    {
        public bool MelihatLaporanKeuangan() { /* implementation */ return true; }
        public bool MenambahKaryawan() { /* implementation */ return true; }
        public bool MenghapusKaryawan() { /* implementation */ return true; }
        public bool MengubahKaryawan() { /* implementation */ return true; }
    }

    public class Chef : Karyawan
    {
        public bool MenerimaPesanan() { /* implementation */ return true; }
    }

    public class Cashier : Karyawan
    {
        public bool MembuatPesanan() { /* implementation */ return true; }
        public bool HapusPesanan() { /* implementation */ return true; }
        public bool UbahPesanan() { /* implementation */ return true; }
        public bool MembuatReservasi() { /* implementation */ return true; }
        public bool UbahReservasi() { /* implementation */ return true; }
        public bool HapusReservasi() { /* implementation */ return true; }
    }



public class Pembayaran
    {
        public int IdPembayaran { get; set; }
        public double Total { get; set; }
        public DateTime Tanggal { get; set; }
    }



public class Menu
    {
        public int IdMenu { get; set; }
        public string NamaMenu { get; set; }
        public string HargaMenu { get; set; }
        public string Deskripsi { get; set; }
    }



public class Pesanan
    {
        public int IdOrder { get; set; }
        public string StatusPesanan { get; set; }
    }



public class Meja
    {
        public int IdMeja { get; set; }
        public int Kapasitas { get; set; }
        public int NomerMeja { get; set; }
    }



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
