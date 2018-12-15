using System.Collections.Generic;

namespace CredibilityCalculator.Rules
{
    public class BusinessRuleContext
    {
        readonly List<Money> _list = new List<Money>();

        public void AddRuleResult(Money value)
        {
            _list.Add(value);
        }

        public Money GetLastResult()
        {
            return _list[_list.Count - 1];
        }
    }
}