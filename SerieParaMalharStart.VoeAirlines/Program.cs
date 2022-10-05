using SerieParaMalharStart.VoeAirlines.Entities;
using SerieParaMalharStart.VoeAirlines.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlines
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            Aeronave aero = new Aeronave();
            /*
             * Aeronave : Class
             * aero : É o objeto da Classe
             * = : É o que atribui
             * New : operador de instanciação
             * Instância : É o objeto (congretização de uma classe)
             * Aeronave() : Chmada ao construtor
             */
            // INTERFACE COM USUARIO
            
            Console.WriteLine("digite o Modelo: ");
            var entradaModelo = Console.ReadLine();
            Console.WriteLine("digite o Código: ");
            var entradaCodigo = Console.ReadLine();
            Console.WriteLine("digite o Fabricante: ");
            var entradaFabricante = Console.ReadLine();
            Console.WriteLine("digite o Matricula: ");
            var entradaMatricula = Console.ReadLine();
            Console.WriteLine("digite o Quantidade de Passageiro: ");
            var entradaQtdePassageiro = int.Parse(Console.ReadLine());
           
            //ATRIBUICOES 


            aero.Fabricante= entradaFabricante;
            aero.Matricula = entradaMatricula;
            aero.Modelo = entradaModelo;
            aero.Codigo = entradaCodigo;
            aero.Capacidade = entradaQtdePassageiro;
            
            //NOTICIA

            Console.WriteLine($"Jatinho Executivo do Messi é um {aero.Modelo}-{aero.Codigo} fabricado pela {aero.Fabricante} " +
                $"de mátricula {aero.Matricula}");
            Console.ReadKey();
        }
    }
}
