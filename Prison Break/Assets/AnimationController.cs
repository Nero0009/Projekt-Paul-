using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class AnimationController : MonoBehaviour
{
    public Transform fenster;
    public MultiAimConstraint headRotation;

    public void fensterAnimation(){
        GetComponent<Animator>().SetTrigger("Triggered");
        Vector3 newPos = fenster.position;
        Quaternion newRot = fenster.rotation;
        transform.position = newPos;
        transform.rotation = newRot;
        headRotation.weight = 1;
    }
}
