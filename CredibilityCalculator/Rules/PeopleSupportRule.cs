namespace CredibilityCalculator.Rules
{
    class PeopleSupportRule : IBusinessRule
    {
        public Money Evaluate(ClientQuenstionForm data, BusinessRuleContext context)
        {
            return context.GetLastResult() + data.PeopleSupported * (int)(1-0.25*(data.PeopleSupported-1));
        }
    }
}