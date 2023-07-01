using System;
using System.Text;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Uniquery.Types;

namespace Uniquery
{
	public class Client
	{
        private static GraphQLHttpClient client = new GraphQLHttpClient(Indexers.Get("rmrk"), new NewtonsoftJsonSerializer());

        public static async Task<Data> FetchJsonStringAsync(string query, string indexer)
        {
            var request = new GraphQLRequest
            {
                Query = query,
                OperationName = "MyQuery",
                Variables = null,
            };

            var response = await client.SendQueryAsync<Data>(request);

            return response.Data;
        }
    }
}

