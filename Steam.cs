using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7AbnormalConditions
{
    public abstract class Steam
    {
        internal virtual double CorrectedConsumption(double f, double o, double p, double ro0)
        {
            return KRo(o, p, ro0) * f;
        }

        internal virtual double KRo(double o, double p, double ro0)
        {
            return Math.Sqrt(CurrentRo(p, o) / ro0);
        }

        internal abstract double CurrentRo(double p, double o = 0);

        internal virtual double CorrectedLevel(double k_l, double k_max, double ro0, double beta, double deltaO)
        {
            return k_l / (k_max * RoMax(ro0, beta, deltaO));
        }

        private double RoMax(double ro0, double beta, double deltaO)
        {
            return ro0 * (1 + beta * deltaO);
        }

        internal abstract void OutputCorrectedValues();
    }
}
