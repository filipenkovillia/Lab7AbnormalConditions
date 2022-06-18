using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AbnormalConditions
{
    class SupersaturatedSteam : Steam
    {
        private const double P = 10;
        private const double O = 230;
        private const double Ro0 = 3.0;
        private const double K_ACP_F = 283;
        private const double K_ACP_Max = 1024;
        private const double FMax = 800;

        private const double DeltaO = 10;
        private const double Beta = 0.005;
        private const double K_ACP_L = 2560;
        private const double K_ACP = 4096;
        private const double DeltaP = 4000;

        internal SupersaturatedSteam()
        {

        }

        internal override double CurrentRo(double p, double o)
        {
            return 1.2 - 0.013 * o + 0.72 * p + 0.36 * 1e-4 * o * o + 0.24 * 1e-2 * p * p - 0.14 * 1e-2 * o * p;
        }

        internal override void OutputCorrectedValues()
        {
            Console.WriteLine("Supersaturated steam corrected values:");
            Console.WriteLine($"Consumption: {CorrectedConsumption(FMax, O, P, Ro0)}");
            Console.WriteLine($"Level: {CorrectedLevel(K_ACP_L, K_ACP, Ro0, Beta, DeltaO)}");
        }
    }
}
