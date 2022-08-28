using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = Referenzen.mainCamera;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position;
    }
}
