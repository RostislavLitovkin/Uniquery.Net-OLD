using System;
using System.Text;
using Newtonsoft.Json;
using Uniquery.Types;

namespace Uniquery
{
    public class Uniquery
    {
        public static async Task<List<NftEntity>> GetAccountRmrk(
            string address,
            string indexer = "rmrk",
            bool showCollectionInfo = false
        )
        {
            string query = @"
                query MyQuery {
                    nftEntities(where: {currentOwner_eq: """ + address + @"""}) {
                    name
                    issuer"
+
                    (showCollectionInfo ?
                    @"
                    collection {
                        max
                        nftCount
                        symbol
                        updatedAt
                        version
                        id
                        currentOwner
                        createdAt
                        name
                        supply
                        metadata
                    }" : "") +
                    @"
                    currentOwner
                    emoteCount
                    emotes {
                        value
                        id
                        caller
                    }
                    price
                    transferable
                    id
                    hash
                    metadata
                    }
                }
            ";

            var root = await Client.FetchJsonStringAsync(query, indexer);

            Console.WriteLine(root);

            return root.NftEntities;
        }
    }
    
}

