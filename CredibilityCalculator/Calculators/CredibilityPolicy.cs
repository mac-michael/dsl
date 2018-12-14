namespace CredibilityCalculator
{
    public class CredibilityPolicy : ICredibilityPolicy
    {
        public const int MaxCreditLengthInYears = 25;
        public const int MonthsInYear = 12;
        public const int MaxCreditLengthInMonths = MaxCreditLengthInYears*MonthsInYear;


        public Money Calculate(ClientQuenstionForm data)
        {
            Money m = 0;

            // Rule 1 - income
            m += data.MonthlyIncome * MaxCreditLengthInMonths;

            // Rule 2 - car costs
            m -= data.MonthlyCarCosts*MaxCreditLengthInMonths;

            // Rule 3 - living costs
            m -= data.MonthlyLivingCosts*MaxCreditLengthInMonths;

            // Rule 4 - people supported
            m *= (1 - 0.25m*(data.PeopleSupported - 1));

            return m;
        }
    }
}