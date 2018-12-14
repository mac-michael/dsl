namespace CredibilityCalculator.Rules
{
    class CarCostsRule : IBusinessRule
    {
        public Money Evaluate(ClientQuenstionForm data, BusinessRuleContext context)
        {
            return context.GetLastResult() + data.MonthlyCarCosts * CredibilityPolicy.MaxCreditLengthInMonths;
        }
    }
}