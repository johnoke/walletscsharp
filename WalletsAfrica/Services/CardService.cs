using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WalletsAfrica.Constants;
using WalletsAfrica.Entities.Card;
using WalletsAfrica.Infrastructure;

namespace WalletsAfrica.Services
{
    public class CardService
    {
        private readonly IWalletsAfricaClient client;

        public CardService(IWalletsAfricaClient client)
        {
            this.client = client;
        }

        public async Task<StateResponse> GetStatesAsync()
        {
            var response = await client.Get(Endpoints.STATESANDLGAS);
            return JsonConvert.DeserializeObject<StateResponse>(response);
        }

        public async Task<IdTypeResponse> GetIdTypesAsync()
        {
            var response = await client.Get(Endpoints.IDENTITYTYPES);
            return JsonConvert.DeserializeObject<IdTypeResponse>(response);
        }
        public async Task<CreateCardRespose> CreateCardsAsync(decimal amount, string firstName, string lastName, string email, string nameOnCard, string dob, string idNo, string idType, string currency, bool isPhysicalCard, string address, string stateid, string localid)
        {
            var response = await client.Post(Endpoints.CREATECARD, new { amount, firstName, lastName, email, nameOnCard, dob, idNo, idType, currency, isPhysicalCard, address, stateid, localid, SecretKey = client.SecretKey }) ;
            return JsonConvert.DeserializeObject<CreateCardRespose>(response);
        }

        public async Task<FundCardResponse> FundCardsAsync(string cardId, decimal amount)
        {
            var response = await client.Post(Endpoints.FUNDCARD, new { cardId, amount, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<FundCardResponse>(response);
        }

        public async Task<DebitCardResponse> DebitCardsAsync(string cardId, decimal amount)
        {
            var response = await client.Post(Endpoints.DEBITCARD, new { cardId, amount, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<DebitCardResponse>(response);
        }

        public async Task<FreezeCardResponse> FreezeCardsAsync(string cardId)
        {
            var response = await client.Post(Endpoints.FREEZEECARD, new { cardId, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<FreezeCardResponse>(response);
        }

        public async Task<UnFreezeCardResponse> UnFreezeCardsAsync(string cardId)
        {
            var response = await client.Post(Endpoints.UNFREEZEECARD, new {cardId, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<UnFreezeCardResponse>(response);
        }

        public async Task<CardDetailsResponse> GetCardDetailsAsync(string cardId)
        {
            var response = await client.Post(Endpoints.CARDDETAILS, new { cardId, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<CardDetailsResponse>(response);
        }

        public async Task<CardTransactionResponse> CardTransactionsAsync(string cardId)
        {
            var response = await client.Post(Endpoints.CARDTRANSACTIONS, new { cardId, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<CardTransactionResponse>(response);
        }

        public async Task<ChangePinResponse> ChangePinAsync(string cardId, string PIN)
        {
            var response = await client.Post(Endpoints.CHANGECARDPIN, new { cardId, PIN, SecretKey = client.SecretKey });
            return JsonConvert.DeserializeObject<ChangePinResponse>(response);
        }


    }
}
