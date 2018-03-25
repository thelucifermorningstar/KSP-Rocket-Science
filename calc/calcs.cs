using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KSP_Rocket_Science.calc
{

    class calcs
    {

        const double pi = 3.14159265359;

        public double deltaV(double totalMass, double emptyMass, double isp)
        {
            double deltaV;

            deltaV = Math.Log(totalMass / emptyMass) * 9.81 * isp;

            return Math.Round(deltaV, 2);

        }

        

        public double commNet(double finalOrbit, double radius, double gm, int sateliteNumber)
        {

            double orbitalTime = Math.Sqrt((4 * Math.Pow(pi, 2)) * Math.Pow(finalOrbit + radius, 3) / gm);
       
            int otherSatelite = sateliteNumber - 1;

            double res = Math.Pow(orbitalTime / sateliteNumber * otherSatelite, 2) * gm / (4 * Math.Pow(pi, 2));

            double initialOrbit = Math.Pow(res, 1.0 / 3.0) - radius;

            return Math.Round(initialOrbit, 2);


        }

    }

    public class body
    {
        public string name { get; set; }
        public double gm { get; set; }
        public double radius { get; set; }


        List<body> b = new List<body>();

       
    }
}
