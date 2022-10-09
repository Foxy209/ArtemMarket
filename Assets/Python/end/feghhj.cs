using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feghhj : MonoBehaviour
{
   public GameObject tt;
   public GameObject l1;
   public GameObject l2;
   public GameObject p;
   public GameObject sc;
   public GameObject gg;

   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         Invoke(nameof(ef), 3);
      }
   }

   void ef()
   {
      Destroy(l1);
      Invoke(nameof(ee), 2);
   }
   
   void ee()
   {
      l2.active = true;
      p.active = true;
      Invoke(nameof(ff), 2);
   }

   void ff()
   {
      Destroy(tt);
      sc.active = true;
      gg.active = true;
   }
}
