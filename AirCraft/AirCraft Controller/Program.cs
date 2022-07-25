using System;
using System.Globalization;

namespace Controle_de_abastecimento_de_aviões
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entradas:

            AprovarRota.Questions();

            //chamadas:
            Console.Clear();
             AprovarRota.CALTrechoP();
             AprovarRota.CALTrechoALT();
             AprovarRota.CALTrechoTotal();

            AprovarTrajeto.Aprova();







        }
    }
}

