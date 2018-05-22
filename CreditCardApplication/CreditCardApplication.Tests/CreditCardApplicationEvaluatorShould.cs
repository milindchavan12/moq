using System;
using Xunit;

namespace CreditCardApplication.Tests
{
    public class CreditCardApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighIncomeApplication()
        {
            var sut = new Evaluator(null);

            var creditApplication = new CreditCard
            {
                GrossAnualIncome = 110_000
            };

            var result = sut.Evaluate(creditApplication);

            Assert.Equal(CreditCardDecision.AutoAccepted, result);
        }

        [Fact]
        public void RefferApplicatioToHuman()
        {
            var sut = new Evaluator(null);

            var creditApplication = new CreditCard
            {
                Age = 19
            };

            var result = sut.Evaluate(creditApplication);

            Assert.Equal(CreditCardDecision.RefferedToHuman, result);
        }
    }
}
