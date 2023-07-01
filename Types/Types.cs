using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Uniquery.Types
{
    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("nftEntities")]
        public List<NftEntity> NftEntities { get; set; }
    }
}

