using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pembelanjaan
{
    public class Belanja
    {
        public string No { get; set; }
        public string Nama { get; set; }
        public int Quantity { get; set; }
        public decimal Harga { get; set; }
        public string Pajak { get; set; }
        public decimal SubTotal { get; set; }
    }
}
