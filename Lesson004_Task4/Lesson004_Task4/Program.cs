using System;
using System.Text;
using System.Text.Unicode;

namespace Lesson004_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Вгадайте число (0 - 10) :");
            int numb = int.Parse(Console.ReadLine());
            int r_numb = 5;
            string cor = "Вгадав";
            string incor = "Не вгадав";
            string res;

            res = numb == r_numb ? cor : incor;

            //if (numb == r_numb)
            //    res = cor;
            //else
            //    res = incor;

            Console.WriteLine(res);

        }
    }
}
