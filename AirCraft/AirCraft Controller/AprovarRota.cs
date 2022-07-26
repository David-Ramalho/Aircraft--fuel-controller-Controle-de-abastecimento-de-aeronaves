using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_abastecimento_de_aviões
{
    internal class AprovarRota
    {
        public static float MediaLKM;
        public static float TanqueTotal;
        public static float Trecho;
        public static float TrechoAlt;
        public static float Gaso;
        public static float TrechoP;
        public static float TrechoALT;
        public static float TrechoTotal;
        public static float Margem;


        public static void Questions()
        {
            //Entradas:
            Console.Clear();
            Console.Write("                      ******Bem vindo ao AirCraft Controller******");
            Console.WriteLine("\n\nInforme a média dos litros por KM: ");
            MediaLKM = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a capacidade máxima do tanque: ");
            TanqueTotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em Km do trecho de viagem principal: ");
            Trecho = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade em Km do trecho alternativo: ");
            TrechoAlt = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de gasolina em Litros no tanque da aeronave: ");
            Gaso = float.Parse(Console.ReadLine());

        }


        public static float CALTrechoP()
        {
            TrechoP = Trecho * MediaLKM;
            return TrechoP;
        }

        public static float CALTrechoALT()
        {
            TrechoALT = TrechoAlt * MediaLKM;
            return TrechoALT;
        }

        public static float CALTrechoTotal()
        {
            Margem = (TrechoALT + TrechoP) * 30 / 100;
            TrechoTotal = (TrechoALT + TrechoP) + AprovarRota.Margem;
            return TrechoTotal;
        }

        //mostrar os resultados em formato pré-definido.
        public static float NeedGas = TrechoTotal - Gaso;
        public static void ShowFormt()
        {

            Console.WriteLine("Trecho Principal: " + TrechoP.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Trecho Alternativo: " + TrechoALT.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Total dos trechos com margem: " + TrechoTotal.ToString("F2"), CultureInfo.InvariantCulture);            
            Console.WriteLine("Combustivel necessário para ambos os trechos com margem: " + NeedGas.ToString("F2"), CultureInfo.InvariantCulture);

        }



        }
    }

