using DotnetWebApiUnitTesting.Controllers;
using DotnetWebApiUnitTesting.DTOs.Responses;
using DotnetWebApiUnitTesting.Models;
using DotnetWebApiUnitTesting.Services;
using Microsoft.AspNetCore.Http;
using Moq;

namespace UnitTests
{
public class PartnerTransactionControllerTest
{
    private Mock<IPartnerTransactionService> partnerTransactionServiceMock;

    public PartnerTransactionControllerTest()
    {
        partnerTransactionServiceMock = new Mock<IPartnerTransactionService>();
    }

    [Fact]
    public void TestPartnerVerification()
    {

        // define output from the service

        PartnerTransactionModel partner = new PartnerTransactionModel(
        {
            PartnerId: "P-1001",
            TransactionReference: "TXN-99823",
            Amount: 250.00,
            Currency: "USD",
            Timestamp: "2024-05-10T14:30:00Z",
            createdAt = DateTime.Now,
            updatedAt = DateTime.Now
        };


        BaseResponse PartnerTransactionResponse = new BaseResponse(StatusCodes.Status200OK, users);
        partnerTransactionServiceMock.Setup(um => um.(PartnerTransactionModel())).Returns(PartnerTransactionResponse);


         PartnerTransactionController partnerController = new PartnerTransactionController(partnerTransactionServiceMock.Object);

        // 2. Act

        var partnerTransactionResponse = PartnerTransactionController.PartnerVerification(PartnerTransactionModel.PartnerId);


        // 3. Assert

        // test response type
         Assert.IsType<BaseResponse>(partnerTransactionResponse);

        // test response status code
        Assert.Equal(200, partnerTransactionResponse.statusCode);

        // test response data type
        Assert.IsType<PartnerTransactionModel()>(partnerTransactionResponse.data);
        

  }


}

