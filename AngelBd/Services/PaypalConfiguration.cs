using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelBd.Services
{
    //public class PaypalConfiguration
    //{
    //    public static readonly string ClientId;
    //    public static readonly string ClientSecret;

    //    // Static constructor for setting the readonly static members.




    //    static PaypalConfiguration()
    //    {
    //        var config = GetConfig();
    //        ClientId = config["clientId"];
    //        ClientSecret = config["clientSecret"];
    //    }


    //    // Create the configuration map that contains mode and other optional configuration details.
    //    public static Dictionary<string, string> GetConfig()
    //    {
    //        return ConfigManager.Instance.GetProperties();
    //    }

    //    // Create accessToken
    //    private static string GetAccessToken()
    //    {
    //        string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
    //        return accessToken;
    //    }

    //    // Returns APIContext object
    //    public static APIContext GetAPIContext(string accessToken = "", string requestID = "")
    //    {
    //        var apiContext = new APIContext(string.IsNullOrEmpty(accessToken) ? GetAccessToken() : accessToken, string.IsNullOrEmpty(requestID) ? Guid.NewGuid().ToString() : requestID);
    //        apiContext.Config = GetConfig();
    //        return apiContext;
    //    }
    //}
}