using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_M1_TR : MonoBehaviour
{
    public GameObject light;
    public GameObject tr;
    public GameObject tr2;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            light.active = true;
            tr2.active = true;
            Destroy(tr);
        }
    }
}
