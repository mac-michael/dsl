using System;
using System.Globalization;
using System.Linq.Expressions;
using Antlr.Runtime.Tree;
using System.Linq;

namespace CredibilityDSL
{
    class CredibilityDslVisitor
    {
        private ParameterExpression _lastValueParameter;
        private ParameterExpression _clientRequestForm;

        public Expression<Func<Money, ClientQuenstionForm, Money>> VisitTree(CommonTree tree)
        {
            _lastValueParameter = Expression.Parameter(typeof(Money), "n");
            _clientRequestForm = Expression.Parameter(typeof(ClientQuenstionForm), "f");
            return Expression.Lambda<Func<Money, ClientQuenstionForm, Money>>(Visit(tree), _lastValueParameter, _clientRequestForm);
        }

        private Expression Visit(CommonTree tree)
        {
            switch (tree.Type)
            {
                case CredibilityDSLLexer.MINUS:
                case CredibilityDSLLexer.MULTIPLY:
                case CredibilityDSLLexer.DIVIDE:
                case CredibilityDSLLexer.PLUS:
                    if (tree.ChildCount == 1)
                        return VisitStartExpression(tree);
                    else if (tree.ChildCount == 2)
                        return VisitBinary(tree);
                    throw new InvalidOperationException("Invalid AST tree");
                case CredibilityDSLLexer.MODULO:
                case CredibilityDSLLexer.AND:
                case CredibilityDSLLexer.OR:
                case CredibilityDSLLexer.EQUALS:
                case CredibilityDSLLexer.NOTEQUALS:
                case CredibilityDSLLexer.LESSOREQUALS:
                case CredibilityDSLLexer.LESS:
                case CredibilityDSLLexer.GREATEROREQUALS:
                case CredibilityDSLLexer.GREATER:
                    return VisitBinary(tree);
                case CredibilityDSLLexer.CONDITION:
                    return VisitCondition(tree);
                case CredibilityDSLLexer.MONEY:
                    return VisitMoney(tree);
                case CredibilityDSLLexer.ID:
                    return VisitID(tree);
                default:
                    throw new InvalidOperationException("Invalid AST tree");
            }
        }

        private Expression VisitID(CommonTree tree)
        {
            var r = from p in typeof (ClientQuenstionForm).GetProperties()
                    let a = p.GetCustomAttributes(typeof (CredibilityDSLNameAttribute), true)
                        .Cast<CredibilityDSLNameAttribute>()
                        .FirstOrDefault()
                    select new {Key = a == null ? p.Name : a.Name, Value = p};

            var dic = r.ToDictionary(k => k.Key, v => v.Value);

            return Expression.Property(_clientRequestForm, dic[tree.Text]);
        }

        private Expression VisitBinary(CommonTree tree)
        {
            ExpressionType type;

            switch (tree.Type)
            {
                case CredibilityDSLLexer.PLUS:
                    type = ExpressionType.Add;
                    break;
                case CredibilityDSLLexer.MINUS:
                    type = ExpressionType.Subtract;
                    break;
                case CredibilityDSLLexer.MULTIPLY:
                    type = ExpressionType.Multiply;
                    break;
                case CredibilityDSLLexer.DIVIDE:
                    type = ExpressionType.Divide;
                    break;
                case CredibilityDSLLexer.MODULO:
                    type = ExpressionType.Modulo;
                    break;
                case CredibilityDSLLexer.AND:
                    type = ExpressionType.And;
                    break;
                case CredibilityDSLLexer.OR:
                    type = ExpressionType.Or;
                    break;
                case CredibilityDSLLexer.EQUALS:
                    type = ExpressionType.Equal;
                    break;
                case CredibilityDSLLexer.NOTEQUALS:
                    type = ExpressionType.NotEqual;
                    break;
                case CredibilityDSLLexer.LESSOREQUALS:
                    type = ExpressionType.LessThanOrEqual;
                    break;
                case CredibilityDSLLexer.LESS:
                    type = ExpressionType.LessThan;
                    break;
                case CredibilityDSLLexer.GREATEROREQUALS:
                    type = ExpressionType.GreaterThanOrEqual;
                    break;
                case CredibilityDSLLexer.GREATER:
                    type = ExpressionType.GreaterThan;
                    break;

                default:
                    throw new InvalidOperationException("Invalid AST tree.");
            }

            var arg1 = Visit((CommonTree)tree.Children[0]);
            var arg2 = Visit((CommonTree)tree.Children[1]);

            // AndAlso
            return Expression.MakeBinary(type, arg1, arg2);
        }

        private Expression VisitMoney(CommonTree tree)
        {
            // Get constructor with decimal param
            var constructor = typeof(Money).GetConstructor(new[] { typeof(decimal) });

            var money = Expression.New(constructor, Expression.Constant(decimal.Parse(tree.Text, CultureInfo.InvariantCulture)));
            return money;
        }

        private Expression VisitStartExpression(CommonTree tree)
        {
            ExpressionType type;

            switch (tree.Type)
            {
                case CredibilityDSLLexer.PLUS:
                    type = ExpressionType.Add;
                    break;
                case CredibilityDSLLexer.MINUS:
                    type = ExpressionType.Subtract;
                    break;
                case CredibilityDSLLexer.MULTIPLY:
                    type = ExpressionType.Multiply;
                    break;
                case CredibilityDSLLexer.DIVIDE:
                    type = ExpressionType.Divide;
                    break;
                default:
                    throw new InvalidOperationException("Invalid AST tree.");
            }

            var left = (CommonTree)tree.Children[0];
            return Expression.MakeBinary(type, _lastValueParameter, Visit(left));
        }

        private Expression VisitCondition(CommonTree tree)
        {
            var test = Visit((CommonTree)tree.Children[0]);
            var then = Visit((CommonTree)tree.Children[1]);

            return Expression.Condition(test, then, _lastValueParameter);
        }
    }
}