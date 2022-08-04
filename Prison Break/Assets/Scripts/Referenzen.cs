using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referenzen : MonoBehaviour
{
    public static Transform player{get; private set;}
    public static Transform canvas{get; private set;}
   // public static Transform sprechen{get; private set;}

    
    public Transform pPlayer;
    public Transform pCanvas;
    //public Transform pSprechen;
    
    void Awake(){
        player = pPlayer;
        canvas = pCanvas;
       // sprechen = pSprechen;
    }
}
