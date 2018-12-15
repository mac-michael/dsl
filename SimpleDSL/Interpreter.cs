using Antlr.Runtime.Tree;

namespace SimpleDSL
{
    public class Interpreter
    {
        public static int Evaluate(string formula)
        {
            CommonTree tree = Parser.Parse(formula);
            return EvaluateInternal(tree);
        }

        public static int EvaluateInternal(object t)
        {
            var tree = (CommonTree)t;

            if (tree.Type == SimpleLexer.ID)
            {
                if (tree.Text == "A") return 5;
                if (tree.Text == "B") return 7;
                throw new EvaluationException("Brak zdefiniowanej sta³ej.");
            }
            if (tree.Type == SimpleLexer.IntegerLiteral)
                return int.Parse(tree.Text);
            if (tree.Text == "*" && tree.Children != null)
                return EvaluateInternal(tree.Children[0]) * EvaluateInternal(tree.Children[1]);
            if (tree.Text == "+" && tree.Children != null)
                return EvaluateInternal(tree.Children[0]) + EvaluateInternal(tree.Children[1]);

            throw new EvaluationException("Niepoprawne drzewo.");
        }
    }
}