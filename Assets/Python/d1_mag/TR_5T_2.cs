using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TR_5T_2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("dom2");
        }
    }
}
