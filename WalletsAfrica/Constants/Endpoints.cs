using System;
namespace WalletsAfrica.Constants
{
    public class Endpoints
    {
        public const string BALANCE = "/self/balance";
        public const string TRANSACTIONS = "/self/transactions";


        public const string DEBITWALLET = "/wallet/debit";
        public const string CREDITWALLET = "/wallet/credit";
        public const string GENERATESUBWALLET = "/wallet/generate";
        public const string RETRIEVEACCOUNTNUMBER = "/wallet/nuban";
        public const string SETPASSWORD = "/wallet/password";
        public const string SETPIN = "/wallet/pin";
        public const string WALLETTRANSACTIONS = "/wallet/transactions";
        public const string VERIFYBVN = "/wallet/verifybvn";
        public const string GETUSER = "/wallet/getuser";
        public const string WALLETBALANCE = "/wallet/balance";

        public const string BANKTRANSFERDETAILS = "/transfer/bank/details";
        public const string BANKACCOUNTTRANSFER = "/transfer/bank/account";
        public const string BANKACCOUNTENQUIRY = "/transfer/bank/account/enquire";
        public const string GETBANKS = "/transfer/banks/all";

        public const string AIRTIMEPROVIDERS = "/bills/airtime/providers";
        public const string AIRTIMEPURCHASE = "/bills/airtime/purchase";

        public const string RESOLVEBVN = "/account/resolvebvn";
        public const string RESOLVEBVNWITHDETAILS = "/account/resolvebvn/details";

        public const string STATESANDLGAS = "/cards/states";
        public const string IDENTITYTYPES = "/cards/Idtypes";
        public const string CREATECARD = "/cards/create";
        public const string FUNDCARD = "/cards/fund";
        public const string DEBITCARD = "/cards/withdraw";
        public const string FREEZEECARD = "/cards/freeze";
        public const string UNFREEZEECARD = "/cards/unfreeze";
        public const string CARDDETAILS = "/cards/details";
        public const string CARDTRANSACTIONS = "/cards/transactions";
        public const string CHANGECARDPIN = "/cards/ChangePin";


    }
}
