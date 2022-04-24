using System;
using System.Net;

namespace OutlookGoogleCalendarSync.Extensions {

    public class OgcsWebClient : WebClient {

        protected override WebRequest GetWebRequest(Uri address) {
            HttpWebRequest request = base.GetWebRequest(address) as HttpWebRequest;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36"; // Settings.Instance.Proxy.BrowserUserAgent;
            return request;
        }
    }
}
