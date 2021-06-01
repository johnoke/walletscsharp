using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Entities.Payout;
using System.Collections.Generic;

namespace WalletsAfrica.Services
{
    public class PayoutService
    {
        public PayoutService(IWalletsAfricaClient client)
        {
            this.client = client;
        }
        IWalletsAfricaClient client;

        public async Task<TransferDetailsResponse> TransferDetailsAsync(string transactionReference)
        {
            var response = await client.Post("/transfer/bank/details", new TransferDetailsRequest { TransactionReference = transactionReference, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<TransferDetailsResponse>(response);
        }

        public async Task<BankTransferResponse> BankTransferAsync(string bankCode, string accountNumber,
            string accountName, string transactionReference, double amount, string narration)
          
        {
            var response = await client.Post("/transfer/bank/account", new BankTransferRequest { BankCode = bankCode, AccountNumber = accountNumber, AccountName = accountName, TransactionReference = transactionReference, Amount = amount, Narration = narration, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<BankTransferResponse>(response);
        }

        public async Task<AccountEnquiryResponse> AccountEnquiryAsync(string bankCode, string accountNumber)

        {
            var response = await client.Post("/transfer/bank/account/enquire", new AccountEnquiryRequest { BankCode = bankCode, AccountNumber = accountNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<AccountEnquiryResponse>(response);
        }

        public async Task<List<GetBanksResponse>> GetBanksAsync()

        {
            var response = await client.Post("/transfer/banks/all");
            return JsonConvert.DeserializeObject<List<GetBanksResponse>>(response);
        }


    }
}
