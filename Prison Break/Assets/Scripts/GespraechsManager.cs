using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GespraechsManager : MonoBehaviour
{
    [TextArea(5, 20)]
    public string voiceline;
    UIElementEdit sprechenUI;
    UIElementEdit sprechFeld;
    
    bool eWasPressed;
    
    void Start()
    {
        sprechenUI = Referenzen.canvas.GetChild(1).GetComponent<UIElementEdit>();
        sprechFeld = Referenzen.canvas.GetChild(2).GetComponent<UIElementEdit>();
    }

    void Update(){
        if(Input.GetButtonDown("Interact"))eWasPressed = true;
    }

    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player"){
            sprechenUI.setTextEnabled(true);
            eWasPressed = false;
        }
    }
    void OnTriggerExit(Collider collider){
        if(collider.tag == "Player"){
            sprechenUI.setTextEnabled(false);
            sprechFeld.clearText();
        }
    }
    void OnTriggerStay(Collider collider){
        if(collider.tag == "Player" && eWasPressed){

            sprechFeld.setText(voiceline);
            eWasPressed = false;
        }
    }
}
