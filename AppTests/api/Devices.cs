using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;

namespace AppTests.api
{
    class Devices
    {
        public static IConfiguration configuration;
        private double responseTime;
        public double ResponseTime
        {
            get { return responseTime; }
        }

        public Devices()
        {
            configuration = InitConfiguration();
        }

        private static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            return config;
        }

        public JObject GenerateDevice(string sessionId)
        {
            var stopWatch = Stopwatch.StartNew();
            using HttpClient httpClient = new HttpClient();
            {
                httpClient.DefaultRequestHeaders.Add("ApiKey", configuration.GetSection("Behavior:ApiKey").Value);

                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, configuration.GetSection("Behavior:Uri").Value + "/devices"); ;

                string content = JsonConvert.SerializeObject(new { SessionID = sessionId, ExternalID = "0" });

                request.Content = new StringContent(content, Encoding.UTF8, "application/json");

                HttpResponseMessage response = httpClient.SendAsync(request).Result;

                responseTime = stopWatch.Elapsed.TotalMilliseconds;

                if (response.StatusCode.ToString().Equals("Created"))
                {
                    Stream receiveStream = response.Content.ReadAsStreamAsync().Result;

                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                    string responseBody = readStream.ReadToEnd();
                    return (JObject)JsonConvert.DeserializeObject(responseBody);
                }
                else
                {
                    return null;

                }
            }
        }
    }
}
