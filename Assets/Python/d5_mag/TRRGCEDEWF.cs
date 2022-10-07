using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRRGCEDEWF : MonoBehaviour
{
   public GameObject pll;

   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         pll.active = true;
      }
   }
}
