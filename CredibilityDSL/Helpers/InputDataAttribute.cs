using System;

namespace CredibilityDSL
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