using System;

namespace Sample.App.Common.DTOs
{
    public class MarketValueDTO
    {
        public MarketValueDTO(DateTime asOfDate, string investmentSymbol, double amount, double performance)
        {
            AsOfDate = asOfDate;
            InvestmentSymbol = investmentSymbol;
            Amount = amount;
            Performance = performance;
        }

        public DateTime AsOfDate { get; set; }
        public string InvestmentSymbol { get; set; }
        public double Amount { get; set; }
        public double Performance { get; set; }
    }
}
