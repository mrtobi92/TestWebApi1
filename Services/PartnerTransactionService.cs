using DotnetWebApiUnitTesting.DTOs.Requests;
using DotnetWebApiUnitTesting.DTOs.Responses;
using DotnetWebApiUnitTesting.Models;

namespace DotnetWebApiUnitTesting.Services
{
    public class PartnerTransactionService : IPartnerTransactionService
    {
        public PartnerTransactionService()
        {
            // constructor
        }
        /// <summary>
        /// ValidatesPayLoad
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        public bool ValidatesPayLoad(PartnerTransactionRequest request)
        {
            if(!string.IsNullOrWhiteSpace(request.PartnerId) && 
                request.Amount > 0 && 
                !string.IsNullOrWhiteSpace(request.TransactionReference) &&
                !string.IsNullOrWhiteSpace(request.Currency) &&
                !request.TimeStamp.HasValue
                )

            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        /// <summary>
        /// GetPartnerId
        /// </summary>
        /// <param name="partnerId"></param>
        /// <returns></returns>
        public async Task <BaseResponse> GetPartnerId(string partnerId)
        {
            try
            {
                using (ApplicationDbContext dbContext = new ApplicationDbContext())
                {
                    PartnerTransactionModel? partner = await dbContext.PartnerTransaction.Where(u => u.PartnerId == partnerId).FirstOrDefault();
                    return new BaseResponse(StatusCodes.Status200OK, partner);
                }
            }
            catch (Exception ex)
            {
                return new BaseResponse(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
