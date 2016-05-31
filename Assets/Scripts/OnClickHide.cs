using UnityEngine;

public class OnClickHide : MonoBehaviour, OnClickMonoInterface {
    public void OnPointerClicked() {
        GetComponent<MeshRenderer>().enabled = false;                       //Hides the game object
    }
}
