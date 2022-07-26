using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTargetSkript : MonoBehaviour
{
    Vector3 target;
    public Transform grapplingGun;
    void Start()
    {
        target = grapplingGun.GetComponent<GrapplingGun>().GetGrapplePoint();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target;
    }
}
