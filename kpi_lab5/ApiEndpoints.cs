using RA;
using RestSharp;
using RestSharp.Authenticators;

namespace kpi_lab5
{
    public class ApiEndpoints
    {
        public static IRestResponse GetAccountQuota(string accept, string authorization)
        {
            var client = new RestClient(Config.BASE_URL);
            var request = new RestRequest(Config.Quota, Method.GET);
            request.AddHeader("Authorization", authorization);
            request.AddHeader("Accept", accept);
            var response = client.Get(request);
            return response;
        }


        public static IRestResponse GetDomain(string domainName)
        {
            var client = new RestClient(Config.BASE_URL);
            var request = new RestRequest(Config.Domain + domainName);
            request.AddHeader("Authorization", Config.Authorization);
            request.AddHeader("Accept", Config.Accept);
            var response = client.Get(request);
            return response;
        }

        public static IRestResponse GetIP(string ip)
        {
            var client = new RestClient(Config.BASE_URL);
            var request = new RestRequest(Config.IP + ip);
            request.AddHeader("Authorization", Config.Authorization);
            request.AddHeader("Accept", Config.Accept);
            var response = client.Get(request);
            return response;
        }

        public static IRestResponse SearchEmail(string contains)
        {
            var client = new RestClient(Config.BASE_URL);
            var request = new RestRequest(Config.Email_Search, Method.POST);
            request.AddHeader("Authorization", Config.Authorization);
            request.AddHeader("Accept", Config.Accept);
            request.AddHeader("Content-Type", Config.Accept);
            request.AddJsonBody("{\"search_params\":[{\"search parameter\":{\"operator\":\"contains\",\"value\":\""+contains+"\"}},{}]}");
            var response = client.Post(request);
            return response;
        }

        public static IRestResponse DownloadEmails()
        {
            var client = new RestClient(Config.BASE_URL);
            var request = new RestRequest(Config.Email_Download, Method.POST);
            request.AddHeader("Authorization", Config.Authorization);
            request.AddHeader("Accept", Config.Accept);
            request.AddHeader("Content-Type", Config.Accept);
            request.AddJsonBody("{\"column_list\":[\"email\"],\"file_format\":\"csv\"}");
            var response = client.Post(request);
            return response;
        }
    }
}