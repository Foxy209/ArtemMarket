using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2_3 : MonoBehaviour
{
    public GameObject cam;
    public GameObject tr;
    public GameObject pl;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(tr);
            cam.active = true;
            pl.active = false;
        }
    }
}
