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
    public partial class FrmEdit : Form
    {
        bool _result = false;
        string _kode = string.Empty;

        public bool Run(FrmEdit form)
        {
            form.ShowDialog();
            return _result;
        }

        public FrmEdit(string kode)
        {
            InitializeComponent();
            _kode = _kode;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            Barang barang = new BarangDAO().GetDataBarangByKode(_kode);
            if (barang != null)
            {
                this.txtkode.Text = barang.Kode;
                this.txtnama.Text = barang.Nama;
                //Convert.ToDecimal(this.txtharga.Text) = barang.Harga;
                this.txtpajak.Text = barang.Pajak;
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (this.txtnama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi nama barang terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnama.Focus();
            }
            else if (this.txtharga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi harga terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtharga.Focus();
            }
            else if (this.txtpajak.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi pajak terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpajak.Focus();
            }
            else
            {
                try
                {
                    Barang barang = new Barang
                    {
                        Kode = this.txtkode.Text.Trim(),
                        Nama = this.txtnama.Text.Trim(),
                        Harga = Convert.ToDecimal(this.txtharga.Text.Trim()),
                        Pajak = this.txtpajak.Text.Trim()
                    };
                    _result = new BarangDAO().Update(barang) > 0;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
