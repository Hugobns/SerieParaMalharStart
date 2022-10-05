using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algorimo31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, Nota3, media = 0;
            Console.WriteLine("Coloque a sua nota 1 :");
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coloque a sua nota 2 :");
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Coloque a sua nota 3 :");
            Nota3 = double.Parse(Console.ReadLine());

            media = (Nota1 + Nota2 + Nota3) / 3;
            Console.WriteLine("A sua média é :" + media) ;
            Console.ReadKey();
        }
    }
}