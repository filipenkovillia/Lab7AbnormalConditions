using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AbnormalConditions
{
    class Gas
    {
        private const double P = 4.6;
        private const double O = 240;
        private const double P0 = 2.0;
        private const double T0 = 293;
        private const double K_ACP_F = 1536;
        private const double K_ACP_Max = 4096;
        private const double FMax = 630;

        private const double a = 3.359;

        internal double CorrectedConsumption(double f, double o, double p, double t0, double p0)
        {
            return KRo(p, o, t0, p0) * f;
        }

        internal double KRo(double p, double o, double t0, double p0)
        {
            return Math.Sqrt(K(t0, p0) * (p + 1) / (o + 273));
        }

        internal double K(double t0, double p0)
        {
            return t0 / p0;
        }

        internal double CorrectedTemperature(double o, double t)
        {
            return (o + 273 - t) + a * (o + 273);
        }

        internal void OutputCorrectedValues()
        {
            Console.WriteLine("Gas corrected values:");
            Console.WriteLine($"Consumption: {CorrectedConsumption(FMax, O, P, T0, P0)}");
            Console.WriteLine($"Temperature: {CorrectedTemperature(O, T0)}");
        }
    }
}
