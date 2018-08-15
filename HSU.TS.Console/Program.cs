using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HSU.TS.AppConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            var response = Task.Run(() => MainAsync()).Result;
            Console.WriteLine(response);
            Console.ReadLine();
        }
        public static async Task<string> MainAsync()
        {

            var t =  DateTime.Now.Date.Millisecond;

            return "";

            var pass16 = "E10ADC3949BA59ABBE56E057F20F883E"; //123456
            var pass19 = "25f9e794323b453885f5181f1b624d0b";//123456789
            var url = "http://localhost:61167";
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var user = "999999999";  
                var accessToken = await GetAccessToken(url,user,pass19);
                var token = string.Empty;
                if (accessToken.Length > 0)
                {
                    token = JObject.Parse(accessToken)["token"].ToString();
                }
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync("/api/ThongTinTS");
                var val = await response.Content.ReadAsStringAsync();
                var ts = JObject.Parse(val);
                var after = ModifyPassword(ts,pass16);
                var updatepassword = UpdatePassword(url,token,after);
                dynamic DynamicObject = JsonConvert.DeserializeObject<dynamic>(after);
                DynamicObject.fileName = "test1";
                DynamicObject.jsonName = "test2";


                //return $"Status Code: {response.StatusCode}\nContent: {await response.Content.ReadAsStringAsync()}";
                response = await httpClient.GetAsync("/api/ThongTinTS");
                val = await response.Content.ReadAsStringAsync();
                return $"Status Code: {response.StatusCode}\nContent: {val}";
            }
        }
        private static string ModifyPassword(JObject jObject, string newPassword)
        {
          

            foreach (var prop in jObject.Properties())
            {
                if(prop.Name.Equals("hsU_PASSWORD_TS",StringComparison.InvariantCultureIgnoreCase))
                {
                    prop.Value = newPassword;
                }
            }

            var result = jObject.ToString(Formatting.None);

            return result;
        }
        public static async Task<string> UpdatePassword(string url,string token, string content)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var body = $"{content}";
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var httpContent = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync("api/ThongtinTS/updatepassword/999999999", httpContent);
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
        public static async Task<string> GetAccessToken(string url, string user, string pass)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(url);
                var body = $"{{username: \"{user}\", Password: \"{pass}\"}}";
                var httpContent = new StringContent(body, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("api/Token", httpContent);
                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}
