using System;
using System.Globalization;

namespace Controle_de_abastecimento_de_aviões
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Entradas:
            Console.Clear();
            Console.WriteLine("Informe a média dos litros por KM: ");
            AprovarRota.MediaLKM = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a capacidade máxima do tanque: ");
            AprovarRota.TanqueTotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em Km do trecho de viagem principal: ");
            AprovarRota.Trecho = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em Km do trecho alternativo: ");
            AprovarRota.TrechoAlt = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de gasolina em Litros no tanque da aeronave: ");
            AprovarRota.Gaso = float.Parse(Console.ReadLine());

            //chamadas:
            Console.Clear();
            float TrechoP = AprovarRota.CALTrechoP();
            float TrechoAlt = AprovarRota.CALTrechoALT();
            float TrechoTotal = AprovarRota.TrechoTotal();





        }
    }
}

