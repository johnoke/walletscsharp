using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletsAfrica.Constants;
using WalletsAfrica.Entities.Self;
using WalletsAfrica.Entities.Useful;
using WalletsAfrica.Entities.Wallet;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class WalletService
    {
        private readonly IWalletsAfricaClient client;

        public WalletService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        public async Task<DebitResponse> DebitAsync(string transactionReference, decimal amount, string phoneNumber)
        {
            var response = await client.Post(Endpoints.DEBITWALLET, new { transactionReference, amount, phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<DebitResponse>(response);
        }

        public async Task<CreditResponse> CreditAsync(string transactionReference, decimal amount, string phoneNumber)
        {
            var response = await client.Post(Endpoints.CREDITWALLET, new { transactionReference, amount, phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<CreditResponse>(response);
        }

        public async Task<GeneratSubwalletResponse> GenerateSubWalletAsync(string firstName, string lastName, string email, DateTime dateOfBirth, string currency="NGN")
        {
            var response = await client.Post(Endpoints.GENERATESUBWALLET, new { firstName, lastName, email, dateOfBirth, currency, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GeneratSubwalletResponse>(response);
        }

        public async Task<RetrieveAccountNumberResponse> RetrieveAccountNumberAsync(string phoneNumber)
        {
            var response = await client.Post(Endpoints.RETRIEVEACCOUNTNUMBER, new { phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<RetrieveAccountNumberResponse>(response);
        }

        public async Task<GenericResponse> SetPasswordAsync(string phoneNumber, string password)
        {
            var response = await client.Post(Endpoints.SETPASSWORD, new { phoneNumber, password, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GenericResponse>(response);
        }

        public async Task<GenericResponse> SetPinAsync(string phoneNumber, string transactionPin)
        {
            var response = await client.Post(Endpoints.SETPIN, new { phoneNumber, transactionPin, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GenericResponse>(response);
        }

        public async Task<TransactionResponse> GetTransactionsAsync(string currency, int transactionType, DateTime dateFrom, DateTime dateTo, string transactionPin, string phoneNumber, int skip, int take)
        {
            var response = await client.Post(Endpoints.WALLETTRANSACTIONS, new { currency, transactionType, dateFrom, dateTo, skip, take, transactionPin, phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<TransactionResponse>(response);
        }

        public async Task<VerifyBvnResponse> VerifyBvnAsync(string phoneNumber, string bvn, DateTime dateOfBirth)
        {
            var response = await client.Post(Endpoints.VERIFYBVN, new { phoneNumber, bvn, dateOfBirth, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<VerifyBvnResponse>(response);
        }

        public async Task<GeneratSubwalletResponseData> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            var response = await client.Post(Endpoints.GETUSER, new { phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GeneratSubwalletResponseData>(response);
        }

        public async Task<GeneratSubwalletResponseData> GetUserByEmailAsync(string email)
        {
            var response = await client.Post(Endpoints.GETUSER, new { email, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GeneratSubwalletResponseData>(response);
        }

        public async Task<BalanceResponse> GetBalanceAsync(string currency, string phoneNumber)
        {
            var response = await client.Post(Endpoints.WALLETBALANCE, new { currency, phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<BalanceResponse>(response);
        }


    }
}
