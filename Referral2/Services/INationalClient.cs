using System.Threading.Tasks;

namespace Referral2.Services
{
    public interface INationalClient
    {
        Task<TResp> Get<TReq, TResp>(NationalWebApiRequest<TReq> request);

    }
}
