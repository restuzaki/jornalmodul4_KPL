using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300029
{
    class KodeProduk
    {
        private static Dictionary<string, string> tableKodeProduk = new Dictionary<string, string>
        {
    {"Laptop", "E100" },
    { "Smartphone" ,"E101"},
    { "Tablet" ,"E102"},
    { "Headset" ,"E103"},
    { "Keyboard" , "E104"},
    { "Mouse", "E105"},
    { "Printer", "E106"},
    { "Monitor", "E107"},
    { "Smartwatch", "E108"},
    { "Kamera", "E10"}
        };
        public static string GetKodeProduk(string produk)
        {
            return tableKodeProduk.ContainsKey(produk) ? tableKodeProduk[produk] : "kode produk tidak ditentukan.";
        }
    }
     
    

};
