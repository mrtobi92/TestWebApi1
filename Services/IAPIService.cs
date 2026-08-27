namespace DotnetWebApiUnitTesting.Services
{
    public interface IAPIService
    {
        /// <summary>
        /// CheckPartnerIdAsync
        /// </summary>
        /// <param name="partnerId"></param>
        /// <returns></returns>
        Task<string> CheckPartnerIdAsync(string partnerId);
    }
}
