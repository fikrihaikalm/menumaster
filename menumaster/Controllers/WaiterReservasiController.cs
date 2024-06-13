using System;
using System.Data;
using menumaster.Models;

namespace menumaster.Controllers
{
    public class WaiterReservasiController
    {
        private WaiterReservasiModel model;

        public WaiterReservasiController()
        {
            model = new WaiterReservasiModel();
        }

        public DataTable LoadMeja()
        {
            return model.GetMeja();
        }

        public DataTable LoadMetodePembayaran()
        {
            return model.GetMetodePembayaran();
        }

        public int GetPelangganIdByTelp(string telp)
        {
            return model.GetPelangganIdByTelp(telp);
        }

        public int AddNewPelanggan(string nama, string telp)
        {
            return model.AddNewPelanggan(nama, telp);
        }

        public int GetAvailableMejaId(int jumlahOrang)
        {
            return model.GetAvailableMejaId(jumlahOrang);
        }

        public void AddReservasiMeja(DateTime tanggalReservasi, TimeSpan waktuReservasi, TimeSpan durasiReservasi, int jumlahOrang, int mejaId, int pelangganId)
        {
            model.AddReservasiMeja(tanggalReservasi, waktuReservasi, durasiReservasi, jumlahOrang, mejaId, pelangganId);
        }
    }
}
