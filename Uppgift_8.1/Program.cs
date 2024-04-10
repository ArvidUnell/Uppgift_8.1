using System;
using Uppgift_8._1;

namespace Uppgift_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bil1 = new Bil();
            bil1.Märke = "Volvo";
            bil1.Modell = "V70";
            bil1.Årsmodell = 1998;
            bil1.Vikt = 1200;
            bil1.Topphastighet = 160;

            bil1.SkrivInfo();
        }
    }
}