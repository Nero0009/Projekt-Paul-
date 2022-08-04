using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIElementEdit : MonoBehaviour
{
    TextMeshProUGUI thisText;

    void Start()
    {
        thisText = GetComponent<TextMeshProUGUI>();
    }

    public void setTextEnabled(bool enabled){
        thisText.enabled = enabled;
        
    }
    public void setText(string text){
        thisText.text = text;
    }
    public void clearText(){
        thisText.text = "";
    }


}
