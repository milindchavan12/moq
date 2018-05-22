using System;
namespace CreditCardApplication
{
    public class Evaluator
    {
        private const int AutoReferalMaxAge = 20;
        private const int HighIncomeThreshold = 100_000;
        private const int LowIncomeThreshold = 20_000;


        public CreditCardDecision Evaluate(CreditCard cardApplication)
        {
            if(cardApplication.GrossAnualIncome >= HighIncomeThreshold)
            {
                return CreditCardDecision.AutoAccepted;
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
