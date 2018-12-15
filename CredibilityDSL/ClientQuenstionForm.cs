using System;

namespace CredibilityDSL
{
    public class ClientQuenstionForm
    {
        [InputData("Enter monthly income")]
        [CredibilityDSLName("dochod")]
        public Money MonthlyIncome { get; set; }

        [CredibilityDSLName("kosztSamochodu")]
        public Money MonthlyCarCosts { get; set; }

        [CredibilityDSLName("kosztZycia")]
        public Money MonthlyLivingCosts { get; set; }

        [CredibilityDSLName("osobyNaUtrzymaniu")]
        public int PeopleSupported { get; set; }

        [CredibilityDSLName("maxOkresKredytowaniaWLatach")]
        public int MaxCreditLengthInYears
        {
            get { return 25; }
        }

        public int MonthsInYear
        {
            get { return 12; }
        }

        [CredibilityDSLName("maxOkresKredytowania")]
        public int MaxCreditLengthInMonths
        {
            get { return MaxCreditLengthInYears*MonthsInYear; }
        }

        [CredibilityDSLName("mezczyzna")]
        public bool IsMan { get; set; }

        [CredibilityDSLName("informatyk")]
        public bool IsITStuff { get; set; }

        [CredibilityDSLName("polityk")]
        public bool IsPolitician { get; set; }

        [CredibilityDSLName("akcje")]
        public Money ShareValue { get; set; }
    }

    public class CredibilityDSLNameAttribute : Attribute
    {
        public string Name { get; set; }

        public CredibilityDSLNameAttribute(string name)
        {
            Name = name;
        }
    }
}