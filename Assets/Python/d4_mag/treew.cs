using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treew : MonoBehaviour
{
     public GameObject Tocka;
     public GameObject tr;
     public GameObject tr2;
     public GameObject korob;
     public GameObject pepl;
     public GameObject kr;
     public GameObject de;
     private void OnTriggerStay(Collider other)
     {
         if (other.tag == "Player")
         {
             tr2.active = true;
             Tocka.active = false;
             korob.active = true;
             pepl.active = true;
             kr.active = true;
             de.active = false;
             Destroy(tr);
         }
     }
}
