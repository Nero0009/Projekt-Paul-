using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    //public bool continuousDamage;
    public string target;
    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider coll){
            DealDamage(coll, damage);
    }


    public void DealDamage(Collider coll, int schaden){
        if(coll.tag == target  && coll.GetComponent<DamageTaker>() != null){
                DamageTaker taker = coll.GetComponent<DamageTaker>();
                taker.takeDamage(damage);
            }
    }
    
}
