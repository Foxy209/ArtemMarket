using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_4T_1 : MonoBehaviour
{
    public GameObject tr;
    public GameObject shab;
    public GameObject shab2;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            shab2.active = true;
            shab.active = false;
            Destroy(tr);
        }
    }
}
