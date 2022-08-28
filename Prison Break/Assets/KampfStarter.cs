using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.Rendering;

public class KampfStarter : MonoBehaviour
{
    GespraechsManager manager;
    public Volume sickVolume;
   
   
   public MultiAimConstraint headRotation;
   bool eWasPressed;
   bool triggered;
   bool going;
   public float duration;

   void Start(){
    manager = GetComponent<GespraechsManager>();
   }
   void Update(){
        if(Input.GetButtonDown("Interact"))eWasPressed = true;
        if(going){
           headRotation.weight += 1/duration*Time.deltaTime; 
           sickVolume.weight += 1/duration*Time.deltaTime;
           if(sickVolume.weight >= 1)going = false;
        }
        if(triggered){
            Trigger();
            triggered = false;
        }
   }

    void OnTriggerEnter(Collider collider){
        eWasPressed = false;
    }
   void OnTriggerStay(Collider collider){
    if(eWasPressed){
        triggered = true;
        going = true;
    }
   }
   void Trigger(){
        GameObject[] roboter = GameObject.FindGameObjectsWithTag("BueroRoboter");
        foreach(GameObject einzelner in roboter){
                einzelner.GetComponent<AnimationController>().fensterAnimation();
         }
        }
   }

