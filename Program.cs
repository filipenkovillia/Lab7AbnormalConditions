using System;

namespace Lab7AbnormalConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            SaturatedSteam satSteam = new SaturatedSteam();
            Gas gas = new Gas();
            SupersaturatedSteam superSatSteam = new SupersaturatedSteam();

            satSteam.OutputCorrectedValues();
            gas.OutputCorrectedValues();
            superSatSteam.OutputCorrectedValues();
        }
    }
}
