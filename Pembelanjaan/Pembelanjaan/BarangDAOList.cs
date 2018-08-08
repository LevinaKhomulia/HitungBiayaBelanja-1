using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pembelanjaan
{
    public class BarangDAOList
    {
        public List<Barang> listData = new List<Barang>();
        Barang barang = new Barang();
        public void TambahData(Barang barang)
        {
            if (barang.Harga <= 0 || Convert.ToInt32(barang.Pajak) < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                listData.Add(barang);
            }
        }

        public bool DeleteData  (Barang barang)
        {
            bool result = false;
            try
            {
                if (ItemIsExist(barang))
                {
                    Barang barangToDelete = null;
                    for (int i = 0; i < listData.Count ;  i++)
                    {
                        barangToDelete = listData[i];
                        if (barangToDelete.Nama.ToLower().Trim().Equals(barang.Nama.ToLower().Trim()))
                        {
                            break;
                        }
                    }
                    if (barangToDelete != null)
                    {
                        listData.Remove(barangToDelete);
                    }
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool UpdateData(Barang lama, Barang baru)
        {
            bool result = false;
            try
            {
                if (baru.Harga > 0 && Convert.ToInt32(baru.Pajak) >= 0)
                {
                    if (ItemIsExist(lama))
                    {
                        for (int i = 0; i < listData.Count; i++)
                        {
                            Barang item = listData[i];
                            if (item.Nama.ToLower().Trim().Equals(lama.Nama.ToLower().Trim()))
                            {
                                listData[i] = baru;
                                result = true;
                                break;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }                    
            return result;
        }

        public bool ItemIsExist(Barang barang)
        {
            if (listData?.Count > 0)
            {
                foreach (Barang item in listData)
                {
                    if (item.Nama.ToLower().Trim().Equals(barang.Nama.ToLower().Trim()))
                        return true;
                }
            }
            return false;
        }

    }
}




        public bool Update(Barang lama, Barang baru)
        {
            try
            {
                int a = Convert.ToInt32(baru.HargaBarang);
                int b = Convert.ToInt32(baru.PajakBarang);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
            bool result = false;
            if (Convert.ToInt32(baru.HargaBarang) > 0 && Convert.ToInt32(baru.PajakBarang) >= 0)
            {
                try
                {
                    if (ItemIsExist(lama))
                    {
                        for (int i = 0; i < ListBarang.Count; i++)
                        {
                            Barang item = ListBarang[i];
                            if (item.KodeBarang.ToLower().Trim().Equals(lama.KodeBarang.ToLower().Trim()))
                            {
                                ListBarang[i] = baru;
                                result = true;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }
        


    