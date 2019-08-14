using System;

namespace Crew.Unsplash
{
    public class HttpClient
    {
        private readonly HttpClient _client;

        public HttpClient(HttpClient client)
        {
            _client = client;
        }
    }
}
