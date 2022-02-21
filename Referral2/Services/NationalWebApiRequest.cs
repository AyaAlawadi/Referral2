using System.Collections.Generic;
namespace Referral2.Services
{
    public class NationalWebApiRequest<T>
    {
        public string Endpoint;
        public List<T> RequestBody;
    }
}