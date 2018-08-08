using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pembelanjaan
{
    public class BarangDAO : IDisposable
    {
        SqlConnection _conn = null;
        string _kode = string.Empty;

        public BarangDAO()
        {
            try
            {
                _conn = new SqlConnection(Setting.GetConnectionString());
                _conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Barang> GetAllDataBarang()
        {
            List<Barang> listData = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from barang order by kode";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listData = new List<Barang>();
                            while (reader.Read())
                            {
                                listData.Add(new Barang
                                {
                                    Kode = reader["Kode"].ToString(),
<<<<<<< HEAD
                                    Nama = reader["Nama"].ToString(),
=======
                                    Nama = reader["Nama"].ToString(),                                   
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                                    Harga = Convert.ToDecimal(reader["Harga"].ToString()),
                                    Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                    Pajak = reader["Pajak"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listData;
        }

        public int Insert(Barang barang)
        {
            int result = 0;
            try
            {
<<<<<<< HEAD
                string sqlString = @"insert into barang values (@kode, @nama, @harga, @pajak)";
=======
                string sqlString = @"insert into barang values (@kode, @nama, @harga , @quantity, @pajak)";
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
<<<<<<< HEAD
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
=======
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);                   
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
                    cmd.Parameters.AddWithValue("@quantity", barang.Quantity);
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
                    result = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public int Update(Barang barang)
        {
            int result = 0;
<<<<<<< HEAD
            try
            {
                string sqlString =
                    @"update barang set nama = @nama, harga = @harga, pajak = @pajak where kode = @kode";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
=======
            SqlTransaction trans = null;
            try
            {
                trans = _conn.BeginTransaction();
                string sqlString =
                    @"update barang set nama = @nama, harga = @harga, quantity = @quantity , pajak = @pajak where kode = @kode";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.Transaction = trans;
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", barang.Kode);
                    cmd.Parameters.AddWithValue("@nama", barang.Nama);
                    cmd.Parameters.AddWithValue("@harga", barang.Harga);
<<<<<<< HEAD
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
=======
                    cmd.Parameters.AddWithValue("@quantity", barang.Quantity);
                    cmd.Parameters.AddWithValue("@pajak", barang.Pajak);
                    result = cmd.ExecuteNonQuery();
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                if (trans != null) trans.Rollback();
                throw ex;
            }
            finally
            {
                if (trans != null) trans.Dispose();
            }
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
            return result;
        }

        public int Delete(string kode)
        {
            int result = 0;
            try
            {
                string sqlString =
                    @"delete barang where kode = @kode";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = sqlString;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<Barang> QueryData(Barang barang)
        {
            List<Barang> listData = null;
            try
            {
                string sqlString = "select * from barang where kode like @kode, " +
                    "nama like @nama, harga like @harga," +
<<<<<<< HEAD
                    "kuantitas like @kuantitas";
=======
                    "quantity like @quantity";
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940

                using (SqlCommand cmd = new SqlCommand(sqlString, _conn))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", $"%{barang.Kode}%");
<<<<<<< HEAD
                    cmd.Parameters.AddWithValue("@nama", $"%{barang.Nama}%");
                    cmd.Parameters.AddWithValue("@harga", $"%{barang.Harga}%");
=======
                    cmd.Parameters.AddWithValue("@nama", $"%{barang.Nama}%");                   
                    cmd.Parameters.AddWithValue("@harga", $"%{barang.Harga}%");
                    cmd.Parameters.AddWithValue("@quantity", $"%{barang.Quantity}%");
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                    cmd.Parameters.AddWithValue("@pajak", $"%{barang.Pajak}%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listData = new List<Barang>();
                            while (reader.Read())
                            {
                                listData.Add(
                                    new Barang
                                    {
<<<<<<< HEAD
                                        Kode = reader["kode"].ToString(),
                                        Nama = reader["nama"].ToString(),
                                        Harga = Convert.ToDecimal(reader["harga"]),
=======
                                        Kode = reader["No"].ToString(),
                                        Nama = reader["nama"].ToString(),                                       
                                        Harga = Convert.ToDecimal(reader["harga"]),
                                        Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                                        Pajak = reader["pajak"].ToString()
                                    });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listData;
        }

        public Barang GetDataBarangByKode(string kode)
        {
            Barang barang = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _conn;
                    cmd.CommandText = @"select * from barang where kode = @kode";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@kode", kode);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
<<<<<<< HEAD
                        if (reader.Read())
                        {
                            barang = new Barang
                            {
                                Kode = reader["kode"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Harga = Convert.ToDecimal(reader["harga"].ToString()),
                                Pajak = reader["pajak"].ToString(),
                            };
                        }
=======
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                barang = new Barang
                                {
                                    Kode = reader["No"].ToString(),
                                    Nama = reader["nama"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"].ToString()),
                                    Harga = Convert.ToDecimal(reader["harga"].ToString()),
                                    Pajak = reader["pajak"].ToString(),
                                };
                            }
                        }

>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                    }
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD

=======
>>>>>>> 2a9a7c2e189b5630cdc2f39ea8039326062a7940
                throw ex;
            }
            return barang;
        }

        public void Dispose()
        {
            if (_conn != null) _conn.Close();
        }
    }

}

