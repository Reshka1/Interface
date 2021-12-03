using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        HttpClient httpClient;
        private string getUrl = "http://locahost:8080/laptop-bag/webapi/api/all" ;

        [SetUp]
        public void Setup()
        {
            httpClient = new HttpClient();
        }

        [Test]
        public void TestGetAllEndPointWithUr()
        {
            Uri getUri = new Uri(getUrl);
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());
            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine("Status Code =>" + statusCode);
            Console.WriteLine("Status Code =>" + (int)statusCode);

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine(data);

            httpClient.Dispose();
        }

        [Test]
        public void TestGetAllEndPointWithInvalidUrl()
        {
            Uri getUri = new Uri(getUrl + "/random");
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());
            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine("Status Code =>" + statusCode);
            Console.WriteLine("Status Code =>" + (int)statusCode);

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine(data);

            httpClient.Dispose();
        }

        [Test]
        public void TestGetAllEndPointInJsonFormat()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            requestHeaders.Add("Accept", "application/json");

            httpClient.Dispose();
        }
    }
}

