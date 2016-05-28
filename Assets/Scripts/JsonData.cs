using System;

[Serializable]
public class JsonData {
    //Json data variables
    public Args args;
    public Headers headers;
    public string origin;
    public string url;
}

[Serializable]
public class Args {
}

[Serializable]
public class Headers {
    public string Accept;
    public string Accept_Encoding;
    public string Accept_Language;
    public string Cache_Control;
    public string Cookie;
    public string Host;
    public string Upgrade_Insecure_Requests;
    public string User_Agent;
}