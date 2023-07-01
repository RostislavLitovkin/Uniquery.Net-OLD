using System;
using System.Text.Json.Serialization;

namespace Uniquery.Types
{
    public class NftEntity
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("collection")]
        public Collection Collection { get; set; }

        [JsonPropertyName("currentOwner")]
        public string CurrentOwner { get; set; }

        [JsonPropertyName("emoteCount")]
        public int EmoteCount { get; set; }

        [JsonPropertyName("emotes")]
        public List<object> Emotes { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("transferable")]
        public int Transferable { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
    }
}

