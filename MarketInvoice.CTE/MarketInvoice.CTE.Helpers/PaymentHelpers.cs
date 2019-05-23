using System;

namespace MarketInvoice.CTE.Helpers
{
    public static class PaymentHelpers
    {
        public static decimal GetPayment(decimal amount, int numberOfPayment, decimal apr)
        {
            var rate = apr / 100 / numberOfPayment;
            return Math.Round((amount * rate) / (decimal)(1 - Math.Pow((double)(1 + rate), -numberOfPayment)), 2, MidpointRounding.AwayFromZero);
        }

        public static decimal GetInterest(decimal amount, int numberOfPayment, decimal apr)
        {
            var rate = apr / 100 / numberOfPayment;
            return Math.Round(amount * rate, 2, MidpointRounding.AwayFromZero);
        }
    }
}