using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  if (decisionParameters.decisionInput.mortgageType == 'Purchase' &&
            var mortgageType = "Purchase";
            ////decisionParameters.decisionInput.insuared &&
            //decisionParameters.gdsr <= 0.39 && decisionParameters.gdsr >= 0.01 &&
            var gdsr = 0.2;
            //decisionParameters.tdsr <= 0.44 && decisionParameters.tdsr >= 0.01 &&
            var tdsr = 0.2;
            //decisionParameters.decisionInput.averageBeconScore <= 900 && decisionParameters.decisionInput.averageBeconScore >= 680 &&
            var averageBeconScore = 680;
            //decisionParameters.decisionInput.totalR9 == 0 &&
            var totalR9 = 0;
            //decisionParameters.decisionInput.totalBankruptcies == 0 &&
            var totalBankruptcies = 0;
            //decisionParameters.decisionInput.amotizationPeriod <= 25 && decisionParameters.decisionInput.amotizationPeriod >= 5 &&
            var amotizationPeriod = 10;
            //decisionParameters.decisionInput.homeMortgageAmount <= 958298.96 && decisionParameters.decisionInput.homeMortgageAmount >= 50000 &&
            var homeMortgageAmount = 100000;
            //decisionParameters.decisionInput.totalHomeValue <= 999999.99 && decisionParameters.decisionInput.totalHomeValue >= 0.01 &&
            var totalHomeValue = 10;
            //decisionParameters.ltv <= 0.95 && decisionParameters.ltv >= 0.8)
            var ltv = 0.8;
            
            //Path A
            if (mortgageType == "Purchase" &&
               //decisionParameters.decisionInput.insuared &&
               gdsr <= 0.39 && gdsr >= 0.01 &&
               tdsr <= 0.44 && tdsr >= 0.01 &&
               averageBeconScore <= 900 && averageBeconScore >= 680 &&
               totalR9 == 0 &&
               totalBankruptcies == 0 &&
               amotizationPeriod <= 25 && amotizationPeriod >= 5 &&
               homeMortgageAmount <= 958298.96 && homeMortgageAmount >= 50000 &&
               totalHomeValue <= 999999.99 && totalHomeValue >= 0.01 &&
               ltv <= 0.95 && ltv >= 0.8)
            {
                // execute path A
                Console.WriteLine("Path A is TRUE");
            }

            //Path C
            if (mortgageType == "Purchase" &&
               // decisionParameters.decisionInput.insuared &&
               gdsr <= 0.32 && gdsr >= 0.01 &&
               tdsr <= 0.41 && tdsr >= 0.01 &&
               averageBeconScore <= 900 && averageBeconScore >= 680 &&
               totalR9 == 0 &&
               totalBankruptcies == 0 &&
               amotizationPeriod <= 25 && amotizationPeriod >= 5 &&
               homeMortgageAmount <= 924999.96 && homeMortgageAmount >= 50000 &&
               totalHomeValue <= 999999.99 && totalHomeValue >= 0.01 &&
               ltv <= 0.80 && ltv >= 0.0)
            {
                // execute path C
                Console.WriteLine("Path C is TRUE");
            }
        }
    }
        
}
