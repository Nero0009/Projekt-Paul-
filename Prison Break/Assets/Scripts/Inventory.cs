using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
   public Item[] weapons;

   private void Start() {
    InitVariables();
   }

   private void InitVariables() {
    weapons = new Item[4];
   } 
}
