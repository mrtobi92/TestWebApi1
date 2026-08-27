using DotnetWebApiUnitTesting.DTOs.Requests;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DotnetWebApiUnitTesting.Models
{
    [Table("PartnerTransaction")]
    public class PartnerTransactionModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public required string PartnerId { get; set; }
        public required string TransactionReference { get; set; }

        public required decimal Amount { get; set; }
        public required string Currency { get; set; }
        public DateTime? TimeStamp { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("created_at")]
        public DateTime createdAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed), Column("updated_at")]
        public DateTime updatedAt { get; set; }



        public PartnerTransactionModel()
        {
           
        }


    }
}
