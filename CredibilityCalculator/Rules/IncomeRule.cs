namespace CredibilityCalculator.Rules
{
    class IncomeRule : IBusinessRule
    {
        public Money Evaluate(ClientQuenstionForm data, BusinessRuleContext context)
        {
            return context.GetLastResult() + data.MonthlyIncome*CredibilityPolicy.MaxCreditLengthInMonths;
        }
    }
}