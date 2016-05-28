using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Networking;

public class JsonUnitTest : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Debug.Log(jsonDataEqualityTest(""));
        StartCoroutine(jsonGetRequest());
    }

    //Method takes json string converts an object converts it back and return the comparision result in boolean 
    public bool jsonDataEqualityTest(string jsonString) {
        JsonData temporalData = JsonUtility.FromJson<JsonData>(jsonString);                    //convert json string into c# class object
        string temporalJsonData = JsonUtility.ToJson(temporalData);                            //convert c# class object into json string  
        return (string.Compare(jsonString, temporalJsonData) == 0);                            //compare json strings and return the result
    }


    IEnumerator jsonGetRequest() {
        UnityWebRequest www = UnityWebRequest.Get("http://httpbin.org/get");                    //get json data
        yield return www.Send();
        if (www.isError) {
            Debug.Log(www.error);
        } else {
            JsonData temporalData = JsonUtility.FromJson<JsonData>(www.downloadHandler.text);              
            Debug.Log(temporalData.headers.Cookie);                                             //print the result
        }
    }
}