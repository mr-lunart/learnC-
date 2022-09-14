using System;

namespace programObject
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine ("Program Sederhana, Dewanata Luneriazz 212410101067");
      Console.WriteLine ("");
      Program aplikasi = new Program();
      Console.WriteLine ("Sedan");

      aplikasi.SedanMobil();
      Console.WriteLine ("");
      
      Console.WriteLine ("Ikan");
      aplikasi.IkanHias();
      Console.WriteLine ("");
      
      Console.WriteLine ("PionCatur");
      aplikasi.Pion();
      Console.WriteLine ("");
      
      Console.WriteLine ("RekeningBank");
      aplikasi.Bank();
    }
    class Sedan
    {
      public int silinder;
      public int tahun;
      public string nama = "";
      public string pemilik = "";
      public string warna = "";

      public void silinderMesin(int silinder){
        this.silinder = silinder;
      }
      public void namaMobil (string nama){
        this.nama = nama;
      }
      public void namaPemilik (string name){
        this.pemilik = name;
      }
      public void jenisWarna ( string jenis){
        this.warna = jenis;
      }
      public void tahunMobil (int tahun){
        this.tahun = tahun;
      }
    }
    class Ikan
    {
      public int ukuran;
      public string nama = "";
      public string warna = "";
      public string jenis = "";
      public string merk = "";
      public void beratIkan (int ukuran)
      {
        this.ukuran = ukuran;
      }
      public void namaIkan (string namaikan)
      {
        this.nama = namaikan;
      }
      public void warnaIkan (string corak)
      {
        this.warna = corak;
      }
      public void jenisIkan ( string jenisikan)
      {
        this.jenis = jenisikan;
      }
      public void merkIkan (string merk)
      {
        this.merk = merk;
      }   
    }
    class PionCatur
    { 
      public string karakter = "";
      public string warna = "";
      public int jumlah;
      public int posisi;

      public void Karakter (string karakter)
      {
        this.karakter = karakter;
      }
      public void WarnaCatur ( string warna)
      {
        this.warna = warna;
      }
      public void JumlahPion (int jumlah)
      {
        this.jumlah = jumlah;
      }
      public void Posisi ( int posisi)
      {
        this.posisi =posisi;
      }
    }
    class RekeningBank
    {
      public string bank = "";
      public string cabang = "";
      public string nasabah = "";
      public int noPendaftaran;
      public int noRekening;
      public string alamat = "";

      public void NamaBank (string namabank){
        this.bank = namabank;
      }
      public void CabangBank (string cabang){
        this.cabang = cabang;
      }
      public void NamaNasabah (string namanasabah){
        this.nasabah = namanasabah;
      }
      public void NomorPendaftaran (int nomorpendaftaran){
        this.noPendaftaran = nomorpendaftaran;
      }
      public void NomorRekening (int nomorrekening){
        this.noRekening = nomorrekening;
      }
      public void Alamat (string alamat){
        this.alamat = alamat;
      }
    }

    public void SedanMobil()
    {
      Sedan mobil = new Sedan();
      mobil.silinderMesin(500);
      Console.WriteLine("Silinder Mobil : " + mobil.silinder);
      mobil.namaMobil("Mustang GT 150");
      Console.WriteLine("Nama Mobil : " + mobil.nama);
      mobil.namaPemilik("Dewanata");
      Console.WriteLine("Pemilik :" + mobil.pemilik);
      mobil.jenisWarna("Biru");
      Console.WriteLine("Warna : " + mobil.warna);
      mobil.tahunMobil(1987);
      Console.WriteLine("Tahun : " + mobil.tahun);
    }
    public void IkanHias()
    {
      Ikan ikan = new Ikan();
      ikan.beratIkan(100);
      Console.WriteLine("Berat Ikan : " + ikan.ukuran);
      ikan.namaIkan("Ikan Bakar Asam Manis");
      Console.WriteLine("Nama Ikan : " + ikan.nama);
      ikan.warnaIkan ("Hitam");
      Console.WriteLine("Warna : " + ikan.warna);
      ikan.jenisIkan ("Air Tawar");
      Console.WriteLine ("Jenis Ikan : " + ikan.jenis);
      ikan.merkIkan ("Samudra");
      Console.WriteLine ("Merk : " + ikan.merk);
    }
    public void Pion()
    {
      PionCatur catur = new PionCatur();
      catur.Karakter("Benteng");
      Console.WriteLine("Karakter Catur : " + catur.karakter);
      catur.WarnaCatur("Hitam Putih");
      Console.WriteLine("Warna Catur : " + catur.warna);
      catur.JumlahPion(16*2);
      Console.WriteLine("Jumlah Pion:" + catur.jumlah);
      catur.Posisi(45);
      Console.WriteLine("Posisi Catur :"+ catur.posisi);
    }
    public void Bank()
    {
      RekeningBank rekening = new RekeningBank();
      rekening.NamaBank ("BCA");
      Console.WriteLine ("Nama Bank : " + rekening.bank);
      rekening.CabangBank ("Jember, Sumbersari");
      Console.WriteLine ("Cabang Bank : " + rekening.cabang);
      rekening.NamaNasabah ("Dewanata");
      Console.WriteLine ("Nama Nasabah : " + rekening.nasabah);
      rekening.NomorPendaftaran (001);
      Console.WriteLine ("Nomor Pendaftaran : " + rekening.noPendaftaran);
      rekening.NomorRekening (336890678);
      Console.WriteLine ("Nomor Rekening : " + rekening.noRekening);
      rekening.Alamat ("Jalan Riau Jember");
      Console.WriteLine ("Domisili : " + rekening.alamat);
    }
  }
}