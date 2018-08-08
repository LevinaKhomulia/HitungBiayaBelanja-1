using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelanjaan
{
    public partial class FormHitung : Form
    {
        //   private Barang selectBarang;
        Barang temp = new Barang();

        List<Belanja> ListBelanja = new List<Belanja>();

        public FormHitung()
        {
            InitializeComponent();
            
        }

        private void FormHitung_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Belanja belanja = new Belanja();
            belanja.No = txtkode.Text;
            belanja.Nama = txtnama.Text;
            belanja.Quantity = Convert.ToInt32(txtjumlah.Text);
            belanja.Harga = temp.Harga;
            belanja.Pajak = temp.Pajak;
            belanja.SubTotal = temp.Harga * belanja.Quantity + (temp.Harga * belanja.Quantity * Convert.ToDecimal(belanja.Pajak));
            ListBelanja.Add(belanja);
            dataGridViewHitung.DataSource = ListBelanja.ToList();

            txtTotal.Text = ListBelanja.Sum(a => a.SubTotal ).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var daoBarang = new BarangDAO();
            var ListBarang = daoBarang.GetAllDataBarang();
            
            foreach (var item in ListBarang)
            {
                if(item.Kode == txtkode.Text){
                    temp = item;
                    break;
                }
            }
            txtnama.Text = temp.Nama;
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            int jumlah = Convert.ToInt32(txtjumlah.Text);
            if (jumlah + 1 <= temp.Quantity)
            {
                jumlah++;
                txtjumlah.Text = jumlah.ToString();
            }
            
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            int jumlah = Convert.ToInt32(txtjumlah.Text);
            if (jumlah - 1 >= 0)
            {
                jumlah--;
                txtjumlah.Text = jumlah.ToString();
            }
        }
    }
}
