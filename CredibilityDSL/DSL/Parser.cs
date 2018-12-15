using System.IO;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace CredibilityDSL
{
    public class Parser
    {
        public static CommonTree Parse(string formula)
        {
            var m = new MemoryStream(Encoding.UTF8.GetBytes(formula));
            var input = new ANTLRInputStream(m);

            // Create lexer
            var lexer = new CredibilityDSLLexer(input);
            var tokens = new CommonTokenStream(lexer);

            // Create parser and start evaluating from start rule
            var parser = new CredibilityDSLParser(tokens);
            var tree = parser.start();

            var root = (CommonTree)tree.Tree;
            return root;
        }
    }
}