using System.Collections;
using UnityEngine;
using UnityEngine.Experimental.Networking;

public class JsonUnitTest : MonoBehaviour {

    // Use this for initialization
    void Start() {
        StartCoroutine(jsonGetRequest());
        ExtensionMethods.jsonDataEqualityTest("");
        gameObject.getOrAddComponent<Rigidbody>();
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