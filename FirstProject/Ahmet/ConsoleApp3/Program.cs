using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {

                        break;
                    }
                case 2:
                    {
                        int a = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write($"{a} << 1 = ");
                            a <<= 1;
                            Console.Write($"{a}\n");
                        }
                        Console.Write($"{a} & 2 = ");
                        a &= 2;
                        Console.Write($"{a}\n");
                        Console.Write($"{a} | 8 = ");
                        a |= 8;
                        Console.Write($"{a}\n");
                        while (a != 0)
                        {
                            Console.Write($"{a} >> 1 = ");
                            a >>= 1;
                            Console.Write($"{a}\n");
                        }
                        Console.ReadKey();
                        break;
                    }
            case 3:
                    {
                        int heigth = int.Parse(Console.ReadLine());
                        char symb = char.Parse(Console.ReadLine());
                        int Base = 1,l,c;
                        for (int i = 0; i < heigth; i++) Base += 2;
                        l = (Base - 1) / 2;
                        c = 1;

                        for (int i =0;i<heigth;i++)
                        {
                            for (int lm = 0; lm < l; lm++)
                                Console.Write(" ");
                            for (int lm = 0; lm < c; lm++)
                                Console.Write(symb);
                            for (int lm = 0; lm < l; lm++)
                                Console.Write(" ");
                            l--; c+=2;
                            Console.Write("\n");
                        }
                        Console.ReadKey();
                        break;
                    }
            default:
            break;
            }

            
        }
    }
}
