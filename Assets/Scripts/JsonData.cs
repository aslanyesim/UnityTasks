using System;

[Serializable]
public class JsonData {
    //Json data variables 
    public Args args;
    public Headers headers;
    public string origin;
    public string url;

    public class Args {
    }

    public class Headers {
        public string accept;
        public string acceptEncoding;
        public string acceptLanguage;
        public string host;
        public string upgradeInsecureRequests;
        public string userAgent;
    }
}
