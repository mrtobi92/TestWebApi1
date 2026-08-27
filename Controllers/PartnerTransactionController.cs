using DotnetWebApiUnitTesting.DTOs.Requests;
using DotnetWebApiUnitTesting.DTOs.Responses;
using DotnetWebApiUnitTesting.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApiUnitTesting.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PartnerTransactionController : ControllerBase
    {
        private readonly IPartnerTransactionService partnerTransactionService;
        private readonly IAPIService apiService;

        public PartnerTransactionController(IPartnerTransactionService partnerTransactionService,
                                            IAPIService apiService)
        {
            this.partnerTransactionService = partnerTransactionService;
            this.apiService = apiService;
        }


        [HttpPost]
        public async Task <BaseResponse> Transactions(PartnerTransactionRequest request)
        {
            var validPayload = partnerTransactionService.ValidatesPayLoad(request);
            if (validPayload)
            {
              return await apiService.CheckPartnerIdAsync(request.PartnerId);
            }
            else
            {
                return new BaseResponse(StatusCodes.Status500InternalServerError, "PayLoad is Invalid");
            }
            
        }


        [HttpGet]
        public async Task<BaseResponse> PartnerVerification(string partnerId)
        {
            return await partnerTransactionService.GetPartnerId(partnerId);
        }

    }
}
