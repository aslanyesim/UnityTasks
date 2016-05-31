using UnityEngine;

public class OnClickHide : MonoBehaviour, OnClickMonoInterface {
    public void OnPointerClicked() {
        if (GetComponent<MeshRenderer>().enabled != false) {
            GetComponent<MeshRenderer>().enabled = false;                       //Hides the game object
            Main.count++;
        }
    }
}
