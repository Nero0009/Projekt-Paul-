using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatAndDeath : MonoBehaviour
{
    
    DamageTaker damageTaker;
    int hp;
    public Vector3 spawnPoint;
    void Start()
    {
        damageTaker = GetComponent<DamageTaker>();
        spawnPoint = transform.position;
    }

    void Update()
    {
        if(damageTaker.health <= 0) {
            Respawn();
            damageTaker.ResetHealth();
        }
    }
    public void ChangeRespawnPoint(Vector3 position){
        spawnPoint = position;
    }
    public void Respawn(){
        transform.position = spawnPoint;
        damageTaker.ResetHealth();
    }
}
