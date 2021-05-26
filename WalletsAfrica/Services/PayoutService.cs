using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletsAfrica.Constants;
using WalletsAfrica.Entities.Payout;
using WalletsAfrica.Entities.Useful;
using WalletsAfrica.Entities.Wallet;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class PayoutService
    {
        private readonly IWalletsAfricaClient client;

        public PayoutService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        public async Task<BankTransferDetailsResponse> GetBankTransferDetails(string transactionReference)
        {
            var response = await client.Post(Endpoints.BANKTRANSFERDETAILS, new { transactionReference, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<BankTransferDetailsResponse>(response);
        }

        public async Task<GenericResponse> BankTransfer(string BankCode,string AccountNumber, string AccountName, decimal Amount, string Narration ,string transactionReference)
        {
            var response = await client.Post(Endpoints.BANKACCOUNTTRANSFER, new { BankCode, AccountNumber, AccountName, Amount, transactionReference, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GenericResponse>(response);
        }

        public async Task<AccountEnquiryResponse> AccountEnquiry(string BankCode, string AccountNumber)
        {
            var response = await client.Post(Endpoints.BANKACCOUNTENQUIRY, new { BankCode, AccountNumber,SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<AccountEnquiryResponse>(response);
        }

        public async Task<List<GetBanksResponseData>> GetBanks()
        {
            var response = await client.Post(Endpoints.GETBANKS);
            return JsonConvert.DeserializeObject<List<GetBanksResponseData>>(response);
        }
    }
}
