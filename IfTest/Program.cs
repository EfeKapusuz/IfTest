using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kullanıcı adını giriniz");
            string kullanici_adi = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz");
            string sifre = Console.ReadLine();

            if(kullanici_adi == "admin" && sifre == "123456")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı Ve Şifre Hatalı");

            }
        }
    }
}
