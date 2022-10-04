using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hththng : MonoBehaviour
{
   private void OnTriggerStay(Collider other)
   {
      if (other.tag == "Player")
      {
         Application.LoadLevel("magazun5");
      }
   }
}
