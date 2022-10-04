using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T5_1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("dom3");
        }
    }
}
