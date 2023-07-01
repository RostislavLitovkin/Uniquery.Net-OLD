using System;
using System.Text.Json.Serialization;

namespace Uniquery.Types
{
    public class Collection
    {
        [JsonPropertyName("max")]
        public int Max { get; set; }

        [JsonPropertyName("nftCount")]
        public int NftCount { get; set; }

        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("version")]
        public object Version { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("currentOwner")]
        public string CurrentOwner { get; set; }

        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("supply")]
        public int Supply { get; set; }

        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
    }
}

