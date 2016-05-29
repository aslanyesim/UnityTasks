using UnityEngine;

public class CubeAnimation : MonoBehaviour {
    // Use this for initialization
    void Start () {
        LeanTween.delayedCall(gameObject, 3f, () => gameObject.GetComponent<Rigidbody>().isKinematic = false);              //waits 3 seconds and makes the kinematic of the object false for bouncing effect
        LeanTween.delayedCall(gameObject, 6f, () => gameObject.GetComponent<Rigidbody>().isKinematic = true);               //waits 6 seconds and makes the kinematic of the object true for stopping bouncing effect
        LeanTween.delayedCall(gameObject, 6f, () => LeanTween.scale(gameObject, new Vector3(0.0f, 0.0f, 0.0f), 3.0f));      //scales the cube until it disappear 
    }
	
}
