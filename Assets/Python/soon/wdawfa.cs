using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wdawfa : MonoBehaviour
{
   public GameObject monst;
   public GameObject tr;

   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         monst.active = true;
         Invoke(nameof(fe), 1);
      }
   }

   void fe()
   {
      Destroy(monst);
      Destroy(tr);
   }
}
