﻿using System;
using System.Globalization;
using System.Threading;

namespace Controle_de_abastecimento_de_aviões
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            while (i != 0)
            {
                //Entradas:
            Console.Write("                      ******Bem vindo ao AirCraft Controller******");
            Console.WriteLine("\n\nEscolha Algumas das opções abaixo:");
            Console.WriteLine("\n1-Verificar Voo\n0-Sair");
             i= int.Parse(Console.ReadLine());

           
                if (i == 1)
                {
                    AprovarRota.Questions();
                    //chamadas:
                    Console.Clear();
                    AprovarRota.CALTrechoP();
                    AprovarRota.CALTrechoALT();
                    AprovarRota.CALTrechoTotal();

                    //aprovação do voo
                    AprovarTrajeto.Aprova();
                }
                if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nPrograma encerrado");
                }
                else {
                    Console.Clear();
                    Console.WriteLine("***Comando inválido***\n\nTente Novamente!");
                    Thread.Sleep(5000);
                    Console.Clear();

                }
            }                   


           







        }
    }
}

