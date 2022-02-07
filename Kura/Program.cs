using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<string> Liste = new List<string>();
            int count = 0;
            int i = 0;

            Console.WriteLine("Toplam Kişi Sayısı: ");
            count = Convert.ToInt32(Console.ReadLine());

            while (i<count)
            {
                
                i += 1;
                Console.WriteLine(i.ToString()+". kisiyi giriniz");
                string userName = Console.ReadLine();

                if (userName=="1")
                {
                    break;
                }

                Liste.Add(userName);
            }

            
            Console.WriteLine("\n");
            Console.WriteLine("1.takim: ");
            for (int j = 0; j < count/2; j++)
            {   
                int index = random.Next(Liste.Count);
                Console.WriteLine(Liste[index]);
                Liste.RemoveAt(index);
            }

            Console.WriteLine("\n 2.takim: ");
            foreach (var item in Liste)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
