using DotnetWebApiUnitTesting.DTOs.Requests;
using DotnetWebApiUnitTesting.DTOs.Responses;

namespace DotnetWebApiUnitTesting.Services
{
    public interface IPartnerTransactionService
    {
        /// <summary>
        /// GetPartnerId
        /// </summary>
        /// <param name="partnerId"></param>
        /// <returns></returns>
        Task<BaseResponse> GetPartnerId(string partnerId);
        /// <summary>
        /// ValidatesPayLoad
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool ValidatesPayLoad(PartnerTransactionRequest request);

    }
}
