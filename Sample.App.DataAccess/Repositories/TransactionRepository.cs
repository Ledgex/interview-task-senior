using Sample.App.Common.DataAccess;
using Sample.App.Common.DTOs;
using Sample.App.Common.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.App.DataAccess.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public async Task<List<TransactionDTO>> GetMarketValuesAsync()
        {
            var fakeTransactions = new List<TransactionDTO> {
                new TransactionDTO(new DateTime(2020, 2, 1), "TSLA", 424.69, 1000, TransactionType.Buy),
                new TransactionDTO(new DateTime(2020, 2, 5), "BABA", 172.53, 281, TransactionType.Buy),
                new TransactionDTO(new DateTime(2020, 2, 5), "V", 137.74, 2400, TransactionType.Buy),
                new TransactionDTO(new DateTime(2020, 3, 14), "TSLA", 421.11, 1000, TransactionType.Sell),
                new TransactionDTO(new DateTime(2020, 3, 14), "CVCII", 10000, TransactionType.Buy),
            };

            // Simulated fake db call
            return await Task.Run(() => fakeTransactions);
        }
    }
}
