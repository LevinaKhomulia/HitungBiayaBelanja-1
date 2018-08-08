using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pembelanjaan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pembelanjaan.Tests
{
    [TestClass()]
    public class BarangDAOListTests
    {
        BarangDAOList daoBarang;
        List<Barang> listData = new List<Barang>();

        [TestMethod()]
        public void TambahDataTest()
        {
            listData.Add(new Barang
            {
                Kode = "0001",
                Nama = "Buku",
                Harga = 12000,
                Pajak = "10"
            });
            daoBarang.listData.Add(new Barang
            {
                Kode = "0001",
                Nama = "Buku",
                Harga = 12000,
                Pajak = "10"
            });
            //BarangDAOList barang = new BarangDAOList();
            daoBarang.TambahData(listData);
        }
    }
}

// Membuat Unit Test 
[TestClass()]
// Membuat class BarangDAOTest 
public class BarangDAOTestTests
{
    // Membuat objek BarangDAOTest yang bernama DAOTest 
    public BarangDAOTest DAOTest;

    // Membuat constructor BarangDAOTestTests 
    public BarangDAOTestTests()
    {
        DAOTest = new BarangDAOTest();
    }

    [TestMethod()]
    // Membuat Test Penambahan Barang 
    public void AddBarangCountTesting()
    {
        // Membuat List Barang yang bernama test1 
        List<Barang> test1 = new List<Barang>();

        // Membuat tes ada / tidaknya pemasukkan data kedalam List barang test1 
        test1.Add(new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        });
        // Membuat tes ada / tidaknya pemasukkan data kedalam List barang yang dibentuk di BarangDAOTest yang bernama ListBarang 
        DAOTest.ListBarang.Add(new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        });
        // Jika ada pemasukan ke dalam list, maka count akan berfungsi untuk menghitung jumlah data yang dimasukkan 
        Assert.AreEqual(test1.Count, DAOTest.ListBarang.Count);
    }

    [TestMethod()]
    // ExpectedException merupakan hasil yang diharapkan 
    [ExpectedException(typeof(ArgumentException))]
    // Tes melakukan penambahan angka minus 
    public void AddBarangTestingMin()
    {
        // Tes penginputan angka minus pada harga dan pajak 
        DAOTest.Insert(new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0002",
            HargaBarang = "-3",
            PajakBarang = "10"
        });
    }

    [TestMethod()]
    // ExpectedException merupakan hasil yang diharapkan 
    [ExpectedException(typeof(ArgumentException))]
    // Tes melakukan penambahan string pada data 
    public void AddBarangTestingString()
    {
        // Penginputan string pada harga dan pajak 
        DAOTest.Insert(new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0002",
            HargaBarang = "ss",
            PajakBarang = "ss"
        });
    }

    [TestMethod()]
    // Tes melakukan update pada suatu barang 
    public void UpdateBarangCountTesting()
    {
        // Tes mendaftar barang ke dalam objek Barang yang bernama lama 
        Barang lama = new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        };
        // P 
        DAOTest.ListBarang.Add(lama);

        Barang baru = new Barang
        {
            NamaBarang = "pensil",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"

        };
        DAOTest.Update(lama, baru);

        List<Barang> Test1 = new List<Barang>();
        Test1.Add(new Barang
        {
            NamaBarang = "pensil",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        });
        Assert.AreEqual(DAOTest.ListBarang.Count, Test1.Count);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentException))]
    public void UpdateBarangMinTesting()
    {
        Barang lama = new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        };
        DAOTest.ListBarang.Add(lama);
        Barang baru = new Barang
        {
            NamaBarang = "pensil",
            KodeBarang = "0001",
            HargaBarang = "-2",
            PajakBarang = "10"

        };
        DAOTest.Update(lama, baru);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentException))]
    public void UpdateBarangStringTesting()
    {
        Barang lama = new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        };
        DAOTest.ListBarang.Add(lama);
        Barang baru = new Barang
        {
            NamaBarang = "pensil",
            KodeBarang = "0001",
            HargaBarang = "10",
            PajakBarang = "ss"

        };
        DAOTest.Update(lama, baru);
    }

    [TestMethod()]
    public void DeleteBarangCountTesting()
    {
        Barang lama = new Barang
        {
            NamaBarang = "buku",
            KodeBarang = "0001",
            HargaBarang = "20000",
            PajakBarang = "10"
        };
        DAOTest.ListBarang.Add(lama);
        DAOTest.DeleteBarang(lama);
        List<Barang> test = new List<Barang>();
        Assert.AreEqual(test.Count, DAOTest.ListBarang.Count);
    }
}