using System;
namespace WalletsAfrica.Entities.Cards
{
    public class ExchangeRates
    {
        public string ResponseCode { get; set; }
        public string BaseCurrency { get; set; }
        public string Date { get; set; }
        public Rates rates { get; set; }
    }


    public class Rates
    {
        public double USD { get; set; }
    }
}
