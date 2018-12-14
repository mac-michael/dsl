namespace CredibilityCalculator.Rules
{
    public class CredibilityPolicyWithRules : ICredibilityPolicy
    {
        public IBusinessRule[] Rules { get; set; }

        public CredibilityPolicyWithRules(params IBusinessRule[] rules)
        {
            Rules = rules;
        }

        public Money Calculate(ClientQuenstionForm data)
        {
            var c = new BusinessRuleContext();
            foreach (var rule in Rules)
                c.AddRuleResult(rule.Evaluate(data, c));

            return c.GetLastResult();
        }
    }
}