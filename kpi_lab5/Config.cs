namespace kpi_lab5
{
    public class Config
    {
        public static string BASE_URL = "https://api.spyse.com/v4/data";
        public static string Domain = BASE_URL + "/domain/";
        public static string Quota = BASE_URL + "/account/quota";
        public static string Email_Search = BASE_URL + "/email/search";
        public static string Email_Download = BASE_URL + "/email/search/download";
        public static string IP = BASE_URL + "/ip/";
        public static string ValidIP = "198.168.0.1";
        public static string ValidDomain = "google.com";
        public static string InvalidDomain = "404";
        public static string Accept  = "application/json";
        public static string Authorization = "Bearer 15311729-c9ad-430f-82c5-e4df5ff9e732";
        public static string EmailContains = "pet";
    }
}
}