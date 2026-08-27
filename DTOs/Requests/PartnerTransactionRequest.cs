namespace DotnetWebApiUnitTesting.DTOs.Requests   
{
    public class PartnerTransactionRequest
    {
        public required string PartnerId { get; set; }
        public required string TransactionReference { get; set; }

        public required decimal Amount { get; set; }
        public required string Currency { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
