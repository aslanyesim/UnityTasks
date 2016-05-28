using UnityEngine;

public static class ExtensionMethods {

        //Method takes json string converts an object converts it back and return the comparision result in boolean 
        public static bool jsonDataEqualityTest(string jsonString) {
            JsonData temporalData = JsonUtility.FromJson<JsonData>(jsonString);                    //convert json string into c# class object
            string temporalJsonData = JsonUtility.ToJson(temporalData);                            //convert c# class object into json string  
            return (string.Compare(jsonString, temporalJsonData) == 0);                            //compare json strings and return the result
    }
        public static void getOrAddComponent<ComponentA>(this GameObject obj) {
        if (obj.GetComponent<ComponentA>().Equals(null)) {                                          //check whether the component is exists or not
            obj.AddComponent(typeof(ComponentA));                                                   //add the new component
            Debug.Log("New " + typeof(ComponentA) + " component added");
        } else {
             obj.GetComponent<ComponentA>();                                                        //return the existing component
        }
    }
}
