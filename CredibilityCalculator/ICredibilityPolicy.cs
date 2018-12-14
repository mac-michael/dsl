namespace CredibilityCalculator
{
    public interface ICredibilityPolicy
    {
        Money Calculate(ClientQuenstionForm data);
    }
}