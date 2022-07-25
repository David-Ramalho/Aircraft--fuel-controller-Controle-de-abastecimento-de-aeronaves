using System;
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

        public static float TrechoTotal()
        {
            return (TrechoALT + TrechoP) * (30 / 100);
        }


    }
}
