using System;
using System.Diagnostics;
using System.Linq;

namespace CredibilityDSL
{
    class DSLCredibilityPolicy : ICredibilityPolicy
    {
        private readonly Func<Money, ClientQuenstionForm, Money>[] _rules;
        public DSLCredibilityPolicy(params string[] rules)
        {
            var funcs = from r in rules
                        select CredibilityCodeGenerator.Generate(r);
            
            _rules = funcs.ToArray();
        }

        public Money Calculate(ClientQuenstionForm data)
        {
            Console.WriteLine("Credibility calculation");

            var credibility = new Money(0);
            foreach (var rule in _rules)
            {
                credibility = rule(credibility, data);
                Console.WriteLine("Rule step value: " + credibility);
            }

            return credibility;
        }
    }
}