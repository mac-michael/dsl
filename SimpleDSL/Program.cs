using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleDSL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wyrażenie do wyliczenia: ");
            var formula = Console.ReadLine();

            // Interpretacja
            var result = Interpreter.Evaluate(formula);
            Console.WriteLine("Wynik (interpretacja) to: " + result);

            // Generacja
            var func = CodeGenerator.Generate(formula);
            result = func();
            Console.WriteLine("Wynik (generacja) to: " + result);
        }
    }
}
