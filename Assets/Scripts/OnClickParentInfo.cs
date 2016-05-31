using UnityEngine;

public class OnClickParentInfo : MonoBehaviour, OnClickMonoInterface {
    public void OnPointerClicked() {
        Debug.Log(transform.name);                                  //writes the debug log the name of the game object 
    }
}
