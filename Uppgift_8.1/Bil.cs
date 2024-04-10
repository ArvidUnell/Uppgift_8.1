using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_8._1
{
    internal class Bil
    {
        private string märke;

        public string Märke
        {
            get
            {
                return märke;
            }
            set
            {
                märke = value;
            }
        }


        private string modell;

        public string Modell
        {
            get
            {
                return modell;
            }
            set
            {
                modell = value;
            }
        }


        private int årsmodell;

        public int Årsmodell
        {
            get
            {
                return årsmodell;
            }
            set
            {
                årsmodell = value;
            }
        }


        private int vikt;

        public int Vikt
        {
            get
            {
                return vikt;
            }
            set
            {
                if (value < 0)
                {
                    vikt = 0;
                }
                else
                {
                    vikt = value;
                }
            }
        }


        private int topphastighet;

        public int Topphastighet
        {
            get
            {
                return topphastighet;
            }
            set
            {
                if (value < 0)
                {
                    topphastighet = 0;
                }
                else
                {
                    topphastighet = value;
                }
            }
        }



        public void SkrivInfo()
        {
            Console.WriteLine("Märke: " + märke);
            Console.WriteLine("Modell: " + modell);
            Console.WriteLine("Årsmodell: " + årsmodell);
            Console.WriteLine($"Vikt: {vikt} kg");
            Console.WriteLine($"Topphastighet: {topphastighet} km/h");
        }
    }
}
