using UnityEngine;

public class JsonUnitTest : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Debug.Log(jsonDataEqualityTest(""));
    }

    //Method takes json string converts an object converts it back and return the comparision result in boolean 
    public bool jsonDataEqualityTest(string jsonString) {
        JsonData temporalData = JsonUtility.FromJson<JsonData>(jsonString);                    //convert json string into c# class object
        string temporalJsonData = JsonUtility.ToJson(temporalData);                            //convert c# class object into json string  
        return (string.Compare(jsonString, temporalJsonData) == 0);                            //compare json strings and return the result
    }
}