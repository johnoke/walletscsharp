using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Entities.Wallets;

namespace WalletsAfrica.Services
{
    public class WalletService
    {
        public WalletService(IWalletsAfricaClient client)
        {
            this.client = client;
        }
        IWalletsAfricaClient client;

        public async Task<DebitWalletResponse> DebitWalletAsync(string transactionReference, double amount, string phoneNumber)
        {
            var response = await client.Post("/wallet/debit", new DebitWalletRequest { TransactionReference = transactionReference, Amount = amount, PhoneNumber = phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<DebitWalletResponse>(response);
        }

        public async Task<CreditWalletResponse> CreditWalletAsync(string transactionReference, double amount, string phoneNumber)
        {
            var response = await client.Post("/wallet/credit", new DebitWalletRequest { TransactionReference = transactionReference, Amount = amount, PhoneNumber = phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<CreditWalletResponse>(response);
        }

        public async Task<GenerateWalletResponse> GenerateWalletAsync(string firstName, string lastName, string email, string dateOfBirth, string currency)
        {
            var response = await client.Post("/wallet/generate", new GenerateWalletRequest { FirstName = firstName, LastName = lastName, Email = email, SecretKey = client.SecretKey, DateOfBirth = dateOfBirth, Currency = currency });
            return JsonConvert.DeserializeObject<GenerateWalletResponse>(response);
        }

        public async Task<RetrieveAccountResponse> RetrieveAccountAsync(string phoneNumber)
        {
            var response = await client.Post("/wallet/nuban", new RetrieveAccountRequest { PhoneNumber = phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<RetrieveAccountResponse>(response);
        }

        public async Task<SetPasswordResponse> SetPasswordAsync(string phoneNumber, string password)
        {
            var response = await client.Post("/wallet/password", new SetPasswordRequest { PhoneNumber = phoneNumber, Password = password, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<SetPasswordResponse>(response);
        }

        public async Task<SetPinResponse> SetPinAsync(string phoneNumber, string transactionPin)
        {
            var response = await client.Post("/wallet/pin", new SetPinRequest { PhoneNumber = phoneNumber, TransactionPin = transactionPin, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<SetPinResponse>(response);
        }

        public async Task<SubTransactionResponse> SubTransactionAsync(int skip, int take, string dateFrom, string dateTo, int transactionType, string phoneNumber, string transactionPin, string currency)
        {
            var response = await client.Post("/wallet/transactions", new SubTransactionRequest { Skip = skip, Take = take, DateFrom = dateFrom, DateTo = dateTo, TransactionType = transactionType, PhoneNumber = phoneNumber, TransactionPin = transactionPin,  Currency = currency  , SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<SubTransactionResponse>(response);
        }


        public async Task<GetUserByPhoneResponse> GetUserByPhoneAsync(string phoneNumber)
        {
            var response = await client.Post("/wallet/getuser", new GetUserByPhoneRequest { PhoneNumber = phoneNumber, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GetUserByPhoneResponse>(response);
        }

        public async Task<GetUserByEmailResponse> GetUserByEmailAsync(string email)
        {
            var response = await client.Post("/wallet/getuser", new GetUserByEmailRequest { Email = email, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GetUserByEmailResponse>(response);
        }

        public async Task<GetSubBalanceResponse> GetSubBalanceAsync(string phoneNumber, string currency)
        {
            var response = await client.Post("/wallet/balance", new GetSubBalanceRequest { PhoneNumber = phoneNumber, Currency = currency, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<GetSubBalanceResponse>(response);
        }
    }
}
