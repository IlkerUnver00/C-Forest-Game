using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.OrmanOyunu.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Bir ormanda uyandın. İlerde bir yol var. Arkanda bir köpri var. Ne yapmak istersin?[Köprü/Yol]\nCevap:");
            string cevap = Console.ReadLine();
            if (cevap=="Köprü")
            {

                Console.Write("Köprü sonunda sağa giden bir yol var ve karanlık, vahşi hayvanların olduğu bir yol daha var. Ne yapmak istersin? [Karanlik Yol/Diğer Yol]\nCevap:");
                cevap = Console.ReadLine();
                if (cevap=="Karanlık Yol")
                {
                    Console.WriteLine("Karanlık yolda tuzaklar olduğunu farkettin.Koş.[Hızlı/Yavaş]");
                    cevap = Console.ReadLine();
                    if (cevap == "Hızlı")
                    {

                    }
                    else if (cevap == "Yavaş")
                    {
                        
                    }
                }
                else if(cevap=="Diğer Yol")
                {
                   
                    int ihtimal = rnd.Next(4);
                    if (ihtimal==0)
                    {
                        Console.WriteLine("Diğer yolu seçtin. Geçmeyi denedin. Başarılı oldun.");
                    }
                    else
                    {
                        Console.WriteLine("ÖLDÜN!!");
                    }
                  


                }
            }
            else if (cevap == "Yol")
            {
                int ihtimal = rnd.Next(5);


            }


        }
    }
}
