using Npgsql;
using System.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

//Copyright By Luneriazz atau Dewanata Hammada 212410101067

namespace DBmanager
{

    class ManagerDatabase
    {
        static void Main( String[] args )
        {
            DBHelperCLI cliApp = new DBHelperCLI();
            
        }
    }
    
    public class DBhelper   
    {
        private NpgsqlConnection connect;

        //config koneksi
        public DBhelper()
        {
            connect = new NpgsqlConnection();
            connect.ConnectionString = "Host=localhost; Username=postgres; Password=armoon85; Database=pboDatabase; CommandTimeout=10";
        }

        //insert data dengan 2 parameter
        public void DBInsert(string namaproduk = "-", string harga = "0")
        {
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "INSERT INTO dataproduk VALUES (default ,'" + namaproduk + "'," + harga + ");";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        //ambil data tabel dataproduk
        public DataTable DBReader()
        {
            DataTable dataread = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "SELECT * FROM dataproduk;";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                NpgsqlDataAdapter adapterdata = new NpgsqlDataAdapter(query);

                adapterdata.Fill(dataread);
                query.Dispose();
                connect.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return dataread;
        }

        // hapus baris berdasarkan id
        public void DBDelete(string id = "0")
        {
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "DELETE FROM dataproduk WHERE id = "+id+";";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //update data dengan berdasarkan id dan 2 parameter lain yaitu nama produk dan harga
        public void DBUpdate(string id = "0", string namaproduk = "-", string harga = "0")
        {
            try
            {
                connect.Open();
                NpgsqlCommand query = new NpgsqlCommand();
                query.Connection = connect;
                string querySql = "UPDATE dataproduk SET namaproduk = '"+namaproduk+"', harga = "+harga+" WHERE id = "+id+";";
                query.CommandText = querySql;
                query.CommandType = CommandType.Text;
                query.ExecuteNonQuery();
                query.Dispose();
                connect.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }

    //tampilan cli app
    public class DBHelperCLI
    {
    
        private DBhelper dbcontrol = new DBhelper();
        public DBHelperCLI()
        {
            while (true)
            {
                Console.WriteLine("1. Tambah Data Tabel");
                Console.WriteLine("2. Lihat Data Tabel");
                Console.WriteLine("3. Ubah Data Tabel");
                Console.WriteLine("4. Hapus Data Tabel");
                Console.WriteLine("99. Keluar Program");
                Console.WriteLine("");
                Console.Write("Masukan Pilihan Berdasarkan Angka : ");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Masukan Nama Produk : ");
                    var namaproduk = Console.ReadLine();

                    Console.Write("Masukkan Harga Produk: ");
                    var harga = Console.ReadLine();
                
                    dbcontrol.DBInsert(namaproduk ,harga);
                }

                else if (input == "2")
                {
                    this.DBReaderShow();
                }
                
                else if (input == "3")
                {
                    Console.Write("Masukan ID berupa angka ");
                    var id = Console.ReadLine();

                    Console.Write("Masukan Nama Produk : ");
                    var namaproduk = Console.ReadLine();

                    Console.Write("Masukkan Harga Produk: ");
                    var harga = Console.ReadLine();

                    dbcontrol.DBUpdate(id ,namaproduk ,harga);   
                }

                else if (input == "4")
                {
                    Console.Write("Masukan ID berupa angka ");
                    var id = Console.ReadLine();
                    if(id==null)
                    {
                        
                    }

                    else
                    {
                        dbcontrol.DBDelete(id);
                    }
                    
                    
                }

                else if (input == "99")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Masukan Salah Mohon Ulangi Lagi");
                }
            }

        }

        //wrapper untuk menampilkan hasil pengambilan data
        public void DBReaderShow()
        {
            var data = dbcontrol.DBReader();
            Console.WriteLine("Data : \n");
            for (int i=0;i<data.Rows.Count;i++)
            {
                Console.Write(i+1+". ");
                Console.Write(data.Rows[i]["id"]+", ");
                Console.Write(data.Rows[i]["namaproduk"]+", ");
                Console.Write(data.Rows[i]["harga"]+", ");
                Console.WriteLine("");
            }
             Console.WriteLine("\n");
        }
        
    }
}

