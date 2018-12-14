using System;

namespace SimpleDSL
{
    public class EvaluationException : Exception
    {
        public EvaluationException(string message) : base(message)
        {
        }
    }
}