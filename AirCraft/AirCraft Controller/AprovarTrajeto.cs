using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_abastecimento_de_aviões
{
    internal class AprovarTrajeto
    {
        public static void Aprova()
        {
            if (AprovarRota.TrechoTotal<=AprovarRota.TanqueTotal )
            {
                Console.WriteLine("Voo  autorizado");
            }
            else
            {
               Console.WriteLine("Voo não autorizado");
            }
            
        }
    }
}
