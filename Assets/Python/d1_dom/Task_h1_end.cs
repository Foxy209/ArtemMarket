using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_h1_end : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("magazun");
        }
    }
}
