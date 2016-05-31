using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Main : MonoBehaviour, IPointerClickHandler {
    public GameObject obj;

    public delegate void OnPointerClicked();
    public event OnPointerClicked OnClicked;
    public Text countText;
    public static int count = 0;

    // Use this for initialization
    void Start() {
        SetCountText();
        OnClicked = delegate () {
            OnClicked += obj.GetComponent<OnClickMono>().OnPointerClicked;                             //delegates the OnClickMono 
            OnClicked += obj.GetComponent<OnClickParentInfo>().OnPointerClicked;                       //delegates the ParentInfo 
            OnClicked += obj.GetComponent<OnClickHide>().OnPointerClicked;                             //delegates the Hide 
        };
    }

    public void OnPointerClick(PointerEventData eventData) {
        OnClicked();                                                                            //executes onclicked when the target has been clicked
        SetCountText();
    }

    public void SetCountText() {
            countText.text = "Collected item: " + count.ToString();                             //updates the text field
    }
    }
