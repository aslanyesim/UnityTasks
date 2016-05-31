using System;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
///Collider shows the physical collision range of the object. It gives an object a physical presence. 
///And with physics raycaster it can detect the position of the game object. 
///It returns true when the ray meets with collider.
///That’s why “on pointer click” event doesnot work correctly because we cannot detect the event without these components. 
/// </summary>
public class OnClickMono : MonoBehaviour, IPointerClickHandler {   

    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("Clicked");
    }

    void Start() {
        if (gameObject.GetComponent<BoxCollider>() || gameObject.GetComponent<MeshCollider>() && Camera.main.GetComponent<PhysicsRaycaster>()) {
            Debug.Log("Game object has the desired collider and camera has physics raycaster");
        }
    }
}
