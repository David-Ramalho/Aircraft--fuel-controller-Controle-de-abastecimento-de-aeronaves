using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Controle_de_abastecimento_de_aviões
{
    internal class AprovarTrajeto
    {
        public static void Aprova()
        {
            if (AprovarRota.TrechoTotal<=AprovarRota.TanqueTotal )
            {
                 AprovarRota.ShowFormt();
                Thread.Sleep(5000);


            }
            else
            {
                ;
               Console.WriteLine("Voo não autorizado");
            }
            
        }
    }
}
