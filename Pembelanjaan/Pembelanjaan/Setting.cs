using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pembelanjaan
{
    public class Setting
    {
        public static string GetConnectionString()
        {
            return @"Data Source = (localdb)\mssqllocaldb; 
                        Initial Catalog = HitungBiayaBelanja; 
                        Integrated Security = True;";
        }
    }
}
