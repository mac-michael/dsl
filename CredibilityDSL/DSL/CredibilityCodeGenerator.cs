using System;
using System.Diagnostics;

namespace CredibilityDSL
{
    public class CredibilityCodeGenerator
    {
        public static Func<Money,ClientQuenstionForm, Money> Generate(string formula)
        {
            var tree = Parser.Parse(formula);

            var visitor = new CredibilityDslVisitor();
            var expression = visitor.VisitTree(tree);

            Console.WriteLine("Rule expression: " + expression);

            return expression.Compile();
        }
    }
}