using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AbnormalConditions
{
    class SaturatedSteam : Steam
    {
        private const double P = 5.0;
        private const double Ro0 = 2.5;
        private const double K_ACP_F = 384;
        private const double K_ACP_Max = 1024;
        private const double FMax = 500;

        private const double DeltaO = 10;
        private const double Beta = 0.005;
        private const double K_ACP_L = 2560;
        private const double K_ACP = 4096;
        private const double DeltaP = 4000;

        public SaturatedSteam()
        {

        }

        internal override double CurrentRo(double p, double o = 0)
        {
            return 0.869 + 0.518 * p - 0.002375 * p * p;
        }

        internal override void OutputCorrectedValues()
        {
            Console.WriteLine("Saturated steam corrected values:");
            Console.WriteLine($"Consumption: {CorrectedConsumption(FMax, 0, P, Ro0)}");
            Console.WriteLine($"Level: {CorrectedLevel(K_ACP_L, K_ACP, Ro0, Beta, DeltaO)}");
        }
    }
}
