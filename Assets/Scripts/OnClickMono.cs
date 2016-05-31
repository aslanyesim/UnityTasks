using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
///Collider shows the physical collision range of the object. It gives an object a physical presence. 
///And with physics raycaster it can detect the position of the game object. 
///It returns true when the ray meets with collider.
///That’s why “on pointer click” event doesnot work correctly because we cannot detect the event without these components. 
/// </summary>
public class OnClickMono : MonoBehaviour, OnClickMonoInterface {
    public void OnPointerClicked() {
        if (GetComponent<BoxCollider>() || GetComponent<MeshCollider>() && Camera.main.GetComponent<PhysicsRaycaster>()) {
            Debug.Log("Clicked");
        };
    }
}
