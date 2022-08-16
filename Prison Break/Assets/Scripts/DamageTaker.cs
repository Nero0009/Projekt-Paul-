using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTaker : MonoBehaviour
{
    public Slider slider;
    public int health;
    int startHealth;
    void Start()
    {
        startHealth = health;
        
        if(slider != null)
            slider.maxValue = startHealth;
    }

    void Update(){
        if(slider != null)
        slider.value = health;
    }
    public void takeDamage(int damage){
        health -= damage;
    }
    
    public void Die(){
        Destroy(this.gameObject);
    }

    public void ResetHealth(){
        health = startHealth;
    }
}