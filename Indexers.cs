using System;
namespace Uniquery
{
    public class Indexers
    {

        public static readonly Dictionary<string, string> AllIndexers = new Dictionary<string, string>()
        {
            { "rmrk", "https://squid.subsquid.io/rubick/graphql" },
            { "rmrk2", "https://squid.subsquid.io/marck/graphql" },
            // add more key-value pairs as needed
        };

        public static string Get(string name)
        {
            return AllIndexers[name];
        }
    }
}

