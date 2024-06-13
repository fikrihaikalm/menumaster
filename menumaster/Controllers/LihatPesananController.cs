using System.Data;
using menumaster.Helpers;
using Npgsql;

namespace menumaster.Controllers
{
    public class LihatPesananController
    {
        public DataTable GetPesananData()
        {
            string query = @"SELECT dp.ID_detail_pesanan as urutan_pesanan, p.tanggal_pemesanan, m.nama, dp.jumlah 
                             FROM detail_pesanan dp 
                             JOIN pesanan p ON dp.ID_pesanan = p.ID_pesanan 
                             JOIN menu m ON dp.ID_menu = m.ID_menu
                             WHERE dp.jumlah > 0";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
