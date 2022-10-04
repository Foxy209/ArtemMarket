using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_2T_2 : MonoBehaviour
{
   public GameObject eda;
   public GameObject tr;
   public GameObject box;

   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         eda.active = true;
         box.active = true;
         Destroy(tr);
      }
   }
}
