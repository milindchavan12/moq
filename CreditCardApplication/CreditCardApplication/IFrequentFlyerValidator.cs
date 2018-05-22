using System;
namespace CreditCardApplication
{
    public interface IFrequentFlyerValidator
    {
        bool IsValid(string frequentFlyerNumber);

        bool IsValid(string frequentFlyerNumber, out bool isValid);
    }
}
