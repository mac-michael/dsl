namespace CredibilityCalculator
{
    public struct Money
    {
        public int Value { get; set; }

        public Money(int value) : this()
        {
            Value = value;
        }

        public static Money operator +(Money m, Money m2)
        {
            return new Money(m.Value + m2.Value);
        }

        public static Money operator *(Money m, Money m2)
        {
            return new Money(m.Value * m2.Value);
        }


        public static Money operator *(Money m, decimal n )
        {
            return new Money((int) (m.Value * n));
        }

        public static Money operator *(Money m, int n)
        {
            return new Money(m.Value * n);
        }

        public static Money operator -(Money m, Money m2)
        {
            return new Money(m.Value - m2.Value);
        }

        public static implicit operator Money(int value)
        {
            return new Money(value);
        }

        public static bool operator <(Money m, Money m2)
        {
            return m.Value.CompareTo(m2.Value) < 0;
        }

        public static bool operator >(Money m, Money m2)
        {
            return m.Value.CompareTo(m2.Value) > 0;
        }

        public static bool operator >=(Money m, Money m2)
        {
            return m.Value.CompareTo(m2.Value) >= 0;
        }

        public static bool operator <=(Money m, Money m2)
        {
            return m.Value.CompareTo(m2.Value) <= 0;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}