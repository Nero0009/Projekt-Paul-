using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnZone : MonoBehaviour
{

    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player" && collider.GetComponent<PlayerCombatAndDeath>() != null){
            collider.GetComponent<PlayerCombatAndDeath>().spawnPoint = this.transform.position;
        }
    }
}
