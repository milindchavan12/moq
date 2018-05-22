using System;
namespace CreditCardApplication
{
    public class Evaluator
    {
        public IFrequentFlyerValidator _Validator { get; }

        private const int AutoReferalMaxAge = 20;
        private const int HighIncomeThreshold = 100_000;
        private const int LowIncomeThreshold = 20_000;


        public Evaluator(IFrequentFlyerValidator _validator)
        {
            _Validator = _validator;
        }


        public CreditCardDecision Evaluate(CreditCard cardApplication)
        {
            if(cardApplication.GrossAnualIncome >= HighIncomeThreshold)
            {
                return CreditCardDecision.AutoAccepted;
            }

            var isValidFrequentFlyerNumber = _Validator.IsValid(cardApplication.FrequentFlyerNumber);
            if(!isValidFrequentFlyerNumber)
            {
                return CreditCardDecision.RefferedToHuman;
            }


            if (cardApplication.Age <= AutoReferalMaxAge)
            {
                return CreditCardDecision.RefferedToHuman;
            }

            if (cardApplication.GrossAnualIncome <= LowIncomeThreshold)
            {
                return CreditCardDecision.AutoDeined;
            }

            return CreditCardDecision.RefferedToHuman;
        }
    }
}
