using Sample.App.Common.Enums;
using System;

namespace Sample.App.Common.DTOs
{
    public class TransactionDTO
    {
        public TransactionDTO(DateTime tradeDate, string investmentSymbol, double price, double units, TransactionType type)
        {
            TradeDate = tradeDate;
            InvestmentSymbol = investmentSymbol;
            TransactionType = type;
            Price = price;
            Units = units;
            Amount = price * units;
        }

        public TransactionDTO(DateTime tradeDate, string investmentSymbol, double amount, TransactionType type)
        {
            TradeDate = tradeDate;
            InvestmentSymbol = investmentSymbol;
            TransactionType = type;
            Amount = amount;
        }

        public DateTime TradeDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string InvestmentSymbol { get; set; }
        public double Amount { get; set; }
        public double? Price { get; set; }
        public double? Units { get; set; }
    }
}
