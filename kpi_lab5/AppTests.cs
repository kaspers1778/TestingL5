using System;
using System.Net;
using System.Threading.Channels;
using RA;
using Xunit;

namespace kpi_lab5
{
    public class AppTests
    {

        //Get
        [Fact]
        public void GetAccountQuota()
        {
            var response = ApiEndpoints.GetAccountQuota(Config.Accept, Config.Authorization);
            Console.WriteLine(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        //Get
        [Fact]
        public void GetValidIP()
        {
            var response = ApiEndpoints.GetIP(Config.ValidIP);
            Console.WriteLine(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
          //Post
        [Fact]
        public void TryDownloadEmail()
        {
            var response = ApiEndpoints.DownloadEmails();
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        //Post
        [Fact]
        public void SearchEmailContains()
        {
            var response = ApiEndpoints.SearchEmail(Config.EmailContains);
            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }
        
        //Get
        [Fact]
        public void GetValidDomain()
        {
            var response = ApiEndpoints.GetDomain(Config.ValidDomain);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        //Get
        [Fact]
        public void GetInvalidDomain()
        {
            var response = ApiEndpoints.GetDomain(Config.InvalidDomain);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
        
    }
}
