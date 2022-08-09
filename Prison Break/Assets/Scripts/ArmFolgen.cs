using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmFolgen : MonoBehaviour
{
    public Transform arm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = arm.position;
        this.transform.rotation = arm.rotation;
    }
}
