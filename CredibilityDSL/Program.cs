using System;
using System.Collections.Generic;
using System.Linq;

namespace CredibilityDSL
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var form = new ClientQuenstionForm()
                           {
                               MonthlyIncome = 5000,
                               MonthlyCarCosts = 500,
                               MonthlyLivingCosts = 1500,
                               PeopleSupported = 2,

                               IsMan = true,
                               ShareValue = 50000,
                               IsITStuff = true,
                           };

            //form.GetInputData();

            ICredibilityPolicy policy = new DSLCredibilityPolicy(
                "+ dochod * maxOkresKredytowania",
                "- kosztSamochodu * maxOkresKredytowania",
                "* (1-0.25*(osobyNaUtrzymaniu-1))",
                "* 0.7",

                "Jesli mezczyzna to * 0.95",
                "+ akcje * 0.4",
                "Jesli informatyk to * 1.1",
                "Jesli polityk to * 0.8"
                );

            Money money = policy.Calculate(form);

            Console.WriteLine("Your credibility is: " + money);
        }
    }
}
