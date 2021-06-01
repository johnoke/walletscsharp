using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Entities.Cards;
using System.Collections.Generic;

namespace WalletsAfrica.Services
{
    public class CardServicex
    {
        public CardServicex(IWalletsAfricaClientx clientx)

        {
            this.clientx = clientx;
        }

        IWalletsAfricaClientx clientx;


        public async Task<NigerianStates> NigerianStatesAsync()
        {
            var response = await clientx.Get("/cards/states");
            return JsonConvert.DeserializeObject<NigerianStates>(response);
        }

        public async Task<IdentityTypes> IdentityTypesAsync()
        {
            var response = await clientx.Get("/cards/Idtypes");
            return JsonConvert.DeserializeObject<IdentityTypes>(response);
        }

        public async Task<ExchangeRates> ExchangeRatesAsync()
        {
            var response = await clientx.Get("/cards/rates");
            return JsonConvert.DeserializeObject<ExchangeRates>(response);
        }

    }
    public class CardService
    {
        public CardService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

      


        IWalletsAfricaClient client;

        public async Task<CreateCardResponse> CreateCardAsync( double amount, string firstName, string lastName, string email, string nameOnCard,
            string dob, string idNo, int idType, string currency, bool isPhysicalCard, string address, int stateId, int localId, string phoneNumber)
        {
            var response = await client.Post("/cards/create", new CreateCardRequest{ Amount = amount, FirstName = firstName, LastName = lastName, Email = email,
                NameOnCard = nameOnCard, Dob = dob, IdNo = idNo, IdType = idType, Currency = currency, IsPhysicalCard = isPhysicalCard, Address = address, StateId = stateId, LocalId = localId,
                PhoneNumber = phoneNumber, SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<CreateCardResponse>(response);
        }

        public async Task<FundCardResponse> FundCardAsync(string cardId, double amount)
        {
            var response = await client.Post("/cards/fund", new FundCardRequest
            {
                CardId = cardId,
                Amount = amount,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<FundCardResponse>(response);
        }

        public async Task<DebitCardResponse> DebitCardAsync(string cardId, double amount)
        {
            var response = await client.Post("/cards/withdraw", new DebitCardRequest
            {
                CardId = cardId,
                Amount = amount,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<DebitCardResponse>(response);
        }

        public async Task<FreezeCardResponse> FreezeCardAsync(string cardId)
        {
            var response = await client.Post("/cards/freeze", new FreezeCardRequest
            {
                CardId = cardId,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<FreezeCardResponse>(response);
        }

        public async Task<UnFreezeCardResponse> UnFreezeCardAsync(string cardId)
        {
            var response = await client.Post("/cards/unfreeze", new UnFreezeCardRequest
            {
                CardId = cardId,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<UnFreezeCardResponse>(response);
        }

        public async Task<CardDetailsResponse> CardDetailsAsync(string cardId)
        {
            var response = await client.Post("/cards/details", new CardDetailsRequest
            {
                CardId = cardId,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<CardDetailsResponse>(response);
        }

        public async Task<CardTransactionsResponse> CardTransactionsAsync(string cardId)
        {
            var response = await client.Post("/cards/transactions", new CardTransactionsRequest
            {
                CardId = cardId,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<CardTransactionsResponse>(response);
        }

        public async Task<ChangePinResponse> ChangePinAsync(string cardId, string pin)
        {
            var response = await client.Post("/cards/ChangePin", new ChangePinRequest
            {
                CardId = cardId,
                Pin = pin,
                SecretKey = client.SecretKey
            });
            return JsonConvert.DeserializeObject<ChangePinResponse>(response);
        }






        /* public async Task<AirtimePurchaseResponse> AirtimePurchaseAsync(string code, double amount, string phoneNumber)
         {
             var response = await client.Post("/bills/airtime/purchase", new AirtimePurchaseRequest { Code = code, Amount = amount, PhoneNumber = phoneNumber, SecretKey = client.SecretKey });
             return JsonConvert.DeserializeObject<AirtimePurchaseResponse>(response);
         }*/



    }
}
