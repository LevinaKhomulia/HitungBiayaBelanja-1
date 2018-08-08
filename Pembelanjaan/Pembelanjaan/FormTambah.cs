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
    public partial class FormTambah : Form
    {
        bool _result = false;

        public FormTambah()
        {
            InitializeComponent();
        }

        public bool Run(FormTambah form)
        {
            form.ShowDialog();
            return _result;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (this.txtkode.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi kode terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtkode.Focus();
            }
            else if(this.txtnama.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi nama barang terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnama.Focus();
            }
            else if (this.txtharga.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi harga terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtharga.Focus();
            }
            else if(this.txtpajak.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, isi pajak terlebih dahulu ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpajak.Focus();
            }
            else
            {
                try
                {
                    using (var dao = new BarangDAO())
                    {
                        _result = dao.Insert(
                            new Barang
                            {
                                Kode = this.txtkode.Text.Trim(),
                                Nama = this.txtnama.Text.Trim(),
                                Harga = Convert.ToDecimal(this.txtharga.Text.Trim()),
                                Pajak = this.txtpajak.Text.Trim()
                            }) > 0;
                    }
                    this.Close();
                    FormMainMenu main = new FormMainMenu();
                    main.Show();

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

        private void txtkode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtkode.Text, "  ^ [0-9]"))
            {
                txtkode.Text = "";
            }
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtharga.Text, "  ^ [0-9]"))
            {
                txtharga.Text = "";
            }
        }

        private void txtpajak_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtpajak.Text, "  ^ [0-9]"))
            {
                txtpajak.Text = "";
            }
        }

        private void txtkode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtpajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
