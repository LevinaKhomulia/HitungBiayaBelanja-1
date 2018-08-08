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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            FormTambah form = new FormTambah();
            if (form.Run(form))
            {
                QueryData(new Barang { Kode = "", Nama = "", Harga = 0.0M, Pajak = "" });
            }
            QueryData();
            this.Hide();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                FrmEdit form = new FrmEdit(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim());
                if (form.Run(form))
                {
                    QueryData(new Barang { Kode = "", Nama = "", Harga = 0.0M, Pajak = "" });
                }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                MessageBox.Show("Hapus Item Data Terpilih ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (new BarangDAO().Delete(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim()) > 0)
                    {
                        QueryData(new Barang { Kode = "", Nama = "", Harga = 0.0M, Pajak = "" });
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void QueryData(Barang barang = null)
        {
            List<Barang> listData = null;
            try
            {
                this.dataGridView1.DataSource = null;
                using (var daoBarang = new BarangDAO())
                {
                    if (barang == null)
                    {
                        listData = daoBarang.GetAllDataBarang();
                    }
                    else
                    {
                        listData = daoBarang.QueryData(barang);
                    }
                }
                if (listData != null)
                {
                    this.dataGridView1.DataSource = listData;
                    this.dataGridView1.Columns[0].DataPropertyName = nameof(Barang.Kode);
                    this.dataGridView1.Columns[1].DataPropertyName = nameof(Barang.Nama);
                    this.dataGridView1.Columns[2].DataPropertyName = nameof(Barang.Harga);
                    this.dataGridView1.Columns[3].DataPropertyName = nameof(Barang.Pajak);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            QueryData();
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            FormHitung form = new FormHitung();
            form.Show();
        }
    }
}
