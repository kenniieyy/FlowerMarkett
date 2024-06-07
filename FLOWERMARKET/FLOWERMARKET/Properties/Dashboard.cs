using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLOWERMARKET.Properties
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonKasir_Click(object sender, EventArgs e)
        {
            // Membuat instance baru dari form Kasir
            Kasir formKasir = new Kasir();

            // Menampilkan form Kasir
            formKasir.Show();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            // Membuat instance baru dari form Barang
            Barang formbarang = new Barang();

            // Menampilkan form Barang
            formbarang.Show();
        }

        private void buttonTransaksi_Click(object sender, EventArgs e)
        {
            // Membuat instance baru dari form Transaksi
            Transaksi formTransaksi = new Transaksi();

            // Menampilkan form Transaksi
            formTransaksi.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Menutup aplikasi
            Application.Exit();
        }
    }
}
