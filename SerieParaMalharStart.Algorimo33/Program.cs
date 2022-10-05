using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algorimo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor, antecessor = 0;
            Console.Write("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());
            sucessor = numero + 1;
            antecessor = numero - 1;
            Console.WriteLine("O sucessor é: {0}", sucessor);
            Console.WriteLine("O antecessor é: {0}", antecessor);
            Console.ReadLine();
        }
        
            

        


    }
}
