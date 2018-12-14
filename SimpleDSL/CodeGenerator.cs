using System;
using System.Linq.Expressions;
using Antlr.Runtime.Tree;

namespace SimpleDSL
{
    public class CodeGenerator
    {
        public static Func<int> Generate(string formula)
        {
            CommonTree tree = Parser.Parse(formula);

            var e = GetExpression(tree);

            var lambda = Expression.Lambda<Func<int>>(e);
            return lambda.Compile();
        }

        public static Expression GetExpression(object t)
        {
            var tree = (CommonTree)t;

            if (tree.Type == SimpleLexer.ID)
            {
                if (tree.Text == "A") return Expression.Constant(5);
                if (tree.Text == "B") return Expression.Constant(7);
                throw new EvaluationException("Nie ma takiej sta³ej.");
            }
            if (tree.Type == SimpleLexer.IntegerLiteral)
                return Expression.Constant(int.Parse(tree.Text));
            if (tree.Text == "*" && tree.Children != null)
                return Expression.Multiply(GetExpression(tree.Children[0]), GetExpression(tree.Children[1]));
            if (tree.Text == "+" && tree.Children != null)
                return Expression.Add(GetExpression(tree.Children[0]), GetExpression(tree.Children[1]));

            throw new EvaluationException("Niepoprawne drzewo.");
        }
    }
}