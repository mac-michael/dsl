using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CredibilityCalculator.Rules;

namespace CredibilityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new ClientQuenstionForm()
                           {
                               MonthlyIncome = 5000,
                               MonthlyCarCosts = 500,
                               MonthlyLivingCosts = 1500,
                               PeopleSupported = 2
                           };

            //form.GetInputData();

            ICredibilityPolicy policy = GetSimplePolicy();
            //ICredibilityPolicy policy = GetRulePolicy();

            var money = policy.Calculate(form);

            Console.WriteLine("Your credibility is: "+ money);

        }

        private static CredibilityPolicyWithRules GetRulePolicy()
        {
            return new CredibilityPolicyWithRules(new IncomeRule(), new CarCostsRule(), 
                                                      new LivingConstsRule(), new PeopleSupportRule());
        }

        private static CredibilityPolicy GetSimplePolicy()
        {
            return new CredibilityPolicy();
        }
    }
}
