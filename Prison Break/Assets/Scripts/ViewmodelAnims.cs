using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewmodelAnims : MonoBehaviour {

    public char armNummer;
    public bool rechts;
    float movementInput;
    PlayerMovement playerMovement;
    bool grounded;
    
    Animator anim;
    void Start() {
        anim = GetComponent<Animator>();
        //Ich nehme die Grounded Variable aus dem PlayerMovement Skript, um selbst keinen Groundcheck implementieren zu müssen.
        playerMovement = transform.parent.parent.parent.gameObject.GetComponent<PlayerMovement>();
        anim.SetBool("Rechts", rechts);
        
    }
    void Update()
    {
        //Der Input wird eingelesen und an den Animator geschickt, um zu prüfen, ob die Lauf Animation gespielt werden soll.
        movementInput = Input.GetAxisRaw("Vertical");
        grounded = playerMovement.grounded;

        anim.SetFloat("Input", movementInput);
        anim.SetBool("Grounded", grounded);
    
        if(Input.GetButtonDown("Fire"+ armNummer)) anim.SetTrigger("Shoot");
        if(Input.GetButtonUp("Fire"+ armNummer)) anim.SetTrigger("Stop");
    }
}
