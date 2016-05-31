using UnityEngine;
using UnityEngine.EventSystems;

public class Main : MonoBehaviour, IPointerClickHandler {
    public GameObject obj;

    public delegate void OnPointerClicked();
    public static event OnPointerClicked OnClicked;

    // Use this for initialization
    void Start() {
        OnClicked = delegate () {
            OnClicked += obj.GetComponent<OnClickMono>().OnPointerClicked;                      //delegates the OnClickMono 
            OnClicked += obj.GetComponent<OnClickParentInfo>().OnPointerClicked;                       //delegates the ParentInfo 
            OnClicked += obj.GetComponent<OnClickHide>().OnPointerClicked;                             //delegates the Hide 
        };
    }

    public void OnPointerClick(PointerEventData eventData) {
        OnClicked();                                                                            //executes onclicked when the target has been clicked
    }
}
