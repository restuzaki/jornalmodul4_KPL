using System;
using Modul4_103022300029;

class Program
{
    static void Main()
    {
        Console.WriteLine("masukkan nama Produk: ");
        string produk = Console.ReadLine();
        Console.WriteLine($"Kode Produk {produk}: { KodeProduk.GetKodeProduk(produk)} ");
        Console.WriteLine("====================================================");
        FanLaptop fanLaptop = new FanLaptop();
        Console.WriteLine("state awal: " + fanLaptop.CurrrentState);
        fanLaptop.setTrigger(Trigger.modeup);
        fanLaptop.setTrigger(Trigger.modedown);
    }
}
