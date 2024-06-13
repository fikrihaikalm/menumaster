using System;
using System.Data;
using Npgsql;
using menumaster.Helpers;

namespace menumaster.Controllers
{
    public class LaporanKeuanganController
    {
        public DataTable GetLaporanKeuangan(DateTime tanggal)
        {
            string query = @"SELECT 'Pendapatan makanan' AS Keterangan, SUM(m.harga * dp.jumlah) AS Jumlah, p.tanggal_pemesanan AS Tanggal
                    FROM pesanan p
                    JOIN detail_pesanan dp ON p.ID_pesanan = dp.ID_pesanan
                    JOIN menu m ON dp.ID_menu = m.ID_menu
                    JOIN kategori_menu km ON m.ID_kategori = km.ID_kategori
                    WHERE km.kategori = 'Makanan' AND p.tanggal_pemesanan = @tanggal
                    GROUP BY p.tanggal_pemesanan
                    UNION
                    SELECT 'Pendapatan minuman' AS Keterangan, SUM(m.harga * dp.jumlah) AS Jumlah, p.tanggal_pemesanan AS Tanggal
                    FROM pesanan p
                    JOIN detail_pesanan dp ON p.ID_pesanan = dp.ID_pesanan
                    JOIN menu m ON dp.ID_menu = m.ID_menu
                    JOIN kategori_menu km ON m.ID_kategori = km.ID_kategori
                    WHERE km.kategori = 'Minuman' AND p.tanggal_pemesanan = @tanggal
                    GROUP BY p.tanggal_pemesanan
                    UNION
                    SELECT 'Pendapatan snack' AS Keterangan, SUM(m.harga * dp.jumlah) AS Jumlah, p.tanggal_pemesanan AS Tanggal
                    FROM pesanan p
                    JOIN detail_pesanan dp ON p.ID_pesanan = dp.ID_pesanan
                    JOIN menu m ON dp.ID_menu = m.ID_menu
                    JOIN kategori_menu km ON m.ID_kategori = km.ID_kategori
                    WHERE km.kategori = 'Snack' AND p.tanggal_pemesanan = @tanggal
                    GROUP BY p.tanggal_pemesanan
                    UNION
                    SELECT 'Biaya Gaji' AS Keterangan, SUM(gaji) AS Jumlah, tgl_masuk AS Tanggal
                    FROM karyawan
                    WHERE tgl_masuk = @tanggal
                    GROUP BY tgl_masuk
                    UNION
                    SELECT 'Biaya Bahan' AS Keterangan, SUM(jumlah_pengeluaran) AS Jumlah, tanggal_pengeluaran AS Tanggal
                    FROM pengeluaran_operasional
                    WHERE ID_jenis_pengeluaran = (SELECT ID_jenis_pengeluaran FROM jenis_pengeluaran WHERE nama_pengeluaran = 'Bahan Baku') AND tanggal_pengeluaran = @tanggal
                    GROUP BY tanggal_pengeluaran
                    UNION
                    SELECT 'Biaya Listrik' AS Keterangan, SUM(jumlah_pengeluaran) AS Jumlah, tanggal_pengeluaran AS Tanggal
                    FROM pengeluaran_operasional
                    WHERE ID_jenis_pengeluaran = (SELECT ID_jenis_pengeluaran FROM jenis_pengeluaran WHERE nama_pengeluaran = 'Listrik') AND tanggal_pengeluaran = @tanggal
                    GROUP BY tanggal_pengeluaran
                    UNION
                    SELECT 'Laba Sebelum Pajak' AS Keterangan, SUM(total_harga) AS Jumlah, tanggal_pemesanan AS Tanggal
                    FROM pesanan
                    WHERE tanggal_pemesanan = @tanggal
                    GROUP BY tanggal_pemesanan
                    UNION
                    SELECT 'Pajak' AS Keterangan, SUM(total_tax) AS Jumlah, tanggal_pemesanan AS Tanggal
                    FROM pesanan
                    WHERE tanggal_pemesanan = @tanggal
                    GROUP BY tanggal_pemesanan
                    UNION
                    SELECT 'Laba Bersih' AS Keterangan, (SUM(total_harga) - SUM(total_tax)) AS Jumlah, tanggal_pemesanan AS Tanggal
                    FROM pesanan
                    WHERE tanggal_pemesanan = @tanggal
                    GROUP BY tanggal_pemesanan";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@tanggal", tanggal.Date)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
