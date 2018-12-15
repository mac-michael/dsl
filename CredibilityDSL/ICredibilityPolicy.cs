namespace CredibilityDSL
{
    public interface ICredibilityPolicy
    {
        Money Calculate(ClientQuenstionForm data);
    }
}