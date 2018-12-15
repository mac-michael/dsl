using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            var tree = Parser.Parse("a + b + c * d");
        }
    }

    public class Parser
    {
        public static CommonTree Parse(string formula)
        {
            var m = new MemoryStream(Encoding.UTF8.GetBytes(formula));
            var input = new ANTLRInputStream(m);

            // Create lexer
            var lexer = new SimpleLexer(input);
            var tokens = new CommonTokenStream(lexer);

            // Create parser and start evaluating from start rule
            var parser = new SimpleParser(tokens);
            var tree = parser.start();

            var root = (CommonTree)tree.Tree;
            return root;
        }
    }
}
