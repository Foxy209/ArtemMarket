using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lIGFGF : MonoBehaviour
{
    public GameObject tre3;
    public GameObject lught;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(tre3);
            lught.active = true;
        }
    }
}
