using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewmodelAnims : MonoBehaviour {

    public char armNummer;
    float movementInput;
    PlayerMovement playerMovement;
    bool grounded;
    
    Animator anim;
    void Start() {
        anim = GetComponent<Animator>();
        //Ich nehme die Grounded Variable aus dem PlayerMovement Skript, um selbst keinen Groundcheck implementieren zu müssen.
        playerMovement = transform.root.gameObject.GetComponent<PlayerMovement>();
        
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
