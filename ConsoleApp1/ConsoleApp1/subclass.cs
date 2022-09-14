using System;

namespace SimpleApp
{
  class ProgramSubclass
  {
    static void Main(string[] args)
    {
      Console.WriteLine ("Inheritance, Dewanata Luneriazz 212410101067");
      ProgramSubclass apk = new ProgramSubclass();
      Console.WriteLine ("Sedan");
      apk.Otomotif1();
      Console.WriteLine ("");

      Console.WriteLine ("Truk");
      apk.Otomotif2();
      Console.WriteLine ("");

      Console.WriteLine ("SepedaMotor");
      apk.Otomotif3();
    }

    class Otomobil
    {
      public int silinder;
      public string merk = "General Motor";
    }
    class Sedan : Otomobil
    {
      public string nama = "";
      public string kesan = "";

      public void silinderOtomobil(int mesin)
      {
        this.silinder = mesin;
      }
      public void merkOtomobil (string merkMobil)
      {
        this.merk = merkMobil;
      }
      public void namaMobil (string nama)
      {
        this.nama = nama;
      }
      public void Kesan (string kesan)
      {
        this.kesan = kesan;
      }
    }
      class Truk : Otomobil
      {
      public int kapasitas;
      public int roda;
      public void silinderOtomobil(int mesin){
        this.silinder = mesin;
      }
      public void merkOtomobil (string merkMobil){
        this.merk = merkMobil;
      }
      public void KapasitasTruk( int kapasitas){
        this.kapasitas = kapasitas;
      }
      public void RodaTruk (int roda){
        this.roda = roda;
      }
    }
    class SepedaMotor : Otomobil
    {
      public string transmisi = "";
      public void silinderOtomobil(int mesin){
        this.silinder = mesin;
      }
      public void MerkOtomobil (string merkMobil){
        this.merk = merkMobil;
      }
      public void transmisiGear ( string gear){
        this.transmisi = gear;
      }
    }

    public void Otomotif1 ()
    {
      Sedan sedan = new Sedan ();
      sedan.silinderOtomobil (1000);
      Console.WriteLine ("Silinder Otomobil : " + sedan.silinder);
      sedan.merkOtomobil("Honda");
      Console.WriteLine ("Merk Otomobil : " + sedan.merk);
      sedan.namaMobil ("Mazda Civic");
      Console.WriteLine (" Nama Mobil :" + sedan.nama);
      sedan.Kesan ("Sederhana");
      Console.WriteLine ("Kesan Mobil Sedan:" + sedan.kesan);
    }
    public void Otomotif2 ()
    {
      Truk truk = new Truk ();
      truk.silinderOtomobil (2500);
      Console.WriteLine ("Silinder Otomobil:" + truk.silinder);
      truk.merkOtomobil("Honda");
      Console.WriteLine ("Merk Otomobil:" + truk.merk);
      truk.KapasitasTruk (1000);
      Console.WriteLine ("Kapasitas Truk:" + truk.kapasitas);
      truk.RodaTruk (6);
      Console.WriteLine ("Jumlah Roda Truk:" + truk.roda);
    }
    public void Otomotif3 ()
    {
      SepedaMotor sepedamotor = new SepedaMotor ();
      sepedamotor.silinderOtomobil (80);
      Console.WriteLine ("Kecepatan Otomobil:" + sepedamotor.silinder);
      sepedamotor.MerkOtomobil("Honda");
      Console.WriteLine ("Merk Otomobil:" + sepedamotor.merk);
      sepedamotor.transmisiGear ("Mudah dibawa");
      Console.WriteLine ("Sepeda Motor Simple:" + sepedamotor.transmisi);
    }
   }
  }