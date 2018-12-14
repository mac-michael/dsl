namespace CredibilityCalculator.Rules
{
    class LivingConstsRule : IBusinessRule
    {
        public Money Evaluate(ClientQuenstionForm data, BusinessRuleContext context)
        {
            return context.GetLastResult() + data.MonthlyLivingCosts * CredibilityPolicy.MaxCreditLengthInMonths;
        }
    }
}