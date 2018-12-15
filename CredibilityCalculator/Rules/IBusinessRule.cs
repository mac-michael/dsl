using System;
using System.Linq;
using System.Text;

namespace CredibilityCalculator.Rules
{
    public interface IBusinessRule
    {
        Money Evaluate(ClientQuenstionForm data, BusinessRuleContext context);
    }
}
