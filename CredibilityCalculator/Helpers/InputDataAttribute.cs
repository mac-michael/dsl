using System;

namespace CredibilityCalculator
{
    public class InputDataAttribute : Attribute
    {
        public string Question { get; set; }

        public InputDataAttribute(string question)
        {
            Question = question;
        }
    }
}