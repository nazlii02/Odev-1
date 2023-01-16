using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_Login_Application_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı giriş sayfası uygulaması yapalım.
            //Kullanıcı adını ve şifresi doğru girerse "Tebrikler Başarılı Bir Şekilde Giriş Yaptınız." yazalım.
            //Yanlış Girerse hata verelim ve 3 hakkı kaldığını bildirelim.

            int YourRestRight = 3;
            Console.WriteLine("-----------LOGIN PAGE-----------\n");

            while (true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                string UserName = Console.ReadLine();

                Console.WriteLine("Kullanıcı Şifrenizi Giriniz: ");
                string UserPassword = Console.ReadLine();

                if (UserName == "Erva" && UserPassword == "1234Erva")
                {
                    Console.WriteLine("Congrulations! You have logined succesfully.");
                    break;
                }

                else
                {
                  
                    Console.WriteLine("***Either your name or password is wrong.\n");

                    if(YourRestRight > 0)
                    {
                        YourRestRight -= 1;
                    }

                    if(YourRestRight == 0)
                    {
                        Console.WriteLine("Thre is no right to login!!!");
                        break;
                    }

                }
            }
            Console.ReadLine();


        }
    }
}
