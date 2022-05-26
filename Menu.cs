using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Menu
    {
        public static void m()
        {
            Console.WriteLine("Cash Desk in the stor");
            Console.WriteLine("Start");
            while(true)
            {
                Autorization.Auto();
                Console.WriteLine("Choose an action: ");
                Console.WriteLine("1: Return");
                Console.WriteLine("2: Realization");
                Console.WriteLine("3: Delivery");
                Console.WriteLine("4: Info about the goods in stock");
                Console.WriteLine("0: Exit");
                string line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        Return.R();
                        break;
                    case "2":
                        Realization.N();
                        break;
                    case "3":
                        Delivery.D();
                        break;
                    case "4":
                        Search.S();
                        break;
                    case "0":
                        Console.WriteLine("Exit the program");
                        Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }
        }
        }
    }
}
