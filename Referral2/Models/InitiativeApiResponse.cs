using Newtonsoft.Json;
using System.Collections.Generic;

namespace Referral2.Models
{
    public class InitiativeApiResponse
    {
        [JsonProperty("value")]
        public List<InitiativeApiResponse> initiatives { get; set; }
    }
}
