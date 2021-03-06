﻿namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripePlanUpdateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
