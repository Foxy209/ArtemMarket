using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optimizet : MonoBehaviour
{
   public GameObject predmetu;

   void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         predmetu.active = false;
      }
   }

}
