namespace CredibilityCalculator
{
    public class ClientQuenstionForm
    {
        [InputData("Enter monthly income")]
        public Money MonthlyIncome { get; set; }
        public Money MonthlyCarCosts { get; set; }
        public Money MonthlyLivingCosts { get; set; }
        public int PeopleSupported { get; set; }

        public const int MaxCreditLengthInYears = 25;
        public const int MonthsInYear = 12;
        public const int MaxCreditLengthInMonths = MaxCreditLengthInYears * MonthsInYear;
    }
}