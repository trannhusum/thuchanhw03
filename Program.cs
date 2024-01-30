using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanhw03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.Write("Moi nhap mot so tu nhien: ");
            int n=int.Parse(Console.ReadLine());
            if (n<2)
            {
                check = false;
            }
            else
            {
                 for (int i = 2; i < n-1; i++) {
                    if (n%i == 0)
                    {
                        check= false;
                    }
                }
            }
            if (check)
            {
                Console.WriteLine(n + " la so nguyen to");
            }
            else { Console.WriteLine(n + " khong phai la so nguyen to"); }
            Console.ReadKey();
        }
    }
}
