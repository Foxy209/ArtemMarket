using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("magazun3");
        }
    }
}
